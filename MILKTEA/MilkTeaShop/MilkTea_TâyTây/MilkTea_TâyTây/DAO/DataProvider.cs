using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_TâyTây.DAO
{
    public class DataProvider
    {
        //create DataProvider and create constructor as design patern singleton 
        private static DataProvider instance;//Ctrl+r+e
        private string connectionSTR = @"Data Source=DESKTOP-OQJ7HTJ\SQLEXPRESS;Initial Catalog=MilkTeaShop;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            // using là hàm dùng xong 1 lần là bỏ 
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                //thuc hien truy van 
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                //thang trung gian de thuc hien truy van 
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public int NonExcuteQuery(string query, object[] paramater = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                //thuc hien truy van 
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                //thang trung gian de thuc hien truy van 
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query, object[] paramater = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                //thuc hien truy van 
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                //thang trung gian de thuc hien truy van 
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
