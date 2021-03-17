namespace MilkTea_TâyTây
{
    partial class MenuManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManagement));
            this.drinkDGV = new System.Windows.Forms.DataGridView();
            this.DrinkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMilkTea = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toppingPriceLabel = new System.Windows.Forms.Label();
            this.toppingPriceTB = new System.Windows.Forms.TextBox();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.updateToppingBtn = new System.Windows.Forms.Button();
            this.deleteToppingBtn = new System.Windows.Forms.Button();
            this.addToppingBtn = new System.Windows.Forms.Button();
            this.toppingIdLabel = new System.Windows.Forms.Label();
            this.toppingNameLabel = new System.Windows.Forms.Label();
            this.toppingNameTB = new System.Windows.Forms.TextBox();
            this.toppingIdTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.deleteCategoryBtn = new System.Windows.Forms.Button();
            this.inputCategoryBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryNameTB = new System.Windows.Forms.TextBox();
            this.categoryIdTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryIDCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateMenuBtn = new System.Windows.Forms.Button();
            this.deleteMenuBtn = new System.Windows.Forms.Button();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.inputMenuBtn = new System.Windows.Forms.Button();
            this.drinkIDLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.drinkNameLabel = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.drinkNameTB = new System.Windows.Forms.TextBox();
            this.drinkIDTB = new System.Windows.Forms.TextBox();
            this.categoryDGV = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingDGV = new System.Windows.Forms.DataGridView();
            this.ToppingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToppingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToppingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drinkDGV)).BeginInit();
            this.pnMilkTea.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toppingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkDGV
            // 
            this.drinkDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drinkDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.drinkDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinkId,
            this.DrinkName,
            this.CategoryId2,
            this.Price});
            this.drinkDGV.Location = new System.Drawing.Point(0, 238);
            this.drinkDGV.Name = "drinkDGV";
            this.drinkDGV.ReadOnly = true;
            this.drinkDGV.RowHeadersWidth = 51;
            this.drinkDGV.Size = new System.Drawing.Size(636, 227);
            this.drinkDGV.TabIndex = 11;
            this.drinkDGV.Click += new System.EventHandler(this.drinkDGV_Click);
            this.drinkDGV.DoubleClick += new System.EventHandler(this.drinkDGV_DoubleClick);
            // 
            // DrinkId
            // 
            this.DrinkId.DataPropertyName = "DrinkId";
            this.DrinkId.HeaderText = "Mã nước";
            this.DrinkId.MinimumWidth = 6;
            this.DrinkId.Name = "DrinkId";
            this.DrinkId.ReadOnly = true;
            // 
            // DrinkName
            // 
            this.DrinkName.DataPropertyName = "DrinkName";
            this.DrinkName.HeaderText = "Tên nước";
            this.DrinkName.MinimumWidth = 6;
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.ReadOnly = true;
            // 
            // CategoryId2
            // 
            this.CategoryId2.DataPropertyName = "CategoryId";
            this.CategoryId2.HeaderText = "Mã danh mục";
            this.CategoryId2.MinimumWidth = 6;
            this.CategoryId2.Name = "CategoryId2";
            this.CategoryId2.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pnMilkTea
            // 
            this.pnMilkTea.AutoScroll = true;
            this.pnMilkTea.BackColor = System.Drawing.Color.Snow;
            this.pnMilkTea.BackgroundImage = global::MilkTea_TâyTây.Properties.Resources.milktea_wallpaper_2;
            this.pnMilkTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMilkTea.Controls.Add(this.searchLabel);
            this.pnMilkTea.Controls.Add(this.searchTB);
            this.pnMilkTea.Controls.Add(this.panel3);
            this.pnMilkTea.Controls.Add(this.panel2);
            this.pnMilkTea.Controls.Add(this.panel1);
            this.pnMilkTea.Location = new System.Drawing.Point(641, 1);
            this.pnMilkTea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMilkTea.Name = "pnMilkTea";
            this.pnMilkTea.Size = new System.Drawing.Size(695, 633);
            this.pnMilkTea.TabIndex = 10;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(61, 23);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(106, 23);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "TÌM KIẾM";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(17, 50);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(212, 32);
            this.searchTB.TabIndex = 10;
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.toppingPriceLabel);
            this.panel3.Controls.Add(this.toppingPriceTB);
            this.panel3.Controls.Add(this.toppingLabel);
            this.panel3.Controls.Add(this.updateToppingBtn);
            this.panel3.Controls.Add(this.deleteToppingBtn);
            this.panel3.Controls.Add(this.addToppingBtn);
            this.panel3.Controls.Add(this.toppingIdLabel);
            this.panel3.Controls.Add(this.toppingNameLabel);
            this.panel3.Controls.Add(this.toppingNameTB);
            this.panel3.Controls.Add(this.toppingIdTB);
            this.panel3.Location = new System.Drawing.Point(235, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 195);
            this.panel3.TabIndex = 8;
            // 
            // toppingPriceLabel
            // 
            this.toppingPriceLabel.AutoSize = true;
            this.toppingPriceLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toppingPriceLabel.Location = new System.Drawing.Point(12, 105);
            this.toppingPriceLabel.Name = "toppingPriceLabel";
            this.toppingPriceLabel.Size = new System.Drawing.Size(39, 22);
            this.toppingPriceLabel.TabIndex = 8;
            this.toppingPriceLabel.Text = "Giá";
            // 
            // toppingPriceTB
            // 
            this.toppingPriceTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toppingPriceTB.Location = new System.Drawing.Point(163, 106);
            this.toppingPriceTB.Name = "toppingPriceTB";
            this.toppingPriceTB.Size = new System.Drawing.Size(249, 30);
            this.toppingPriceTB.TabIndex = 9;
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingLabel.Location = new System.Drawing.Point(114, 7);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(100, 23);
            this.toppingLabel.TabIndex = 7;
            this.toppingLabel.Text = "TOPPING";
            // 
            // updateToppingBtn
            // 
            this.updateToppingBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.updateToppingBtn.Location = new System.Drawing.Point(144, 145);
            this.updateToppingBtn.Name = "updateToppingBtn";
            this.updateToppingBtn.Size = new System.Drawing.Size(63, 43);
            this.updateToppingBtn.TabIndex = 5;
            this.updateToppingBtn.Text = "SỬA";
            this.updateToppingBtn.UseVisualStyleBackColor = true;
            this.updateToppingBtn.Click += new System.EventHandler(this.updateToppingBtn_Click);
            // 
            // deleteToppingBtn
            // 
            this.deleteToppingBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deleteToppingBtn.Location = new System.Drawing.Point(267, 145);
            this.deleteToppingBtn.Name = "deleteToppingBtn";
            this.deleteToppingBtn.Size = new System.Drawing.Size(63, 43);
            this.deleteToppingBtn.TabIndex = 6;
            this.deleteToppingBtn.Text = "XÓA";
            this.deleteToppingBtn.UseVisualStyleBackColor = true;
            this.deleteToppingBtn.Click += new System.EventHandler(this.deleteToppingBtn_Click);
            // 
            // addToppingBtn
            // 
            this.addToppingBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.addToppingBtn.Location = new System.Drawing.Point(18, 145);
            this.addToppingBtn.Name = "addToppingBtn";
            this.addToppingBtn.Size = new System.Drawing.Size(63, 43);
            this.addToppingBtn.TabIndex = 4;
            this.addToppingBtn.Text = "NHẬP";
            this.addToppingBtn.UseVisualStyleBackColor = true;
            this.addToppingBtn.Click += new System.EventHandler(this.addToppingBtn_Click);
            // 
            // toppingIdLabel
            // 
            this.toppingIdLabel.AutoSize = true;
            this.toppingIdLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toppingIdLabel.Location = new System.Drawing.Point(12, 67);
            this.toppingIdLabel.Name = "toppingIdLabel";
            this.toppingIdLabel.Size = new System.Drawing.Size(106, 22);
            this.toppingIdLabel.TabIndex = 0;
            this.toppingIdLabel.Text = "Mã Topping";
            // 
            // toppingNameLabel
            // 
            this.toppingNameLabel.AutoSize = true;
            this.toppingNameLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toppingNameLabel.Location = new System.Drawing.Point(12, 31);
            this.toppingNameLabel.Name = "toppingNameLabel";
            this.toppingNameLabel.Size = new System.Drawing.Size(110, 22);
            this.toppingNameLabel.TabIndex = 0;
            this.toppingNameLabel.Text = "Tên Topping";
            // 
            // toppingNameTB
            // 
            this.toppingNameTB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingNameTB.Location = new System.Drawing.Point(163, 32);
            this.toppingNameTB.Name = "toppingNameTB";
            this.toppingNameTB.Size = new System.Drawing.Size(249, 30);
            this.toppingNameTB.TabIndex = 1;
            // 
            // toppingIdTB
            // 
            this.toppingIdTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toppingIdTB.Location = new System.Drawing.Point(163, 68);
            this.toppingIdTB.Name = "toppingIdTB";
            this.toppingIdTB.Size = new System.Drawing.Size(249, 30);
            this.toppingIdTB.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.updateCategoryBtn);
            this.panel2.Controls.Add(this.deleteCategoryBtn);
            this.panel2.Controls.Add(this.inputCategoryBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.categoryNameTB);
            this.panel2.Controls.Add(this.categoryIdTB);
            this.panel2.Location = new System.Drawing.Point(235, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 162);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "DANH MỤC";
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.updateCategoryBtn.Location = new System.Drawing.Point(160, 104);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(63, 43);
            this.updateCategoryBtn.TabIndex = 5;
            this.updateCategoryBtn.Text = "SỬA";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deleteCategoryBtn.Location = new System.Drawing.Point(283, 104);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(63, 43);
            this.deleteCategoryBtn.TabIndex = 6;
            this.deleteCategoryBtn.Text = "XÓA";
            this.deleteCategoryBtn.UseVisualStyleBackColor = true;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
            // 
            // inputCategoryBtn
            // 
            this.inputCategoryBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.inputCategoryBtn.Location = new System.Drawing.Point(34, 104);
            this.inputCategoryBtn.Name = "inputCategoryBtn";
            this.inputCategoryBtn.Size = new System.Drawing.Size(63, 43);
            this.inputCategoryBtn.TabIndex = 4;
            this.inputCategoryBtn.Text = "NHẬP";
            this.inputCategoryBtn.UseVisualStyleBackColor = true;
            this.inputCategoryBtn.Click += new System.EventHandler(this.inputCategoryBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên danh mục";
            // 
            // categoryNameTB
            // 
            this.categoryNameTB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTB.Location = new System.Drawing.Point(163, 32);
            this.categoryNameTB.Name = "categoryNameTB";
            this.categoryNameTB.Size = new System.Drawing.Size(249, 30);
            this.categoryNameTB.TabIndex = 1;
            // 
            // categoryIdTB
            // 
            this.categoryIdTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.categoryIdTB.Location = new System.Drawing.Point(163, 68);
            this.categoryIdTB.Name = "categoryIdTB";
            this.categoryIdTB.Size = new System.Drawing.Size(249, 30);
            this.categoryIdTB.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.categoryIDCB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updateMenuBtn);
            this.panel1.Controls.Add(this.deleteMenuBtn);
            this.panel1.Controls.Add(this.CategoryIDLabel);
            this.panel1.Controls.Add(this.inputMenuBtn);
            this.panel1.Controls.Add(this.drinkIDLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.drinkNameLabel);
            this.panel1.Controls.Add(this.priceTB);
            this.panel1.Controls.Add(this.drinkNameTB);
            this.panel1.Controls.Add(this.drinkIDTB);
            this.panel1.Location = new System.Drawing.Point(235, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 238);
            this.panel1.TabIndex = 2;
            // 
            // categoryIDCB
            // 
            this.categoryIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIDCB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDCB.FormattingEnabled = true;
            this.categoryIDCB.Location = new System.Drawing.Point(163, 105);
            this.categoryIDCB.Name = "categoryIDCB";
            this.categoryIDCB.Size = new System.Drawing.Size(249, 30);
            this.categoryIDCB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "NƯỚC UỐNG";
            // 
            // updateMenuBtn
            // 
            this.updateMenuBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.updateMenuBtn.Location = new System.Drawing.Point(144, 180);
            this.updateMenuBtn.Name = "updateMenuBtn";
            this.updateMenuBtn.Size = new System.Drawing.Size(70, 45);
            this.updateMenuBtn.TabIndex = 5;
            this.updateMenuBtn.Text = "SỬA";
            this.updateMenuBtn.UseVisualStyleBackColor = true;
            this.updateMenuBtn.Click += new System.EventHandler(this.updateMenuBtn_Click);
            // 
            // deleteMenuBtn
            // 
            this.deleteMenuBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deleteMenuBtn.Location = new System.Drawing.Point(267, 180);
            this.deleteMenuBtn.Name = "deleteMenuBtn";
            this.deleteMenuBtn.Size = new System.Drawing.Size(70, 45);
            this.deleteMenuBtn.TabIndex = 6;
            this.deleteMenuBtn.Text = "XÓA";
            this.deleteMenuBtn.UseVisualStyleBackColor = true;
            this.deleteMenuBtn.Click += new System.EventHandler(this.deleteMenuBtn_Click);
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.CategoryIDLabel.Location = new System.Drawing.Point(12, 108);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(115, 22);
            this.CategoryIDLabel.TabIndex = 0;
            this.CategoryIDLabel.Text = "Mã danh mục";
            this.CategoryIDLabel.Click += new System.EventHandler(this.CategoryIDLabel_Click);
            // 
            // inputMenuBtn
            // 
            this.inputMenuBtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.inputMenuBtn.Location = new System.Drawing.Point(18, 180);
            this.inputMenuBtn.Name = "inputMenuBtn";
            this.inputMenuBtn.Size = new System.Drawing.Size(70, 45);
            this.inputMenuBtn.TabIndex = 4;
            this.inputMenuBtn.Text = "NHẬP";
            this.inputMenuBtn.UseVisualStyleBackColor = true;
            this.inputMenuBtn.Click += new System.EventHandler(this.inputMenuBtn_Click);
            // 
            // drinkIDLabel
            // 
            this.drinkIDLabel.AutoSize = true;
            this.drinkIDLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.drinkIDLabel.Location = new System.Drawing.Point(12, 71);
            this.drinkIDLabel.Name = "drinkIDLabel";
            this.drinkIDLabel.Size = new System.Drawing.Size(123, 22);
            this.drinkIDLabel.TabIndex = 0;
            this.drinkIDLabel.Text = "Mã nước uống";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.priceLabel.Location = new System.Drawing.Point(12, 144);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 22);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Giá";
            // 
            // drinkNameLabel
            // 
            this.drinkNameLabel.AutoSize = true;
            this.drinkNameLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkNameLabel.Location = new System.Drawing.Point(12, 35);
            this.drinkNameLabel.Name = "drinkNameLabel";
            this.drinkNameLabel.Size = new System.Drawing.Size(127, 22);
            this.drinkNameLabel.TabIndex = 0;
            this.drinkNameLabel.Text = "Tên nước uống";
            this.drinkNameLabel.Click += new System.EventHandler(this.drinkNameLabel_Click);
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.priceTB.Location = new System.Drawing.Point(163, 144);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(249, 30);
            this.priceTB.TabIndex = 1;
            // 
            // drinkNameTB
            // 
            this.drinkNameTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.drinkNameTB.Location = new System.Drawing.Point(163, 36);
            this.drinkNameTB.Name = "drinkNameTB";
            this.drinkNameTB.Size = new System.Drawing.Size(249, 30);
            this.drinkNameTB.TabIndex = 1;
            // 
            // drinkIDTB
            // 
            this.drinkIDTB.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.drinkIDTB.Location = new System.Drawing.Point(163, 72);
            this.drinkIDTB.Name = "drinkIDTB";
            this.drinkIDTB.Size = new System.Drawing.Size(249, 30);
            this.drinkIDTB.TabIndex = 1;
            // 
            // categoryDGV
            // 
            this.categoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName});
            this.categoryDGV.Location = new System.Drawing.Point(0, 24);
            this.categoryDGV.Name = "categoryDGV";
            this.categoryDGV.ReadOnly = true;
            this.categoryDGV.RowHeadersWidth = 51;
            this.categoryDGV.Size = new System.Drawing.Size(636, 208);
            this.categoryDGV.TabIndex = 12;
            this.categoryDGV.Click += new System.EventHandler(this.categoryDGV_Click);
            this.categoryDGV.DoubleClick += new System.EventHandler(this.categoryDGV_DoubleClick);
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "Mã danh mục";
            this.CategoryId.MinimumWidth = 6;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Tên danh mục";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1335, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // toppingDGV
            // 
            this.toppingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toppingDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.toppingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toppingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToppingId,
            this.ToppingName,
            this.ToppingPrice});
            this.toppingDGV.Location = new System.Drawing.Point(0, 471);
            this.toppingDGV.Name = "toppingDGV";
            this.toppingDGV.ReadOnly = true;
            this.toppingDGV.RowHeadersWidth = 51;
            this.toppingDGV.Size = new System.Drawing.Size(636, 163);
            this.toppingDGV.TabIndex = 14;
            this.toppingDGV.Click += new System.EventHandler(this.toppingDGV_Click);
            this.toppingDGV.DoubleClick += new System.EventHandler(this.toppingDGV_DoubleClick);
            // 
            // ToppingId
            // 
            this.ToppingId.DataPropertyName = "ToppingId";
            this.ToppingId.HeaderText = "Mã Topping";
            this.ToppingId.MinimumWidth = 6;
            this.ToppingId.Name = "ToppingId";
            this.ToppingId.ReadOnly = true;
            // 
            // ToppingName
            // 
            this.ToppingName.DataPropertyName = "ToppingName";
            this.ToppingName.HeaderText = "Tên Topping";
            this.ToppingName.MinimumWidth = 6;
            this.ToppingName.Name = "ToppingName";
            this.ToppingName.ReadOnly = true;
            // 
            // ToppingPrice
            // 
            this.ToppingPrice.DataPropertyName = "ToppingPrice";
            this.ToppingPrice.HeaderText = "Giá";
            this.ToppingPrice.MinimumWidth = 6;
            this.ToppingPrice.Name = "ToppingPrice";
            this.ToppingPrice.ReadOnly = true;
            // 
            // MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1335, 645);
            this.Controls.Add(this.toppingDGV);
            this.Controls.Add(this.categoryDGV);
            this.Controls.Add(this.drinkDGV);
            this.Controls.Add(this.pnMilkTea);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MenuManagement";
            this.Text = "Quản lý Menu";
            ((System.ComponentModel.ISupportInitialize)(this.drinkDGV)).EndInit();
            this.pnMilkTea.ResumeLayout(false);
            this.pnMilkTea.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toppingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMilkTea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox drinkNameTB;
        private System.Windows.Forms.Label drinkNameLabel;
        private System.Windows.Forms.Label CategoryIDLabel;
        private System.Windows.Forms.Label drinkIDLabel;
        private System.Windows.Forms.TextBox drinkIDTB;
        private System.Windows.Forms.Button deleteMenuBtn;
        private System.Windows.Forms.Button updateMenuBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Button inputMenuBtn;
        private System.Windows.Forms.DataGridView drinkDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.Button deleteCategoryBtn;
        private System.Windows.Forms.Button inputCategoryBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryNameTB;
        private System.Windows.Forms.TextBox categoryIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoryDGV;
        private System.Windows.Forms.ComboBox categoryIDCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.Button updateToppingBtn;
        private System.Windows.Forms.Button deleteToppingBtn;
        private System.Windows.Forms.Button addToppingBtn;
        private System.Windows.Forms.Label toppingIdLabel;
        private System.Windows.Forms.Label toppingNameLabel;
        private System.Windows.Forms.TextBox toppingNameTB;
        private System.Windows.Forms.TextBox toppingIdTB;
        private System.Windows.Forms.DataGridView toppingDGV;
        private System.Windows.Forms.Label toppingPriceLabel;
        private System.Windows.Forms.TextBox toppingPriceTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingPrice;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
    }
}