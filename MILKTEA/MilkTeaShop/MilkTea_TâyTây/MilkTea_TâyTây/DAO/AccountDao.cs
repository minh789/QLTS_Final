using MilkTea_TâyTây.DTO;
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
    public class AccountDao
    {
        private static AccountDao instance;
        private string connectionSTR = @"Data Source=DESKTOP-OQJ7HTJ\SQLEXPRESS;Initial Catalog=MilkTeaShop;Integrated Security=True";
        private DataTable dt = new DataTable();
        private DataTable dt2 = new DataTable();
        private DataTable dt3 = new DataTable();
        private DataTable dt4 = new DataTable();
        public static AccountDao Instance
        {
            get { if (instance == null) instance = new AccountDao(); return instance; }
            private set { instance = value; }
        }

        private AccountDao() { }

        public bool Login (string userName,string passWord,string position)
        {

            string query = "USP_Login @userName , @passWord , @position";

            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {userName,passWord,position}); 
            return result.Rows.Count > 0;
        }

        public String SupportLogin(string userName, string pass)
        {
            dt.Clear();
            string query = "USP_GetPos N'" + userName + "' , N'" + pass + "' ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return dt.Rows[0][0].ToString();
            }
        }

        public String CheckLogin(string userName, string pass)
        {
            dt2.Clear();
            string query = "CheckAccount N'" + userName + "' , N'" + pass + "' ";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt2);
                connection.Close();
                return dt2.Rows[0][0].ToString();
                
            }
        }

        public AccountMT GetAcountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select* from Account where UserName= N'" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new AccountMT(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string Password, string newPassword)
        {
            int result = DataProvider.Instance.NonExcuteQuery("USP_UpadateAccount @userName ,  @displayName  ,  @passWord ,  @newPassWord ", new object[] { userName, displayName, Password, newPassword });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT UserName,DisplayName,Position FROM dbo.Account");
        }


        public bool InsertAccount(string name, string displayName, string position)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Position )VALUES  ( N'{0}', N'{1}', N'{2}')", name, displayName, position);
            int result = DataProvider.Instance.NonExcuteQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, string position)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Position = N'{2}' WHERE UserName = N'{0}'", name, displayName, position);
            int result = DataProvider.Instance.NonExcuteQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.NonExcuteQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("update Account set password = N'"+Encrypt("0")+"' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.NonExcuteQuery(query);

            return result > 0;
        }

        public String Encrypt(String pass)
        {
            dt3.Clear();
            string query = "Encrypt '" + pass + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt3);
                return dt3.Rows[0][0].ToString();
            }
        }

        public DataTable SearchAccDetailByText(String x)
        {
            dt4.Clear();
            string query = "SearchAccDetailByText N'" + x + "'";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt4);
                return dt4;
            }
        }
    }
}
