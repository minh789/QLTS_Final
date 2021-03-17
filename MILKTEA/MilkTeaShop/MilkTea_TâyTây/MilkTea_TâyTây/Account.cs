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
    public partial class Account : Form
    {
        private AccountMT loginAccount;
        public AccountMT LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; AccountInfo(); }
        }

        public Account(AccountMT acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void AccountInfo()
        {
            txbUsername.Text = loginAccount.UserName;
            txbDisplayname.Text = loginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string userName = txbUsername.Text;
            string passWord = Encrypt(txbPassword.Text);
            string displayName = txbDisplayname.Text;
            string newPassword = Encrypt(txbNewPassword.Text);
            string reEnterPass = Encrypt(txtReEnterPass.Text);
            if (!(newPassword).Equals(reEnterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới ");
            }
            else
            {
                if (AccountDao.Instance.UpdateAccount(userName, displayName, passWord, newPassword))
                {
                    MessageBox.Show("Thay đổi thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDao.Instance.GetAcountByUserName(userName)));
                }
                else
                {
                    void AccountInfo()
                    {
                        txbUsername.Text = loginAccount.UserName;
                        txbDisplayname.Text = loginAccount.DisplayName;
                    }

                    MessageBox.Show("Thay đổi thất bại.Xin bạn xem lại thông tin đăng nhập!!!");
                }

            }
        }

        private event EventHandler<AccountEvent> updateAccount;

        public event EventHandler<AccountEvent> Updateaccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        public class AccountEvent : EventArgs
        {
            private AccountMT accountMT;


            public AccountEvent(AccountMT accountMT)
            {
                this.accountMT = accountMT;
            }

            public AccountMT Acc { get => accountMT; set => accountMT = value; }
        }

        public String Encrypt(String pass)
        {
            return AccountDao.Instance.Encrypt(pass);
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
