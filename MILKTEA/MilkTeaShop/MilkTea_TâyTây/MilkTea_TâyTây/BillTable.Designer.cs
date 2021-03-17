namespace MilkTea_TâyTây
{
    partial class BillTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDetailDGV = new System.Windows.Forms.DataGridView();
            this.BillId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrinkId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.deleteBillBtn = new System.Windows.Forms.Button();
            this.billIdTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // billDGV
            // 
            this.billDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.CardId,
            this.BillDate,
            this.TotalPrice});
            this.billDGV.Location = new System.Drawing.Point(0, 52);
            this.billDGV.Name = "billDGV";
            this.billDGV.Size = new System.Drawing.Size(563, 582);
            this.billDGV.TabIndex = 0;
            this.billDGV.DoubleClick += new System.EventHandler(this.billDGV_DoubleClick);
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "Mã HĐ";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            // 
            // CardId
            // 
            this.CardId.DataPropertyName = "CardId";
            this.CardId.HeaderText = "Mã thẻ";
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "Ngày HĐ";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Thanh toán";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // billDetailDGV
            // 
            this.billDetailDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.billDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDetailDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId1,
            this.BillDetailId,
            this.DrinkId2,
            this.Number,
            this.Size,
            this.Ice,
            this.Sugar,
            this.BillDetailPrice});
            this.billDetailDGV.Location = new System.Drawing.Point(561, 52);
            this.billDetailDGV.Name = "billDetailDGV";
            this.billDetailDGV.ReadOnly = true;
            this.billDetailDGV.Size = new System.Drawing.Size(674, 582);
            this.billDetailDGV.TabIndex = 45;
            // 
            // BillId1
            // 
            this.BillId1.DataPropertyName = "BillId";
            this.BillId1.HeaderText = "Mã HĐ";
            this.BillId1.Name = "BillId1";
            this.BillId1.ReadOnly = true;
            // 
            // BillDetailId
            // 
            this.BillDetailId.DataPropertyName = "BillDetailId";
            this.BillDetailId.HeaderText = "Mã CTHĐ";
            this.BillDetailId.Name = "BillDetailId";
            this.BillDetailId.ReadOnly = true;
            // 
            // DrinkId2
            // 
            this.DrinkId2.DataPropertyName = "DrinkId";
            this.DrinkId2.HeaderText = "Mã nước";
            this.DrinkId2.Name = "DrinkId2";
            this.DrinkId2.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Kích thước";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Ice
            // 
            this.Ice.DataPropertyName = "Ice";
            this.Ice.HeaderText = "Đá";
            this.Ice.Name = "Ice";
            this.Ice.ReadOnly = true;
            // 
            // Sugar
            // 
            this.Sugar.DataPropertyName = "Sugar";
            this.Sugar.HeaderText = "Đường";
            this.Sugar.Name = "Sugar";
            this.Sugar.ReadOnly = true;
            // 
            // BillDetailPrice
            // 
            this.BillDetailPrice.DataPropertyName = "BillDetailPrice";
            this.BillDetailPrice.HeaderText = "Thành tiền";
            this.BillDetailPrice.Name = "BillDetailPrice";
            this.BillDetailPrice.ReadOnly = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(396, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(106, 23);
            this.searchLabel.TabIndex = 46;
            this.searchLabel.Text = "TÌM KIẾM";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(508, 6);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(212, 32);
            this.searchTB.TabIndex = 47;
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyDown);
            // 
            // deleteBillBtn
            // 
            this.deleteBillBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBillBtn.Location = new System.Drawing.Point(726, 6);
            this.deleteBillBtn.Name = "deleteBillBtn";
            this.deleteBillBtn.Size = new System.Drawing.Size(133, 32);
            this.deleteBillBtn.TabIndex = 48;
            this.deleteBillBtn.Text = "Xóa";
            this.deleteBillBtn.UseVisualStyleBackColor = true;
            this.deleteBillBtn.Click += new System.EventHandler(this.deleteBillBtn_Click);
            // 
            // billIdTB
            // 
            this.billIdTB.Location = new System.Drawing.Point(871, 11);
            this.billIdTB.Name = "billIdTB";
            this.billIdTB.Size = new System.Drawing.Size(131, 20);
            this.billIdTB.TabIndex = 49;
            this.billIdTB.Visible = false;
            // 
            // BillTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 633);
            this.Controls.Add(this.billIdTB);
            this.Controls.Add(this.deleteBillBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.billDetailDGV);
            this.Controls.Add(this.billDGV);
            this.Name = "BillTable";
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.DataGridView billDetailDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDetailPrice;
        private System.Windows.Forms.Button deleteBillBtn;
        private System.Windows.Forms.TextBox billIdTB;
    }
}