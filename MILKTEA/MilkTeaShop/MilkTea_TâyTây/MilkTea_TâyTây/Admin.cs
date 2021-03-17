using MilkTea_TâyTây.DTO;
using MilkTea_TâyTây.DAO;
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
    public partial class Admin : Form
    {
        private AccountMT loginAccount;

        BindingSource accountList = new BindingSource();

        public AccountMT LoginAccount
        {

            get { return loginAccount; }
            set { loginAccount = value; }
        }
     
        public Admin(AccountMT ac)
        {
            this.loginAccount = ac;
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDao.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayname.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtPosition.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Position", true, DataSourceUpdateMode.Never));
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = new Account(LoginAccount);
            ac.Updateaccount += updaAccount;
            ac.ShowDialog();
        }

        void AddAccount(string userName, string displayName, string position)
        {
            if (AccountDao.Instance.InsertAccount(userName, displayName, position))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, string position)
        {
            if (AccountDao.Instance.UpdateAccount(userName, displayName, position))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDao.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDao.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void updaAccount(object sender, Account.AccountEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayname.Text;
            string position = txtPosition.Text;


            AddAccount(userName, displayName, position);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            DeleteAccount(userName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayname.Text;
            string position = txtPosition.Text;

         
            EditAccount(userName, displayName, position);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            ResetPass(userName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public DataTable SearchAccDetailByText(String x)
        {
            return AccountDao.Instance.SearchAccDetailByText(x);
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            dtgvAccount.DataSource= SearchAccDetailByText(textBox4.Text);
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
