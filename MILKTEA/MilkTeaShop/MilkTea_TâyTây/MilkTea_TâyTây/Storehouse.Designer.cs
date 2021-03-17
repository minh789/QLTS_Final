namespace MilkTea_TâyTây
{
    partial class Storehouse
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
            this.deleteMenuBtn = new System.Windows.Forms.Button();
            this.updateMenuBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inputMenuBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ingredientIDLabel = new System.Windows.Forms.Label();
            this.drinkIDTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ingrdientNameLabel = new System.Windows.Forms.Label();
            this.drinkNameTB = new System.Windows.Forms.TextBox();
            this.storehouseDGV = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteMenuBtn
            // 
            this.deleteMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.deleteMenuBtn.Location = new System.Drawing.Point(339, 248);
            this.deleteMenuBtn.Name = "deleteMenuBtn";
            this.deleteMenuBtn.Size = new System.Drawing.Size(107, 53);
            this.deleteMenuBtn.TabIndex = 13;
            this.deleteMenuBtn.Text = "XÓA";
            this.deleteMenuBtn.UseVisualStyleBackColor = true;
            // 
            // updateMenuBtn
            // 
            this.updateMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.updateMenuBtn.Location = new System.Drawing.Point(181, 248);
            this.updateMenuBtn.Name = "updateMenuBtn";
            this.updateMenuBtn.Size = new System.Drawing.Size(107, 53);
            this.updateMenuBtn.TabIndex = 12;
            this.updateMenuBtn.Text = "SỬA";
            this.updateMenuBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.priceLabel);
            this.panel4.Location = new System.Drawing.Point(27, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 33);
            this.panel4.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceLabel.Location = new System.Drawing.Point(3, 3);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(128, 25);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Ngày hết hạn";
            // 
            // inputMenuBtn
            // 
            this.inputMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputMenuBtn.Location = new System.Drawing.Point(27, 248);
            this.inputMenuBtn.Name = "inputMenuBtn";
            this.inputMenuBtn.Size = new System.Drawing.Size(107, 53);
            this.inputMenuBtn.TabIndex = 11;
            this.inputMenuBtn.Text = "NHẬP";
            this.inputMenuBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.CategoryIDLabel);
            this.panel3.Location = new System.Drawing.Point(27, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 33);
            this.panel3.TabIndex = 8;
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CategoryIDLabel.Location = new System.Drawing.Point(3, 3);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(137, 25);
            this.CategoryIDLabel.TabIndex = 0;
            this.CategoryIDLabel.Text = "Ngày sản xuất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ingredientIDLabel);
            this.panel2.Controls.Add(this.drinkIDTB);
            this.panel2.Location = new System.Drawing.Point(27, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 33);
            this.panel2.TabIndex = 9;
            // 
            // ingredientIDLabel
            // 
            this.ingredientIDLabel.AutoSize = true;
            this.ingredientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ingredientIDLabel.Location = new System.Drawing.Point(3, 3);
            this.ingredientIDLabel.Name = "ingredientIDLabel";
            this.ingredientIDLabel.Size = new System.Drawing.Size(145, 25);
            this.ingredientIDLabel.TabIndex = 0;
            this.ingredientIDLabel.Text = "Mã nguyên liệu";
            // 
            // drinkIDTB
            // 
            this.drinkIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.drinkIDTB.Location = new System.Drawing.Point(154, 0);
            this.drinkIDTB.Name = "drinkIDTB";
            this.drinkIDTB.Size = new System.Drawing.Size(153, 30);
            this.drinkIDTB.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ingrdientNameLabel);
            this.panel1.Controls.Add(this.drinkNameTB);
            this.panel1.Location = new System.Drawing.Point(27, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 33);
            this.panel1.TabIndex = 7;
            // 
            // ingrdientNameLabel
            // 
            this.ingrdientNameLabel.AutoSize = true;
            this.ingrdientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ingrdientNameLabel.Location = new System.Drawing.Point(3, 3);
            this.ingrdientNameLabel.Name = "ingrdientNameLabel";
            this.ingrdientNameLabel.Size = new System.Drawing.Size(152, 25);
            this.ingrdientNameLabel.TabIndex = 0;
            this.ingrdientNameLabel.Text = "Tên nguyên liệu";
            // 
            // drinkNameTB
            // 
            this.drinkNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.drinkNameTB.Location = new System.Drawing.Point(154, 0);
            this.drinkNameTB.Name = "drinkNameTB";
            this.drinkNameTB.Size = new System.Drawing.Size(153, 30);
            this.drinkNameTB.TabIndex = 1;
            // 
            // storehouseDGV
            // 
            this.storehouseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storehouseDGV.Location = new System.Drawing.Point(471, 15);
            this.storehouseDGV.Name = "storehouseDGV";
            this.storehouseDGV.Size = new System.Drawing.Size(426, 285);
            this.storehouseDGV.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(146, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // Storehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 323);
            this.Controls.Add(this.storehouseDGV);
            this.Controls.Add(this.deleteMenuBtn);
            this.Controls.Add(this.updateMenuBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.inputMenuBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Storehouse";
            this.Text = "Quản lý kho";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteMenuBtn;
        private System.Windows.Forms.Button updateMenuBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button inputMenuBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CategoryIDLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ingredientIDLabel;
        private System.Windows.Forms.TextBox drinkIDTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ingrdientNameLabel;
        private System.Windows.Forms.TextBox drinkNameTB;
        private System.Windows.Forms.DataGridView storehouseDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}