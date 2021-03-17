using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_TâyTây.DTO
{
    public class AccountMT
    {
        private string userName;
        private string displayName;
        private string passWord;
        private string position;

        public AccountMT(string userName, string displayName, string passWord, string position)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.PassWord = passWord;
            this.Position = position;
        }

        public AccountMT(DataRow row)
        {
            this.UserName = row["UserName"].ToString(); ;
            this.DisplayName = row["DisplayName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.Position = row["Position"].ToString();
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Position { get => position; set => position = value; }
    }
}
