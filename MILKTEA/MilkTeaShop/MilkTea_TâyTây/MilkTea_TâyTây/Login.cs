using MilkTea_TâyTây.DAO;
using MilkTea_TâyTây.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private string userName="";
        private string passWord="";
        private string position="";


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            userName = usernameTB.Text;
            passWord = Encrypt(passwordTB.Text);
            //MessageBox.Show(SupportLogin(userName, passWord)+" "+CheckLogin(userName, passWord), "thong bao");
            //MessageBox.Show(passWord, "thong bao");
            try
            {
                if (usernameTB.Text.Equals(""))
                {
                    throw new Exception("Tài khoản rỗng!!!");
                }
                if (passwordTB.Text.Equals(""))
                {
                    throw new Exception("Chưa nhập mật khẩu!!!");
                }
                if(CheckLogin(userName, passWord).ToString().Equals("true"))
                {
                    position = SupportLogin(userName, passWord);
                    //MessageBox.Show(position.ToString(), "thong bao");

                    if (Login(userName, passWord, position) && position.Equals("Quản trị"))
                    {
                        AccountMT loginAccount = AccountDao.Instance.GetAcountByUserName(userName);
                        Admin mt = new Admin(loginAccount);
                        this.Hide();
                        mt.ShowDialog();
                        this.Show();
                    }
                    if (Login(userName, passWord, position) && position.Equals("Nhân viên"))
                    {
                        AccountMT loginAccount = AccountDao.Instance.GetAcountByUserName(userName);
                        OrderCard mt = new OrderCard(loginAccount);
                        this.Hide();
                        mt.ShowDialog();
                        this.Show();
                    }
                    if (Login(userName, passWord, position) && position.Equals("Quản lý Menu"))
                    {
                        AccountMT loginAccount = AccountDao.Instance.GetAcountByUserName(userName);
                        MenuManagement mm = new MenuManagement(loginAccount);
                        this.Hide();
                        mm.ShowDialog();
                        this.Show();
                    }
                    if (Login(userName, passWord, position) && position.Equals("Quản lý"))
                    {
                        AccountMT loginAccount = AccountDao.Instance.GetAcountByUserName(userName);
                        Manager mg = new Manager(loginAccount);
                        this.Hide();
                        mg.ShowDialog();
                        this.Show();
                    }
                }
                if (CheckLogin(userName, passWord).ToString().Equals("false"))
                {
                    throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception e1)
            {
               //throw e1;
               MessageBox.Show(e1.Message, "LỖI ĐĂNG NHẬP!");
            }

        }

        bool Login(string userName,string passWord,string position)
        {
            return AccountDao.Instance.Login(userName,passWord,position);
        }

        string SupportLogin(string userName, string pass)
        {
            return AccountDao.Instance.SupportLogin(userName, pass);
        }

        String CheckLogin(string userName, string pass)
        {
            return AccountDao.Instance.CheckLogin(userName, pass);
        }

        public String Encrypt(String pass)
        {
            return AccountDao.Instance.Encrypt(pass);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) != DialogResult.Yes  )
            {
                e.Cancel = true;
            }
        }



        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }



    }
}
