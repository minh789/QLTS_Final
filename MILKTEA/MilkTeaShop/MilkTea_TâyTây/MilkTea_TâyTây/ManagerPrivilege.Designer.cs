namespace MilkTea_TâyTây
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            this.empBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // empBtn
            // 
            this.empBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.empBtn.Location = new System.Drawing.Point(60, 207);
            this.empBtn.Margin = new System.Windows.Forms.Padding(4);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(196, 95);
            this.empBtn.TabIndex = 1;
            this.empBtn.Text = "Quản lý bán hàng";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.menuBtn.Location = new System.Drawing.Point(559, 207);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(201, 95);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Quản lý Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkTea_TâyTây.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(847, 405);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.empBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.Text = "QUẢN LÝ CỬA HÀNG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}