using MilkTea_TâyTây.DAO;
using MilkTea_TâyTây.DTO;
using MilkTea_TâyTây.EntityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây
{
    public partial class MenuManagement : Form
    {
        private AccountMT loginAccount;


        public AccountMT LoginAccount
        {

            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Position); }
        }

        void ChangeAccount(string position) 
        {
            //MessageBox.Show(position+" Quản lý Menu");
            if(position.Contains("Quản lý"))
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }
        public MenuManagement(AccountMT ac)
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            this.loginAccount = ac;
            ChangeAccount(loginAccount.Position);
            tableUpdate();
            UpdateFont(drinkDGV);
            UpdateFont(categoryDGV);
            UpdateFont(toppingDGV);
            
        }

        private String state = "original";
        private DataTable categoryIdDT = new DataTable();
        public void tableUpdate()
        {
            
            

            MilkTeaContextDB db = new MilkTeaContextDB();
            List<Drink> drinkList = db.Drinks.ToList<Drink>();
            List<Category> categoryList= db.Categories.ToList<Category>();
            List<ToppingTable> toppingTableList = db.ToppingTables.ToList<ToppingTable>();
            drinkDGV.AutoGenerateColumns = false;
                drinkDGV.DataSource = drinkList;  
            categoryDGV.AutoGenerateColumns = false;
                categoryDGV.DataSource = categoryList; 
                toppingDGV.DataSource = toppingTableList;
            /*using (db)
            {
                drinkDGV.DataSource = db.Drinks.ToList<Drink>();
                categoryDGV.DataSource = db.Categories.ToList<Category>();
            }*/

            inputCategoryBtn.Enabled = true;
            inputMenuBtn.Enabled = true;
            updateCategoryBtn.Enabled = false;
            updateMenuBtn.Enabled = false;
            deleteCategoryBtn.Enabled = false;
            deleteMenuBtn.Enabled = false;
            categoryIdTB.Enabled = true;
            drinkIDTB.Enabled = true;
            state = "original";
            fillCategoryIdComboBox();
            categoryIdTB.Text = "";
            categoryNameTB.Text = "";
            drinkIDTB.Text = "";
            drinkNameTB.Text = "";
            priceTB.Text = "";
            addToppingBtn.Enabled = true;
            deleteToppingBtn.Enabled = false;
            updateToppingBtn.Enabled = false;
            toppingIdTB.Enabled = true;
            toppingNameTB.Text = "";
            toppingIdTB.Text = "";
            toppingPriceTB.Text = "";
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

        private void drinkNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Category temp = new Category();
                temp.CategoryId = categoryIdTB.Text.Trim();
                temp.CategoryName = categoryNameTB.Text.Trim();

                if (categoryIdTB.Text.Equals("") || categoryNameTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                else
                {
                    updateCategory(temp);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        public void updateCategory(Category temp)
        {
            MilkTeaContextDB db = new MilkTeaContextDB();
            //int ifExistID = SelectCategoryNumber(categoryIDTB.Text);
            //MessageBox.Show(ifExistID.ToString(), "THÔNG BÁO");
            try
            {
                Category item = db.Categories.Where(x => x.CategoryId == temp.CategoryId).FirstOrDefault();
                //MessageBox.Show(item.ToString(),"EH");
                item.CategoryId = temp.CategoryId;
                item.CategoryName = temp.CategoryName;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        private void inputCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Category temp = new Category
                {
                    CategoryId = categoryIdTB.Text.Trim(),
                    CategoryName = categoryNameTB.Text.Trim()
                };
                if (categoryIdTB.Text.Equals("") || categoryNameTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                MilkTeaContextDB db = new MilkTeaContextDB();
                Category item = new Category
                {
                    CategoryId = temp.CategoryId,
                    CategoryName = temp.CategoryName
                };
                db.Categories.Add(item);
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }


        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Category temp = new Category
                {
                    CategoryId = categoryIdTB.Text.Trim(),
                    CategoryName = categoryNameTB.Text.Trim()
                };

                MilkTeaContextDB db = new MilkTeaContextDB();
                Category item = db.Categories.Where(x => x.CategoryId == temp.CategoryId).FirstOrDefault();
                if (item != null)
                {
                    db.Categories.Remove(item);
                    db.SaveChanges();
                    tableUpdate();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
            
        }

        int SelectCategoryNumber(String CategoryId)
        {
            return MenuDAO.Instance.SelectCategoryNumber(CategoryId);
        }

        private void inputMenuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (drinkIDTB.Text.Equals("") || drinkNameTB.Text.Equals("") || categoryIDCB.Text.Equals("") || priceTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                Drink temp = new Drink
                {
                    DrinkId = drinkIDTB.Text.Trim(),
                    DrinkName = drinkNameTB.Text.Trim(),
                    CategoryId = categoryIDCB.Text.Trim(),
                    Price = Convert.ToInt32(priceTB.Text.Trim())
                };
                MilkTeaContextDB db = new MilkTeaContextDB();
                Drink item = new Drink
                {
                    DrinkId = temp.DrinkId,
                    DrinkName = temp.DrinkName,
                    CategoryId = temp.CategoryId,
                    Price = temp.Price
                };
                db.Drinks.Add(item);
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
            
        }

        private void updateMenuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (drinkIDTB.Text.Equals("") || drinkNameTB.Text.Equals("") || categoryIDCB.Text.Equals("") || priceTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                Drink temp = new Drink
                {
                    DrinkId = drinkIDTB.Text.Trim(),
                    DrinkName = drinkNameTB.Text.Trim(),
                    CategoryId = categoryIDCB.Text.Trim(),
                    Price = Convert.ToInt32(priceTB.Text.Trim())
                };
                
                MilkTeaContextDB db = new MilkTeaContextDB();
                //int ifExistID = SelectCategoryNumber(categoryIDTB.Text);
                //MessageBox.Show(ifExistID.ToString(), "THÔNG BÁO");
                Drink item = db.Drinks.Where(x => x.DrinkId == temp.DrinkId).FirstOrDefault();
                //MessageBox.Show(item.ToString(),"EH");
                item.DrinkId = temp.DrinkId;
                item.DrinkName = temp.DrinkName;
                item.CategoryId = temp.CategoryId;
                item.Price = temp.Price;
                db.Drinks.Add(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
            
        }

        private void deleteMenuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Drink temp = new Drink();
                temp.DrinkId = drinkIDTB.Text.Trim();
                temp.DrinkName = drinkNameTB.Text.Trim();
                temp.CategoryId = categoryIDCB.Text.Trim();
                temp.Price = Convert.ToInt32(priceTB.Text.Trim());

                MilkTeaContextDB db = new MilkTeaContextDB();
                Drink item = db.Drinks.Where(x => x.DrinkId == temp.DrinkId).FirstOrDefault();
                if (item != null)
                {
                    db.Drinks.Remove(item);
                    db.SaveChanges();
                    tableUpdate();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
            
        }

        private void categoryDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void drinkDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && state.Equals("original") && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (Form.ModifierKeys == Keys.None && state.Equals("changed") && keyData == Keys.Escape)
            {
                tableUpdate();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void fillCategoryIdComboBox()
        {
            categoryIdDT.Clear();
            categoryIDCB.Items.Clear();
            categoryIdDT = SelectAllCategoryId();
            foreach (DataRow dr in categoryIdDT.Rows)
            {
                foreach (DataColumn dc in categoryIdDT.Columns)
                {
                    categoryIDCB.Items.Add(dr[dc].ToString());
                }
            }
        }

        public DataTable SelectAllCategoryId()
        {
            return MenuDAO.Instance.SelectAllCategoryId();
        }

        public DataTable SearchCategoryByText(String x)
        {
            return MenuDAO.Instance.SearchCategoryByText(x);
        }

        public DataTable SearchDrinkByText(String x)
        {
            return MenuDAO.Instance.SearchDrinkByText(x);
        }

        public DataTable SearchToppingByText(String x)
        {
            return MenuDAO.Instance.SearchToppingByText(x);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = new Account(LoginAccount);
            ac.Updateaccount += updaAccount;
            ac.ShowDialog();
        }

        private void updaAccount(object sender, Account.AccountEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void addToppingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (toppingIdTB.Text.Equals("") || toppingNameTB.Text.Equals("") || toppingPriceTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                ToppingTable temp = new ToppingTable
                {
                    ToppingId = toppingIdTB.Text.Trim(),
                    ToppingName = toppingNameTB.Text.Trim(),
                    ToppingPrice = Convert.ToInt32(toppingPriceTB.Text.Trim())
                };
                MilkTeaContextDB db = new MilkTeaContextDB();
                ToppingTable item = new ToppingTable
                {
                    ToppingId = temp.ToppingId,
                    ToppingName = temp.ToppingName,
                    ToppingPrice = temp.ToppingPrice
                };
                db.ToppingTables.Add(item);
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        private void updateToppingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (toppingIdTB.Text.Equals("") || toppingNameTB.Text.Equals("") || toppingPriceTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                ToppingTable temp = new ToppingTable
                {
                    ToppingId = toppingIdTB.Text.Trim(),
                    ToppingName = toppingNameTB.Text.Trim(),
                    ToppingPrice = Convert.ToInt32(toppingPriceTB.Text.Trim())
                };
                MilkTeaContextDB db = new MilkTeaContextDB();
                ToppingTable item = db.ToppingTables.Where(x => x.ToppingId == temp.ToppingId).FirstOrDefault();
                //MessageBox.Show(item.ToString(),"EH");
                item.ToppingId = temp.ToppingId;
                item.ToppingName = temp.ToppingName;
                item.ToppingPrice = temp.ToppingPrice;
                db.ToppingTables.Add(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                tableUpdate();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        private void deleteToppingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (toppingIdTB.Text.Equals("") || toppingNameTB.Text.Equals("") || toppingPriceTB.Text.Equals(""))
                {
                    throw new Exception("Còn trường trống chưa nhập!");
                }
                ToppingTable temp = new ToppingTable
                {
                    ToppingId = toppingIdTB.Text.Trim(),
                    ToppingName = toppingNameTB.Text.Trim(),
                    ToppingPrice = Convert.ToInt32(toppingPriceTB.Text.Trim())
                };
                MilkTeaContextDB db = new MilkTeaContextDB();
                ToppingTable item = db.ToppingTables.Where(x => x.ToppingId == temp.ToppingId).FirstOrDefault();
                if (item != null)
                {
                    db.ToppingTables.Remove(item);
                    db.SaveChanges();
                    tableUpdate();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
        }

        private void toppingDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            categoryDGV.DataSource = SearchCategoryByText(searchTB.Text);
            drinkDGV.DataSource = SearchDrinkByText(searchTB.Text);
            toppingDGV.DataSource = SearchToppingByText(searchTB.Text);
        }

        private void categoryDGV_Click(object sender, EventArgs e)
        {
            Category item = new Category();
            if (categoryDGV.CurrentRow.Index != -1)
            {
                item.CategoryId = categoryDGV.CurrentRow.Cells["CategoryID"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.Categories.Where(x => x.CategoryId == item.CategoryId).FirstOrDefault();
                    categoryIdTB.Text = item.CategoryId;
                    categoryNameTB.Text = item.CategoryName;
                    inputCategoryBtn.Enabled = false;
                    deleteCategoryBtn.Enabled = true;
                    updateCategoryBtn.Enabled = true;
                    categoryIdTB.Enabled = false;
                    state = "changed";
                }
            }
        }

        private void drinkDGV_Click(object sender, EventArgs e)
        {
            Drink item = new Drink();
            if (drinkDGV.CurrentRow.Index != -1)
            {
                item.DrinkId = drinkDGV.CurrentRow.Cells["DrinkID"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.Drinks.Where(x => x.DrinkId == item.DrinkId).FirstOrDefault();
                    drinkIDTB.Text = item.DrinkId;
                    drinkNameTB.Text = item.DrinkName;
                    categoryIDCB.Text = item.CategoryId;
                    priceTB.Text = item.Price.ToString();
                    inputMenuBtn.Enabled = false;
                    deleteMenuBtn.Enabled = true;
                    updateMenuBtn.Enabled = true;
                    drinkIDTB.Enabled = false;
                    state = "changed";
                }
            }
        }

        private void toppingDGV_Click(object sender, EventArgs e)
        {
            ToppingTable item = new ToppingTable();
            if (toppingDGV.CurrentRow.Index != -1)
            {
                item.ToppingId = toppingDGV.CurrentRow.Cells["ToppingId"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.ToppingTables.Where(x => x.ToppingId == item.ToppingId).FirstOrDefault();
                    toppingIdTB.Text = item.ToppingId;
                    toppingNameTB.Text = item.ToppingName;
                    toppingPriceTB.Text = item.ToppingPrice.ToString();
                    addToppingBtn.Enabled = false;
                    deleteToppingBtn.Enabled = true;
                    updateToppingBtn.Enabled = true;
                    toppingIdTB.Enabled = false;
                    state = "changed";
                }
            }
        }
    }
}
