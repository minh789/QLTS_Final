using MilkTea_TâyTây.DAO;
using MilkTea_TâyTây.DTO;
using MilkTea_TâyTây.EntityClass;
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
    public partial class OrderCard : Form
    {
        private AccountMT loginAccount;


        public AccountMT LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Position); }
        }

        private List<Panel> listPanel = new List<Panel>();
        public OrderCard(AccountMT acc)
        {
            InitializeComponent();
            cardManagementCB.Text = "Nhập thẻ";
            LoadCard();
            this.LoginAccount = acc;
            listPanel.Add(orderCardPanel1);
            listPanel.Add(orderCardPanel2);
        }

        void ChangeAccount(string position)
        {
            quảnLýToolStripMenuItem.Enabled = position.Equals("Quản lý");
            thôngTinTàiKhoảnToolStripMenuItem.Text += "( " + loginAccount.DisplayName + ")";
        }

        void LoadCard()
        {
            List<Card> cardList = CardDao.Instance.LoadCardList();
            foreach (Card item in cardList)
            {
                String occupied="";
                Button btn = new Button() { Width=CardDao.TableWidth,Height=CardDao.TableHeight};

                if(item.Status==0)
                {
                    occupied = "Trống";
                }
                if (item.Status == 1)
                {
                    occupied = "Đã đặt nước";
                }

                btn.Text = Environment.NewLine + item.Name + " " + occupied;
                btn.ForeColor = Color.Black;
                btn.Font= new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //btn.BackgroundImage = global::MilkTea_TâyTây.Properties.Resources.fashion;
                //btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += new EventHandler(btn_Click);
                btn.Tag = item;
                switch (item.Status)
                {
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ResetCard()
        {
            flpTable.Controls.Clear();
        }

        void RefreshCard(int n)
        {
            flpTable.Controls.Clear();
            List<Card> cardList = CardDao.Instance.LoadCardList();
            if (cardManagementCB.SelectedItem.ToString().Equals("Nhập thẻ"))
            {
                ResetCard();
                cardList = CardDao.Instance.cardUpdate(n);
            }
            if (cardManagementCB.SelectedItem.ToString().Equals("Xóa thẻ"))
            {
                ResetCard();
                cardList = CardDao.Instance.cardRemove(n); 
            }
            foreach (Card item in cardList)
            {
                String occupied = "";
                Button btn = new Button() { Width = CardDao.TableWidth, Height = CardDao.TableHeight };
                
               
                    if (item.Status == 0)
                {
                    occupied = "Trống";
                }
                if (item.Status == 1)
                {
                    occupied = "Đã đặt nước";
                }

                btn.Text = Environment.NewLine + item.Name + " " + occupied;
                btn.ForeColor = Color.Black;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //btn.BackgroundImage = global::MilkTea_TâyTây.Properties.Resources.fashion;
                //btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += new EventHandler(btn_Click);
                btn.Tag = item;
                switch (item.Status)
                {
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender,EventArgs e)
        {
            try
            {
                String a = "";
                int val;
                string s = (sender as Button).Text;
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsDigit(s[i]))
                        a += s[i];
                }

                if (a.Length > 0)
                {
                    val = int.Parse(a);
                }
                //MessageBox.Show(a, "");

                if (GetCardStatus(Convert.ToInt32(a)) == 0)
                {
                    InsertBill(a);
                    Menu mn = new Menu();
                    this.Hide();
                    mn.ShowDialog();
                    this.Show();
                }
                if (GetCardStatus(Convert.ToInt32(a)) == 1)
                {
                    if (MessageBox.Show("Khách đã trả thẻ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        UpdateCardStatusToEmpty(a);
                        //MessageBox.Show(GetCardStatus(Convert.ToInt32(a)).ToString(), "");


                    }
                }
                ResetCard();
                LoadCard();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        public int GetCardStatus(int CardId)
        {
            return MenuDAO.Instance.GetCardStatus(CardId);
        }

        public String GetBill(String CardId)
        {
            return MenuDAO.Instance.GetBillId(CardId);
        }

        public void InsertBill(String cardId)
        {
            try
            {
                MilkTeaContextDB db = new MilkTeaContextDB();
                Bill item = new Bill
                {
                    BillId = GetBill(cardId),
                    CardId = Convert.ToInt32(cardId),
                    BillDate = GetCurrentDate(),
                    TotalPrice = 0
                };
                db.Bills.Add(item);
                //MessageBox.Show(GetBill(cardId)+" "+ cardId+" "+ GetCurrentDate(), "FUCKYOUPOS");
                db.SaveChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        public DateTime GetCurrentDate()
        {
            return MenuDAO.Instance.GetCurrentDate();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = new Account(LoginAccount);
            ac.Updateaccount += updaAccount;
            ac.ShowDialog();
        }

        private void updaAccount(object sender, Account.AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMT am = new ManageMT();
            am.Show();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }


        private void orderCardListBtn_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void orderCardManagerBtn_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        public List<Card> cardUpdate(int n)
        {
            return CardDao.Instance.cardUpdate(n);
        }

        public List<Card> cardRemove(int n)
        {
            return CardDao.Instance.cardRemove(n);
        }

        private void orderCardSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(cardManagementCB.Text,"");
                if(orderCardNumberTB.Text.Equals(""))
                {
                    throw new Exception("Trường còn trống. Chưa điền");
                }
                if(cardManagementCB.Text.Equals("Nhập thẻ"))
                {
                    RefreshCard(Convert.ToInt32(orderCardNumberTB.Text));
                    orderCardNumberTB.Text = (Convert.ToInt32(orderCardNumberTB.Text) + 1).ToString();
                }
                if (cardManagementCB.Text.Equals("Xóa thẻ"))
                {
                    RefreshCard(Convert.ToInt32(orderCardNumberTB.Text));
                    orderCardNumberTB.Text = "0";
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }
        private void orderCardNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillTable b = new BillTable(loginAccount);
            b.Show();
        }

        public void UpdateCardStatusToEmpty(String CardId)
        {
            MenuDAO.Instance.UpdateCardStatusToEmpty(CardId);
        }

        
        private void xemMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManagement m = new MenuManagement(loginAccount);
            m.Show();
        }
    }
}
