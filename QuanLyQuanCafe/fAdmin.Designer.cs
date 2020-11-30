namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnFood = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 716);
            this.panel1.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Location = new System.Drawing.Point(196, 98);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 79);
            this.panelRight.TabIndex = 5;
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.IconChar = FontAwesome.Sharp.IconChar.Hryvnia;
            this.btnFood.IconColor = System.Drawing.Color.White;
            this.btnFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 414);
            this.btnFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(204, 79);
            this.btnFood.TabIndex = 8;
            this.btnFood.Text = "Món";
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnCategory.IconColor = System.Drawing.Color.White;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 335);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(204, 79);
            this.btnCategory.TabIndex = 7;
            this.btnCategory.Text = "Loại ";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnTable
            // 
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.Color.White;
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 256);
            this.btnTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(204, 79);
            this.btnTable.TabIndex = 6;
            this.btnTable.Text = "Bàn";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnBill.IconColor = System.Drawing.Color.White;
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 177);
            this.btnBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(204, 79);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAccount.IconColor = System.Drawing.Color.White;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 98);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(204, 79);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 98);
            this.panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(204, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(978, 716);
            this.panelDesktop.TabIndex = 2;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 716);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFood;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnTable;
        private System.Windows.Forms.Panel panelRight;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
    }
}