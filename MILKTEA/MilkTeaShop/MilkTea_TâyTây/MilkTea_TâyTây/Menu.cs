using MilkTea_TâyTây.DAO;
using MilkTea_TâyTây.DTO;
using MilkTea_TâyTây.EntityClass;
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
    public partial class Menu : Form
    {
        List<Panel> listPanel = new List<Panel>();
        DataTable categoryIDDT = new DataTable();
        DataTable drinkIDDT = new DataTable();
        DataTable billDetailDT = new DataTable();
        private int addtionalPrice=0;
        private String billid="";
        private String bdid = "";

        private AccountMT loginAccount;


        public Menu()
        {
            InitializeComponent();
            orderBtn.Enabled = false;
            billDetailPanelBtn.Enabled = false;
            btnConfirm.BringToFront();
            tableUpdate();
            UpdateFont(drinkDGV);
            UpdateFont(billDetailDGV);
            UpdateFont(toppingDetailDGV);
            listPanel.Add(addToppingBtn);
            listPanel.Add(billPanel);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            rdbPercentIce1.Enabled = false;
            rdbPercentIce2.Enabled = false;
            rdbPercentIce3.Enabled = false;
            rdbPercentSugar1.Enabled = false;
            rdbPercentSugar2.Enabled = false;
            rdbPercentSugar3.Enabled = false;
            rdbPercentSugar4.Enabled = false;
            cheeseCheckBox.Enabled = false;
            cunangCheckBox.Enabled = false;
            flanCheckBox.Enabled = false;
            fruitCheckBox.Enabled = false;
            snowCheckBox.Enabled = false;
            tranchauCheckBox.Enabled = false;
            yellowCheckBox.Enabled = false;
            toppingTB.Visible = false;
            toppingLabel.Visible = false;
            toppingDGVPanel.Visible = false;
            //deleteBillDetailBtn.Visible = false;
            //deleteToppingDetailBtn.Visible = false;
            //deleteBillDetailBtn.Enabled = false;
            //deleteToppingDetailBtn.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //deleteBillDetailBtn.Visible = true;
            //deleteToppingDetailBtn.Visible = true;
            toppingDGVPanel.Visible = true;
            sugaricePanel.Visible = false;
            mainMenuBtn.Visible = false;
            toppingTB.Visible = true;
            toppingLabel.Visible = true;
            orderBtn.Enabled = true;
            sizeCB.Enabled = false;
            upBtn.Enabled = false;
            downBtn.Enabled = false;
            tableUpdate();
            String iceper = "", sugarper = "";
            String topping="";
            if(rdbPercentIce1.Checked)
            {
                iceper = rdbPercentIce1.Text;
            }
            if (rdbPercentIce2.Checked)
            {
                iceper = rdbPercentIce2.Text;
            }
            if (rdbPercentIce3.Checked)
            {
                iceper = rdbPercentIce3.Text;
            }
            if (rdbPercentSugar1.Checked)
            {
                sugarper = rdbPercentSugar1.Text;
            }
            if (rdbPercentSugar2.Checked)
            {
                sugarper = rdbPercentSugar2.Text;
            }
            if (rdbPercentSugar3.Checked)
            {
                sugarper = rdbPercentSugar3.Text;
            }
            if (rdbPercentSugar4.Checked)
            {
                sugarper = rdbPercentSugar4.Text;
            }
            /*if (tranchauCheckBox.Checked == true)
            {
                topping+="Trân châu, ";
            }
            if (snowCheckBox.Checked == true)
            {
                topping += "Trân châu tuyết, ";
            }
            if (yellowCheckBox.Checked == true)
            {
                topping += "Trân châu vàng, ";
            }
            if (flanCheckBox.Checked == true)
            {
                topping += "Bánh flan, ";
            }
            if (cunangCheckBox.Checked == true)
            {
                topping += "Củ năng, ";
            }
            if (cheeseCheckBox.Checked == true)
            {
                topping += "Phô mai, ";
            }
            if (fruitCheckBox.Checked == true)
            {
                topping += "Thạch trái cây, ";
            }
            if(topping.Equals(""))
            {
                topping = "Không Topping";
            }*/
            try
            {
                if(iceper.Equals("")||sugarper.Equals(""))
                {
                    throw new Exception("Vui lòng chọn mức đá và đường");
                }

                bdid = GetBillDetailId(GetLatestBillId());
                MilkTeaContextDB db = new MilkTeaContextDB();
                BillDetail item = new BillDetail
                {
                    BillDetailId = bdid,
                    BillId = GetLatestBillId(),
                    DrinkId = drinkIDTB.Text,
                    Number = Convert.ToInt32(numberTB.Text),
                    Size = sizeCB.Text,
                    //Topping = topping,
                    Ice = iceper,
                    SUGAR = sugarper,
                    BillDetailPrice = Convert.ToInt32(priceTB.Text)
                }; 
                //MessageBox.Show(GetLatestBillId(), "");
                db.BillDetails.Add(item);
                //MessageBox.Show(GetLatestBillId() + " " + drinkIDTB.Text + " " + numberTB.Text + " " + sizeCB.Text + " " + topping + " " + iceper + " " + sugarper + " " + priceTB.Text, "");
                
                db.SaveChanges();
                billPanel.BringToFront();
                tableUpdate();
                MessageBox.Show("Thêm vào hóa đơn thành công!", "THÔNG BÁO!");
                btnConfirm.Enabled = false;
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI"); 
            }
            /*catch (DbEntityValidationException e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
                foreach (var eve in e1.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }*/
        }

        public String SelectCategoryName(String C)
        {
            return MenuDAO.Instance.SelectCategoryName(C);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            //deleteBillDetailBtn.Visible = false;
            //deleteToppingDetailBtn.Visible = false;
            toppingTB.Visible = false;
            toppingLabel.Visible = false;
            toppingDGVPanel.Visible = false;
            mainMenuBtn.Visible = true;
            sugaricePanel.Visible = true;
            btnConfirm.BringToFront();
            listPanel[0].BringToFront();
            billDetailPanelBtn.Enabled = true;
            orderBtn.Enabled = false;
        }
        

        private void drinkDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        public void tableUpdate()
        {
            //deleteToppingDetailBtn.Enabled = false;
            //deleteBillDetailBtn.Enabled = false;
            toppingDGV.Enabled = false;
            toppingAddBtn.Enabled = false;
            MilkTeaContextDB db = new MilkTeaContextDB();
            List<Drink> drinkList = db.Drinks.ToList<Drink>();
            List<Category> categoryList = db.Categories.ToList<Category>();
            List<BillDetail> billDetailList = db.BillDetails.ToList<BillDetail>();
            List<ToppingTable> toppingList = db.ToppingTables.ToList<ToppingTable>();
            drinkDGV.AutoGenerateColumns = false;
            
            drinkDGV.DataSource = drinkList;
            billDetailDGV.AutoGenerateColumns = false;
            /*using (db)
            {
                billDetailDGV.DataSource = drinkList;
            }*/
            billDetailDGV.Refresh();
            toppingDGV.AutoGenerateColumns = false;
            toppingDGV.DataSource = toppingList;
            try
            {
                billid = GetLatestBillId(); 
                billDetailDGV.DataSource = db.BillDetails.Where(o => o.BillId == billid).ToList();//
            }
            catch (DbEntityValidationException e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
                foreach (var eve in e1.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }


        private void UpdateFont(DataGridView dgv)
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Roman", 18F, GraphicsUnit.Pixel);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //display all cols as displayedCells
                //dgv.Columns[dgv.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //display the last col as fill
            }
        }

        public void AddtionalPriceCalculation()
        {
            numberTB.Text = "1";
            Drink item = new Drink();
            if (drinkDGV.CurrentRow.Index != -1)
            {
                item.DrinkId = drinkDGV.CurrentRow.Cells["DrinkID"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    cheeseCheckBox.Checked = false;
                    cunangCheckBox.Checked = false;
                    flanCheckBox.Checked = false;
                    fruitCheckBox.Checked = false;
                    snowCheckBox.Checked = false;
                    tranchauCheckBox.Checked = false;
                    yellowCheckBox.Checked = false;
                    item = db.Drinks.Where(x => x.DrinkId == item.DrinkId).FirstOrDefault();
                    if (sizeCB.SelectedItem.ToString().Contains("S"))
                    {
                        priceTB.Text = (item.Price).ToString();
                    }
                    if (sizeCB.SelectedItem.ToString().Contains("M"))
                    {
                        priceTB.Text = (item.Price + 0.5* item.Price).ToString();
                    }
                    if (sizeCB.SelectedItem.ToString().Contains("L"))
                    {
                        priceTB.Text = (item.Price + 1* item.Price).ToString();
                    }
                    addtionalPrice = Convert.ToInt32(priceTB.Text);
                }
            }

        }
        //priceTB.Text = (item.Price* Convert.ToInt32(numberTB.Text)).ToString();
                    /*
                    if (snowCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }
                    if (yellowCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }
                    if (flanCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }
                    if (cheeseCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }
                    if (cunangCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }
                    if (fruitCheckBox.Checked == true)
                    {
                        priceTB.Text = (item.Price + 10000).ToString();
                    }*/

        private void sizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddtionalPriceCalculation();
        }

        
        
        public String GetLatestBillId()
        {
            return MenuDAO.Instance.GetLatestBillId();
        }

        /*private void tranchauCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tranchauCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (tranchauCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }



        

        private void snowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (snowCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (snowCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }

        private void yellowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (yellowCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }

        private void flanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (flanCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (flanCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }

        private void cunangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cunangCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (cunangCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }

        private void cheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (cheeseCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }

        private void fruitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fruitCheckBox.Checked == true)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + 5000).ToString();
            }
            if (fruitCheckBox.Checked == false)
            {
                priceTB.Text = (Convert.ToInt32(priceTB.Text) - 5000).ToString();
            }
        }*/

        public DataTable GetBillDetailByLatestBillId()
        {
            return MenuDAO.Instance.GetBillDetailByLatestBillId();
        }

        public String GetBillDetailId(String BillId)
        {
            return MenuDAO.Instance.GetBillDetailId(BillId);
        }

        private void confirmBillBtn_Click(object sender, EventArgs e)
        {
            BillTable b = new BillTable();
            this.Hide();
            b.Show();
            this.Close();
        }

        private void numberNUD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numberTB_TextChanged(object sender, EventArgs e)
        {
            if(numberTB.Text.Equals(""))
            {
                numberTB.Text = "0";
            }
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            numberTB.Text = (Convert.ToInt32(numberTB.Text) + 1).ToString();
            priceTB.Text = (addtionalPrice * (Convert.ToInt32(numberTB.Text))).ToString();
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numberTB.Text)>0)
            { 
                numberTB.Text = (Convert.ToInt32(numberTB.Text) - 1).ToString();
                priceTB.Text = (addtionalPrice * (Convert.ToInt32(numberTB.Text))).ToString();
            }
        }

        private void toppingDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void addToppingBtn_Click(object sender, EventArgs e)
        {
            tableUpdate();
            //MessageBox.Show(GetBillDetailQuantity(bdid).ToString()+ billDetailIdTB.Text, "");
            //MessageBox.Show("", "");
            MilkTeaContextDB db = new MilkTeaContextDB();
            try
            {
                if(toppingTB.Text.Equals(""))
                {
                    throw new Exception("Vui lòng chọn topping trước khi bấm nút thêm topping!");
                }
                InsertBillDetailTopping(billDetailIdTB.Text, toppingIdTB.Text);
                
                priceTB.Text = (Convert.ToInt32(priceTB.Text) + (GetToppingPrice(toppingIdTB.Text) * GetBillDetailQuantity(billDetailIdTB.Text))).ToString();
                toppingDetailDGV.DataSource = SelectToppingDetail(billDetailIdTB.Text);
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "LỖI");
            }
            tableUpdate();
        }

        public void InsertBillDetailTopping(String billDetailId, String toppingId)
        {
            MenuDAO.Instance.InsertBillDetailTopping(billDetailId, toppingId);
        }

        public int GetToppingPrice(String toppingId)
        {
            return MenuDAO.Instance.GetToppingPrice(toppingId);
        }

        public int GetBillDetailQuantity(String billDetailId)
        {
            return MenuDAO.Instance.GetBillDetailQuantity(billDetailId);
        }

        public DataTable SelectToppingDetail(String BillDetailId)
        {
            return MenuDAO.Instance.SelectToppingDetail(BillDetailId);
        }

        public int CountTopping(String BillDetailId)
        {
            return MenuDAO.Instance.CountTopping(BillDetailId);
        }

        private void billDetailDGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void billDetailBtn_Click(object sender, EventArgs e)
        {
            //deleteBillDetailBtn.Visible = true;
            //deleteToppingDetailBtn.Visible = true;
            toppingDGVPanel.Visible = true;
            toppingTB.Visible = true;
            toppingLabel.Visible = true;
            mainMenuBtn.Visible = false;
            sugaricePanel.Visible = false;
            toppingAddBtn.BringToFront();
            billDetailPanelBtn.Enabled = true;
            sizeCB.Enabled = false;
            upBtn.Enabled = false;
            downBtn.Enabled = false;
            btnConfirm.Enabled = false;
            tableUpdate();
            drinkIDTB.Text = "";
            drinkTB.Text = "";
            drinkTypeIDTB.Text = "";
            drinkTypeTB.Text = "";
            sizeCB.Text = "S (Nhỏ)";
            numberTB.Text = "";
            priceTB.Text = "";
            toppingIdTB.Text = "";
            toppingTB.Text = "";
            billDetailIdTB.Text = "";
            listPanel[1].BringToFront();
            orderBtn.Enabled = true;
        }

        private void toppingDetailDGV_Click(object sender, EventArgs e)
        {
            //deleteToppingDetailBtn.Enabled = true;
        }

        private void drinkDGV_Click(object sender, EventArgs e)
        {
            btnConfirm.BringToFront();
            sizeCB.Enabled = true;
            upBtn.Enabled = true;
            downBtn.Enabled = true;
            btnConfirm.Enabled = true;
            rdbPercentIce1.Enabled = true;
            rdbPercentIce2.Enabled = true;
            rdbPercentIce3.Enabled = true;
            rdbPercentSugar1.Enabled = true;
            rdbPercentSugar2.Enabled = true;
            rdbPercentSugar3.Enabled = true;
            rdbPercentSugar4.Enabled = true;
            /*cheeseCheckBox.Enabled = true;
            cunangCheckBox.Enabled = true; ;
            flanCheckBox.Enabled = true;
            fruitCheckBox.Enabled = true;
            snowCheckBox.Enabled = true;
            tranchauCheckBox.Enabled = true;
            yellowCheckBox.Enabled = true;*/
            Drink item = new Drink();
            if (drinkDGV.CurrentRow.Index != -1)
            {
                item.DrinkId = drinkDGV.CurrentRow.Cells["DrinkID"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.Drinks.Where(x => x.DrinkId == item.DrinkId).FirstOrDefault();
                    drinkIDTB.Text = item.DrinkId;
                    drinkTB.Text = item.DrinkName;
                    drinkTypeIDTB.Text = item.CategoryId;
                    priceTB.Text = item.Price.ToString();
                    drinkTypeTB.Text = SelectCategoryName(drinkTypeIDTB.Text);
                    //MessageBox.Show(SelectCategoryName(drinkTypeIDTB.Text), "");
                    sizeCB.SelectedIndex = sizeCB.FindString("S (Nhỏ)");
                    numberTB.Text = "1";
                }
            }
        }

        private void toppingDGV_Click(object sender, EventArgs e)
        {
            ToppingTable item = new ToppingTable();
            if (drinkDGV.CurrentRow.Index != -1)
            {
                item.ToppingId = toppingDGV.CurrentRow.Cells["ToppingID"].Value.ToString();
                using (MilkTeaContextDB db = new MilkTeaContextDB())
                {
                    item = db.ToppingTables.Where(x => x.ToppingId == item.ToppingId).FirstOrDefault();
                    toppingIdTB.Text = item.ToppingId;
                    toppingTB.Text = item.ToppingName;
                }
            }
        }

        private void billDetailDGV_Click(object sender, EventArgs e)
        {
            if (drinkDGV.Rows.Count > 0)
            {
                //deleteBillDetailBtn.Enabled = true;
                toppingAddBtn.BringToFront();
                toppingAddBtn.Enabled = true;
                toppingDGV.Enabled = true;
                BillDetail item = new BillDetail();
                if (drinkDGV.CurrentRow.Index != -1)
                {
                    item.BillDetailId = billDetailDGV.CurrentRow.Cells["BillDetailId"].Value.ToString();
                    using (MilkTeaContextDB db = new MilkTeaContextDB())
                    {
                        item = db.BillDetails.Where(x => x.BillDetailId == item.BillDetailId).FirstOrDefault();
                        billDetailIdTB.Text = item.BillDetailId;
                        toppingDetailDGV.DataSource = SelectToppingDetail(item.BillDetailId);
                    }
                }
            }
        }

        private void menuGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
