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
    public partial class BillTable : Form
    {
        private AccountMT loginAccount;
        public BillTable(AccountMT ac)
        {
            InitializeComponent();
            deleteBillBtn.Visible = false;
            this.loginAccount = ac;
            ChangeAccount(loginAccount.Position);
            tableUpdate();
            UpdateFont(billDGV);
            UpdateFont(billDetailDGV);
            
        }
        public BillTable()
        {
            InitializeComponent();
            deleteBillBtn.Visible = false;
            tableUpdate();
            UpdateFont(billDGV);
            UpdateFont(billDetailDGV);

        }
        public AccountMT LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Position); }
        }

        void ChangeAccount(string position)
        {
            //MessageBox.Show(position+" Quản lý");
            if (position.Equals("Quản lý"))
            {
                deleteBillBtn.Visible = true;
            }
            if (position.Contains("Nhân viên"))
            {
                deleteBillBtn.Visible = false;
            }
        }


        public void tableUpdate()
        {
            MilkTeaContextDB db = new MilkTeaContextDB();
            billDGV.AutoGenerateColumns = false;
            billDetailDGV.AutoGenerateColumns = false;
            List<Bill> billList = db.Bills.OrderByDescending(x => x.BillDate).ToList<Bill>();
            using (db)
            {
                billDGV.DataSource = billList;
            }
            
        }

        private void UpdateFont(DataGridView dgv)
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Roman", 18F, GraphicsUnit.Pixel);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void billDGV_DoubleClick(object sender, EventArgs e)
        {
            Bill item = new Bill();
            if (billDGV.CurrentRow.Index != -1)
            {
                item.BillId = billDGV.CurrentRow.Cells["BillId"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.Bills.Where(x => x.BillId == item.BillId).FirstOrDefault();
                    billDetailDGV.DataSource = SelectBillDetail(item.BillId);
                    billIdTB.Text = item.BillId;
                }
            }
        }

        DataTable SelectBillDetail(String BillId)
        {
            return MenuDAO.Instance.SelectBillDetail(BillId);
        }

        public DataTable SearchBillByText(String x)
        {
            return MenuDAO.Instance.SearchBillByText(x);
        }

        public DataTable SearchBillDetailByText(String x)
        {
            return MenuDAO.Instance.SearchBillDetailByText(x);
        }

        public void IfBillDetailIsEmpty(String x, int y)
        {
            MenuDAO.Instance.IfBillDetailIsEmpty(x, y);
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            billDGV.DataSource = SearchBillByText(searchTB.Text);
            billDetailDGV.DataSource = SearchBillDetailByText(searchTB.Text);
        }

        private void deleteBillBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(billIdTB.Text, BillDetailCount(billIdTB.Text).ToString());
            IfBillDetailIsEmpty(billIdTB.Text, BillDetailCount(billIdTB.Text));
            tableUpdate();
        }

        public int BillDetailCount(String x)
        {
            return MenuDAO.Instance.BillDetailCount(x);
        }
    }
}
