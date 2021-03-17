using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MilkTea_TâyTây.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        private string connectionSTR = @"Data Source=DESKTOP-OQJ7HTJ\SQLEXPRESS;Initial Catalog=MilkTeaShop;Integrated Security=True";
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable BillDetailDT = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt8 = new DataTable();
        DataTable dt9 = new DataTable();
        DataTable dt10 = new DataTable();
        DataTable dt11 = new DataTable();
        DataTable dt12 = new DataTable();
        DataTable dt13 = new DataTable();
        DataTable dt14 = new DataTable();
        DataTable dt15 = new DataTable();
        DataTable dt16 = new DataTable();
        DataTable dt17 = new DataTable();
        DataTable dt18 = new DataTable();
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public int SelectCategoryNumber(String CategoryId)
        {
            dt.Clear();
            string query = "SelectCategoryNumber N'"+CategoryId+"'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }

        public DataTable SelectAllCategoryId()
        {
            dt.Clear();
            string query = "SelectAllCategoryId ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }

        public String SelectCategoryName(String CategoryId)
        {
            dt2.Clear();
            string query = "SelectCategoryName '" + CategoryId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt2);
                //MessageBox.Show(dt2.Rows[0][0].ToString(), "");
                return dt2.Rows[0][0].ToString();
            }
        }

        public String GetBillId(String CardId)
        {
            dt.Clear();
            string query = "GetBillId '" + CardId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
        }

        public String GetBillDetailId(String BillId)
        {
            dt4.Clear();
            string query = "GetBillDetailId '" + BillId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt4);
                return dt4.Rows[0][0].ToString();
            }
        }

        public DateTime GetCurrentDate()
        {
            dt.Clear();
            string query = "GetCurrentDate ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return Convert.ToDateTime(dt.Rows[0][0]);
            }
        }

        public String GetLatestBillId()
        {
            dt3.Clear();
            string query = "GetLatestBillId ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt3);
                return dt3.Rows[0][0].ToString();
            }
        }

        public DataTable GetBillDetailByLatestBillId()
        {
            BillDetailDT.Clear();
            string query = "GetBillDetailByLatestBillId ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(BillDetailDT);
                return BillDetailDT;
            }
        }

        public void InsertBillDetailTopping(String billDetailId, String toppingId)
        {
            string query = "Insert into BillDetailTopping VALUES ('" + billDetailId + "', '" + toppingId + "')";
            //MessageBox.Show(query);
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(BillDetailDT);
            }
        }

        public int GetToppingPrice(String toppingId)
        {
            dt5.Clear();
            string query = "GetToppingPrice '"+toppingId+"'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt5);
                return Convert.ToInt32(dt5.Rows[0][0]);
            }
        }
        public int GetBillDetailQuantity(String billDetailId)
        {
            dt6.Clear();
            string query = "GetBillDetailQuantity '" + billDetailId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt6);
                return Convert.ToInt32(dt6.Rows[0][0]);
            }
        }

        public void UpdateCardStatusToEmpty(String CardId)
        {
            string query = "sp_UpdateCardStatusToEmpty @CardId";
            //using (SqlConnection connection = new SqlConnection(connectionSTR))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(query, connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //}
            DataProvider.Instance.NonExcuteQuery(query,new object[] { CardId});
        }

        public int GetCardStatus(int CardId)
        {
            dt7.Clear();
            string query = "sp_GetCardStatus '" + CardId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt7);
                return Convert.ToInt32(dt7.Rows[0][0]);
            }
        }

        public DataTable SelectToppingDetail(String BillDetailId)
        {
            dt8.Clear();
            string query = "SelectToppingDetail '" + BillDetailId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt8);
                return dt8;
            }
        }

        public DataTable SelectBillDetail(String BillId)
        {
            dt10.Clear();
            string query = "SelectBillDetail '" + BillId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt10);
                return dt10;
            }
        }

        public int CountTopping(String BillDetailId)
        {
            dt9.Clear();
            string query = "SelectToppingDetail '" + BillDetailId + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt9);
                return Convert.ToInt32(dt9.Rows[0][0]);
            }
        }

        public DataTable SearchCategoryByText(String x)
        {
            dt11.Clear();
            string query = "SearchCategoryByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt11);
                return dt11;
            }
        }

        public DataTable SearchDrinkByText(String x)
        {
            dt12.Clear();
            string query = "SearchDrinkByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt12);
                return dt12;
            }
        }

        public DataTable SearchToppingByText(String x)
        {
            dt13.Clear();
            string query = "SearchToppingByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt13);
                return dt13;
            }
        }

        public DataTable SearchBillByText(String x)
        {
            dt14.Clear();
            string query = "SearchBillByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt14);
                return dt14;
            }
        }

        public DataTable SearchBillDetailByText(String x)
        {
            dt15.Clear();
            string query = "SearchBillDetailByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt15);
                return dt15;
            }
        }
        public DataTable RevenueByDate(String x, String y)
        {
            dt16.Clear();
            string query = "RevenueByDate '" + x + "', '"+ y +"'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt16);
                return dt16;
            }
        }

        public int BillDetailCount(String x)
        {
            dt17.Clear();
            string query = "BillDetailCount '" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt17);
                return Convert.ToInt32(dt17.Rows[0][0]);
            }
        }

        public void IfBillDetailIsEmpty(String x, int y)
        {
            string query = "IfBillDetailIsEmpty '" + x + "', "+y;
            DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable BestSellers(String x, String y)
        {
            dt18.Clear();
            string query = "BestSellers '" + x + "', '" + y + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt18);
                return dt18;
            }
        }


    }
}
