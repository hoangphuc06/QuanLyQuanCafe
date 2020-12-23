namespace QuanLyQuanCafe.FormChildren
{
    partial class fcFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteFood = new FontAwesome.Sharp.IconButton();
            this.btnAddFood = new FontAwesome.Sharp.IconButton();
            this.btnEditFood = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbFoodPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbFoodCategory = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbFoodID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbFoodImage = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txbFindFoodName = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodImage)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.ptbFoodImage);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(650, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(328, 786);
            this.panel8.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteFood);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.btnEditFood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 98);
            this.panel1.TabIndex = 7;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteFood.FlatAppearance.BorderSize = 0;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteFood.IconColor = System.Drawing.Color.White;
            this.btnDeleteFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteFood.IconSize = 40;
            this.btnDeleteFood.Location = new System.Drawing.Point(248, 26);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(51, 47);
            this.btnDeleteFood.TabIndex = 10;
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Teal;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddFood.IconColor = System.Drawing.Color.White;
            this.btnAddFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFood.IconSize = 40;
            this.btnAddFood.Location = new System.Drawing.Point(33, 26);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(60, 48);
            this.btnAddFood.TabIndex = 8;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.Teal;
            this.btnEditFood.FlatAppearance.BorderSize = 0;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditFood.IconColor = System.Drawing.Color.White;
            this.btnEditFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFood.IconSize = 40;
            this.btnEditFood.Location = new System.Drawing.Point(137, 26);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(59, 48);
            this.btnEditFood.TabIndex = 9;
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.lbFoodPrice);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 486);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(326, 108);
            this.panel11.TabIndex = 9;
            // 
            // lbFoodPrice
            // 
            this.lbFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFoodPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFoodPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFoodPrice.Location = new System.Drawing.Point(33, 53);
            this.lbFoodPrice.Name = "lbFoodPrice";
            this.lbFoodPrice.Size = new System.Drawing.Size(268, 38);
            this.lbFoodPrice.TabIndex = 13;
            this.lbFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(32, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.lbFoodCategory);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 378);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(326, 108);
            this.panel14.TabIndex = 10;
            // 
            // lbFoodCategory
            // 
            this.lbFoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFoodCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFoodCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFoodCategory.Location = new System.Drawing.Point(31, 54);
            this.lbFoodCategory.Name = "lbFoodCategory";
            this.lbFoodCategory.Size = new System.Drawing.Size(268, 38);
            this.lbFoodCategory.TabIndex = 13;
            this.lbFoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doanh mục:";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.lbFoodName);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 270);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(326, 108);
            this.panel13.TabIndex = 10;
            // 
            // lbFoodName
            // 
            this.lbFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFoodName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFoodName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFoodName.Location = new System.Drawing.Point(31, 42);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(268, 38);
            this.lbFoodName.TabIndex = 13;
            this.lbFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(32, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.lbFoodID);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 174);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(326, 96);
            this.panel12.TabIndex = 10;
            // 
            // lbFoodID
            // 
            this.lbFoodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFoodID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFoodID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFoodID.Location = new System.Drawing.Point(31, 39);
            this.lbFoodID.Name = "lbFoodID";
            this.lbFoodID.Size = new System.Drawing.Size(268, 38);
            this.lbFoodID.TabIndex = 12;
            this.lbFoodID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(27, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // ptbFoodImage
            // 
            this.ptbFoodImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbFoodImage.Location = new System.Drawing.Point(0, 0);
            this.ptbFoodImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptbFoodImage.Name = "ptbFoodImage";
            this.ptbFoodImage.Size = new System.Drawing.Size(326, 174);
            this.ptbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFoodImage.TabIndex = 11;
            this.ptbFoodImage.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.iconButton1);
            this.panel9.Controls.Add(this.txbFindFoodName);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(650, 55);
            this.panel9.TabIndex = 2;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Teal;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(34, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 27);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // txbFindFoodName
            // 
            this.txbFindFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFindFoodName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbFindFoodName.Location = new System.Drawing.Point(80, 16);
            this.txbFindFoodName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.txbFindFoodName.Name = "txbFindFoodName";
            this.txbFindFoodName.Size = new System.Drawing.Size(255, 22);
            this.txbFindFoodName.TabIndex = 5;
            this.txbFindFoodName.TextChanged += new System.EventHandler(this.txbFindFoodName_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Teal;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Location = new System.Drawing.Point(34, 44);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(301, 2);
            this.panel10.TabIndex = 4;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dtgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFood.Location = new System.Drawing.Point(0, 55);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(650, 731);
            this.dtgvFood.TabIndex = 4;
            this.dtgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellClick);
            // 
            // fcFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 786);
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fcFood";
            this.Text = "fcFood";
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodImage)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbFindFoodName;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dtgvFood;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDeleteFood;
        private FontAwesome.Sharp.IconButton btnAddFood;
        private FontAwesome.Sharp.IconButton btnEditFood;
        private System.Windows.Forms.PictureBox ptbFoodImage;
        private System.Windows.Forms.Label lbFoodPrice;
        private System.Windows.Forms.Label lbFoodCategory;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbFoodID;
    }
}