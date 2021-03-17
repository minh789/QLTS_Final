USE MilkTeaShop
GO

CREATE PROC USP_GetAccountByUserName	
@username NVARCHAR(50)
AS
BEGIN
	SELECT* FROM dbo.Account WHERE @username=UserName
END
GO

--EXEC dbo.USP_GetAccountByUserName @username = N'kminh' -- nvarchar(50)
--GO

CREATE PROC USP_GetAccount	
AS
BEGIN
	SELECT* FROM dbo.Account 
END
GO
 
--EXEC dbo.USP_GetAccount
--GO

CREATE PROC USP_Login	
@userName NVARCHAR(100),@passWord NVARCHAR(100), @position NVARCHAR(100)
AS
BEGIN
	SELECT* FROM dbo.Account WHERE  @userName=UserName AND @passWord=PassWord  AND @position=Position
END
GO

CREATE PROC USP_GetCardList
AS
BEGIN
	SELECT* FROM dbo.OrderCard
END
GO

--EXECUTE dbo.USP_GetCardList

--SET IDENTITY_INSERT OrderCard ON

CREATE PROC CardUpdate(@i int)
AS
	BEGIN
		--DBCC CHECKIDENT(OrderCard, RESEED, 0)
		INSERT dbo.OrderCard VALUES (@i, N'Thẻ số '+CAST(@i AS NVARCHAR(44)), 0)
		SELECT* FROM dbo.OrderCard
	END
GO
--DROP PROC CardUpdate

--EXEC CardUpdate 31

CREATE PROC CardRemove(@i int)
AS
	BEGIN
		--DBCC CHECKIDENT(OrderCard, RESEED, 0)
		DELETE dbo.OrderCard WHERE CardId=@i
		SELECT* FROM dbo.OrderCard
	END
GO

--UPDATE dbo.CardUpdate SET CardStatus = N'Đã có người' WHERE CardId =9


CREATE PROC USP_GetPos(@Username nvarchar(100), @pass nvarchar(100))
AS
	BEGIN
		SELECT position
		FROM dbo.Account
		WHERE Username=@Username AND PassWord=@pass
	END
GO
--EXEC USP_GetPos N'hminh', N'minhdesigner' 

--EXEC USP_GetPos N'kminh', N'1701yeu2409' 

CREATE PROC CheckAccount(@Username nvarchar(100), @pass nvarchar(100))
AS
	BEGIN
		DECLARE @Bool nvarchar(10)
		SET @Bool=(SELECT COUNT(*) FROM dbo.Account WHERE @Username = Username AND @pass = PassWord)
		IF(@Bool=1)
			SELECT N'true'
		IF(@Bool=0)
			SELECT N'false'
	END
GO
--DROP PROC CheckAccount
--EXEC CheckAccount N'hminh', 'minhdesigner'
--EXEC CheckAccount N'hminh1', 'minhdesigner1'


CREATE PROC SelectCategoryNumber(@CategoryId nvarchar(10))
AS
	BEGIN
		SELECT COUNT(*) FROM Category WHERE (CategoryId = @CategoryId)
	END
GO
--EXEC SelectCategoryNumber N'N0'

CREATE PROC SelectAllCategoryId
AS
	BEGIN
		SELECT CategoryId FROM Category
	END
--EXEC SelectAllCategoryId
GO

CREATE PROC SelectCategoryName(@Cid varchar(10))
AS
	BEGIN
		SELECT CategoryName FROM Category WHERE CategoryId=@Cid
	END
--EXEC SelectCategoryName 'ORG'
GO

/*CREATE PROC InsertBill(@CardId int)
AS
	BEGIN
		INSERT dbo.Bill VALUES (CAST(@CardId AS VARCHAR(10)) + CAST(DatePart(Hour, GetDate()) AS varchar(10)) + CAST(DatePart(Minute, GetDate()) AS varchar(10)) + CAST(DatePart(SECOND, GetDate()) AS varchar(10)), 
		@CardId, getDate(), 0, 0)
		
		SELECT* FROM dbo.Bill
	END	
GO*/

CREATE PROC GetBillId(@CardId int)
AS
	BEGIN
		--DBCC CHECKIDENT(BillDetail, RESEED, 1)
		SELECT CAST(@CardId AS VARCHAR(10)) + CAST(DatePart(Hour, GetDate()) AS varchar(10)) + CAST(DatePart(Minute, GetDate()) AS varchar(10)) + CAST(DatePart(SECOND, GetDate()) AS varchar(10)) + CAST(DatePart(Day, GetDate()) AS varchar(10)) + CAST(DatePart(Month, GetDate()) AS varchar(10))
	END	
GO

CREATE PROC GetBillDetailId(@BillId varchar(10))
AS
	BEGIN
		--DBCC CHECKIDENT(BillDetail, RESEED, 1)
		SELECT @BillId + CAST(DatePart(Minute, GetDate()) AS varchar(10)) + CAST(DatePart(SECOND, GetDate()) AS varchar(10))
	END	
GO
--DROP PROC GetBillDetailId
--DROP PROC GetBillId
--DBCC CHECKIDENT(OrderCard, RESEED, 0)
--InsertBill 1
--EXEC GetBillDetailId '310646'

CREATE PROC GetCurrentDate
AS
	BEGIN
		SELECT GETDATE()
	END
GO

CREATE PROC GetLatestBillId 
AS
	BEGIN
		SELECT TOP 1 *
		FROM Bill
		ORDER BY BillDate DESC
	END
GO

--SET IDENTITY_INSERT BillDetail Off

CREATE PROC InsertBillDetail(@BillId varchar(10), @DrinkId varchar(10), @Number int, @Size varchar(10), /*@Topping varchar(250),*/ @Ice varchar(10), @Sugar varchar(10), @BillDetailPrice int)
AS
	BEGIN
		INSERT INTO BillDetail(BillId) VALUES(@BillId)
		INSERT INTO BillDetail(DrinkId) VALUES(@DrinkId)
		INSERT INTO BillDetail(Number) VALUES(@Number)
		INSERT INTO BillDetail(Size) VALUES(@Size)
		--INSERT INTO BillDetail(Topping) VALUES(@Topping)
		INSERT INTO BillDetail(Ice) VALUES(@Ice)
		INSERT INTO BillDetail(Sugar) VALUES(@Sugar)
		INSERT INTO BillDetail(BillDetailPrice) VALUES(@BillDetailPrice)
	END
--INSERT INTO BillDetail VALUES('2185853', 'TRADIT', 1, N'S (Nhỏ)', N'Trân châu vàng', '50%', '50%', 25000)
GO
CREATE PROC GetBillDetailByLatestBillId
AS
	BEGIN
		SELECT *
		FROM BillDetail 
		WHERE BillId=(SELECT TOP 1 BillId FROM Bill ORDER BY BillDate DESC)
	END
GO

CREATE TRIGGER tr_UpdateBill 
ON BillDetail
	FOR INSERT
		AS
			BEGIN
				UPDATE Bill SET TotalPrice+=inserted.BillDetailPrice
				FROM inserted
				WHERE inserted.BillId=Bill.BillId
			END
GO

CREATE TRIGGER tr_UpdateBillFromTopping
ON BillDetailTopping
	FOR INSERT
		AS
			BEGIN
				UPDATE Bill SET TotalPrice+=(dbo.ToppingTable.ToppingPrice*dbo.BillDetail.Number)
				FROM inserted, dbo.BillDetail, dbo.ToppingTable
				WHERE inserted.ToppingId=dbo.ToppingTable.ToppingId AND  inserted.BillDetailId=dbo.BillDetail.BillDetailId
			END
GO
--DROP TRIGGER tr_UpdateBill
--INSERT INTO BillDetail VALUES('2185853', 'TRADIT', 1, N'S (Nhỏ)', N'Trân châu vàng', '50%', '50%', 25000)


--INSERT INTO BillDetail VALUES('10212350', 'TRADIT', 1, N'S (Nhỏ)', N'Trân châu vàng', '50%', '50%', 25000)

--DBCC CHECKIDENT(BillDetail, RESEED, 0)

--INSERT INTO BillDetail VALUES('1104822385', '1104822312', 'TRADIT', 1, N'S (Nhỏ)', N'Trân châu vàng', '50%', '50%', 25000)

CREATE PROC InsertBillDetailTopping(@BillDetailId varchar(20), @ToppingId varchar(10))
AS
	BEGIN
		Insert Into BillDetailTopping VALUES (@BillDetailId, @ToppingId)
		/*SELECT @BillDetailId
		FROM BillDetailTopping*/
	END
GO
--DROP proc InsertBillDetailTopping
--InsertBillDetailTopping '17525124125259' 'TRCHAU'
--Insert Into BillDetailTopping VALUES ('17525124125259', 'TRCHAU')

CREATE PROC GetBillDetailTopping(@BillDetailId varchar(20))
AS
	BEGIN
		SELECT ToppingId
		FROM BillDetailTopping
		WHERE BillDetailId=@BillDetailId
	END
GO
CREATE PROC GetToppingPrice (@ToppingId varchar(10))
AS
	BEGIN
		SELECT ToppingPrice
		FROM ToppingTable
		WHERE ToppingId = @ToppingId
	END
GO
CREATE PROC GetBillDetailQuantity (@BillDetailId varchar(20))
AS
	BEGIN
		SELECT Number
		FROM BillDetail
		WHERE @BillDetailId=BillDetailId
	END
GO

CREATE TRIGGER tr_UpdateBillDetailPrice
ON BillDetailTopping
	FOR INSERT
		AS
			BEGIN
				UPDATE BillDetail SET BillDetailPrice+=ToppingTable.ToppingPrice*BillDetail.Number
				FROM inserted, ToppingTable, BillDetail
				WHERE inserted.ToppingId=ToppingTable.ToppingId
			END
GO
--DROP TRIGGER tr_UpdateBillDetailPrice
--INSERT INTO BillDetailTopping VALUES ('8847724124717', 'TRCHAU');

CREATE TRIGGER tr_UpdateCardStatus
ON dbo.Bill
	FOR INSERT 
		AS
			BEGIN
				UPDATE dbo.OrderCard SET CardStatus=1
				FROM Inserted, dbo.OrderCard
				WHERE Inserted.CardId=dbo.OrderCard.CardId
			END
GO

/*CREATE TRIGGER tr_DeleteBill
ON dbo.Bill
	FOR DELETE 
		AS
			BEGIN
				DELETE ToppingTable
				WHERE ToppingTable.BillDetailId=BillDetail.BillDetailId

				DELETE BillDetail 
				WHERE BillDetail.BillId=deleted.BillId

				DELETE OrderCard
				WHERE deleted.
			END
GO*/


CREATE PROC sp_UpdateCardStatusToEmpty(@CardId int)
AS
	BEGIN
		UPDATE dbo.OrderCard SET dbo.OrderCard.CardStatus=0
		WHERE dbo.OrderCard.CardId=@CardId
	END
GO

CREATE PROC sp_GetCardStatus(@CardId int)
AS
	BEGIN
		SELECT CardStatus
		FROM dbo.OrderCard
		WHERE dbo.OrderCard.CardId=@CardId
	END
GO

CREATE PROC USP_UpadateAccount
@userName NVARCHAR(100) ,@displayName  NVARCHAR(100) ,@passWord  NVARCHAR(100) ,@newPassWord  NVARCHAR(100) 
AS
BEGIN
		DECLARE @checkPass INT =0
        SELECT @checkPass=COUNT(*) FROM Account  WHERE @username = UserName AND @passWord=PassWord
		IF(@checkPass =1)
		BEGIN
				IF(@newPassWord = NULL OR @newPassWord= '')
				BEGIN
				UPDATE dbo.Account SET DisplayName=@displayName  WHERE UserName=@userName AND PassWord=@passWord
				END
				ELSE
                BEGIN
				UPDATE dbo.Account SET DisplayName=@displayName,PassWord=@newPassWord  WHERE UserName=@userName AND PassWord=@passWord
				END
	END
END
GO

CREATE PROC SelectToppingDetail(@BillDetailId varchar(20))
AS
	BEGIN
		SELECT BillDetail.BillDetailId, ToppingName
		FROM BillDetailTopping INNER JOIN BillDetail ON BillDetail.BillDetailId=BillDetailTopping.BillDetailId INNER JOIN ToppingTable ON BillDetailTopping.ToppingId=ToppingTable.ToppingId
		WHERE @BillDetailId=BillDetailTopping.BillDetailId
	END
GO
--DROP PROC SelectToppingDetail
--EXEC SelectToppingDetail '12012292411237'

CREATE PROC CountTopping(@BillDetailId varchar(20))
AS
	BEGIN
		SELECT COUNT(*)
		FROM BillDetailTopping INNER JOIN BillDetail ON BillDetail.BillDetailId=BillDetailTopping.BillDetailId
		WHERE @BillDetailId=BillDetailTopping.BillDetailId
	END
GO
--EXEC CountTopping '12012292411237'

--EXEC GetBillDetailQuantity '1021374224381'

CREATE PROC SelectBillDetail(@BillId varchar(20))
AS
	BEGIN
		SELECT *
		FROM BillDetail INNER JOIN Bill ON Bill.BillId=BillDetail.BillId AND @BillId=Bill.BillId
	END
GO
--EXEC SelectBillDetail '102113542412'

CREATE PROC Encrypt(@Pass varchar(100))
AS
	BEGIN
		SELECT SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('MD5', @Pass)), 3, 32)
	END
GO
--SELECT SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('MD5', 'HelloWorld')), 3, 32)
/*DROP PROC Encrypt
EXEC Encrypt quanly
EXEC Encrypt quibuu
EXEC Encrypt quyencothu
EXEC Encrypt choiloa*/

CREATE PROC SearchCategoryByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM Category
		WHERE CategoryId LIKE '%'+@Text+'%' OR CategoryName LIKE '%'+@Text+'%'
	END
	GO
CREATE PROC SearchDrinkByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM Drink
		WHERE DrinkId LIKE '%'+@Text+'%' OR DrinkName LIKE '%'+@Text+'%'
	END
	GO
CREATE PROC SearchToppingByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM ToppingTable
		WHERE ToppingId LIKE '%'+@Text+'%' OR ToppingName LIKE '%'+@Text+'%'
	END
	GO
CREATE PROC SearchBillByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM Bill
		WHERE BillId LIKE '%'+@Text+'%' OR BillDate LIKE '%'+@Text+'%' OR TotalPrice LIKE '%'+@Text+'%'
	END
	GO
	--DROP PROC SearchBillByText
	--EXEC SearchBillByText '1'
CREATE PROC SearchBillDetailByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM BillDetail
		WHERE BillDetailId LIKE '%'+@Text+'%' OR DrinkId LIKE '%'+@Text+'%' OR BillDetailPrice LIKE '%'+@Text+'%'
	END
GO
CREATE PROC SearchAccDetailByText(@Text nvarchar(100))
AS
	BEGIN
		SELECT *
		FROM Account
		WHERE Username LIKE '%'+@Text+'%' OR DisplayName LIKE '%'+@Text+'%' OR Position LIKE '%'+@Text+'%'
	END
GO

CREATE PROC RevenueByDate(@D1 VARCHAR(20), @D2 VARCHAR(20))
AS
	BEGIN
		SELECT convert(varchar, BillDate, 103) AS N'Ngày', SUM(TotalPrice) AS N'Doanh thu'
		FROM Bill
		WHERE BillDate BETWEEN @D1+' 00:00:00' AND @D2+' 23:59:59.999' --AND DATEDIFF(DAY, CAST(@D1 AS smalldatetime), @D2)>1
		GROUP BY convert(varchar, BillDate, 103)
	END
GO
--DROP PROC RevenueByDate
--EXEC RevenueByDate '2020-12-26', '2020-12-26'

CREATE PROC BillDetailCount(@BillId varchar(20))
AS
	BEGIN
		SELECT TotalPrice FROM Bill WHERE Bill.BillId=@BillId
	END
go

CREATE PROC IfBillDetailIsEmpty(@BillId varchar(20), @BillDetailCount int)
AS
	BEGIN
		IF(@BillDetailCount=0)
			BEGIN
				DELETE Bill WHERE BillId = @BillId
			END
	END
go

--EXEC IfBillDetailIsEmpty '131115332512', 0
--EXEC BillDetailCount '131115332512'

--EXEC Encrypt '0'

CREATE PROC BestSellers(@D1 VARCHAR(20), @D2 VARCHAR(20))
AS
	BEGIN
		SELECT DrinkName, SUM(Number)
		FROM dbo.BillDetail, dbo.Drink, dbo.Bill
		WHERE dbo.BillDetail.DrinkId=dbo.Drink.DrinkId AND BillDetail.BillId=Bill.BillId AND BillDate BETWEEN @D1+' 00:00:00' AND @D2+' 23:59:59.999'
		GROUP BY DrinkName
		ORDER BY SUM(Number) DESC
	END
GO

INSERT dbo.Bill
(
    BillId,
    CardId,
    BillDate,
    TotalPrice
)
VALUES
(   '1',        -- BillId - varchar(20)
    1,         -- CardId - int
    '2020-12-25', -- BillDate - datetime
    0          -- TotalPrice - int
    )
INSERT dbo.BillDetail
(
    BillDetailId,
    BillId,
    DrinkId,
    Number,
    Size,
    Ice,
    SUGAR,
    BillDetailPrice
)
VALUES
(   '1',  -- BillDetailId - varchar(20)
    '1',  -- BillId - varchar(20)
    'FMILK',  -- DrinkId - varchar(10)
    1,   -- Number - int
    N'', -- Size - nvarchar(10)
    '0',  -- Ice - varchar(10)
    '0',  -- SUGAR - varchar(10)
    20000    -- BillDetailPrice - int
    )