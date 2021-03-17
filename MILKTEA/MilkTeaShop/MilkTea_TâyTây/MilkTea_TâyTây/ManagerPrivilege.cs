using MilkTea_TâyTây.DAO;
using MilkTea_TâyTây.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây
{
    public partial class Manager : Form
    {
        private AccountMT loginAccount;
        public AccountMT LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public Manager(AccountMT ac)
        {
            InitializeComponent();
            this.loginAccount = ac;
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            OrderCard tb = new OrderCard(loginAccount);
            this.Hide();
            tb.ShowDialog();
            this.Show();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuManagement mnm = new MenuManagement(loginAccount);
            this.Hide();
            mnm.ShowDialog();
            this.Show();
        }
    }
}
