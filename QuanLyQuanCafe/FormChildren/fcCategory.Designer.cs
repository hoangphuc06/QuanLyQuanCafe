namespace QuanLyQuanCafe.FormChildren
{
    partial class fcCategory
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbActive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActive = new FontAwesome.Sharp.IconButton();
            this.btnAddCategory = new FontAwesome.Sharp.IconButton();
            this.btnEditCategory = new FontAwesome.Sharp.IconButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lbCategoryName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.panel2);
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(655, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(323, 786);
            this.panel15.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbActive);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 112);
            this.panel2.TabIndex = 11;
            // 
            // lbActive
            // 
            this.lbActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbActive.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActive.Location = new System.Drawing.Point(26, 64);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(268, 38);
            this.lbActive.TabIndex = 13;
            this.lbActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái kinh doanh:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.btnEditCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 98);
            this.panel1.TabIndex = 7;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Teal;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnActive.IconColor = System.Drawing.Color.White;
            this.btnActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActive.IconSize = 40;
            this.btnActive.Location = new System.Drawing.Point(236, 26);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(51, 47);
            this.btnActive.TabIndex = 10;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Teal;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCategory.IconColor = System.Drawing.Color.White;
            this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategory.IconSize = 40;
            this.btnAddCategory.Location = new System.Drawing.Point(30, 26);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(60, 48);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Teal;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditCategory.IconColor = System.Drawing.Color.White;
            this.btnEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCategory.IconSize = 40;
            this.btnEditCategory.Location = new System.Drawing.Point(133, 26);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(59, 48);
            this.btnEditCategory.TabIndex = 9;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.lbCategoryName);
            this.panel16.Controls.Add(this.label13);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 112);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(321, 112);
            this.panel16.TabIndex = 9;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategoryName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategoryName.Location = new System.Drawing.Point(26, 64);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(268, 38);
            this.lbCategoryName.TabIndex = 13;
            this.lbCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(25, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên:";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Controls.Add(this.label10);
            this.panel19.Controls.Add(this.lbCategoryID);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(321, 112);
            this.panel19.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(25, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCategoryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategoryID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategoryID.Location = new System.Drawing.Point(26, 61);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(268, 38);
            this.lbCategoryID.TabIndex = 13;
            this.lbCategoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AllowUserToAddRows = false;
            this.dtgvCategory.AllowUserToDeleteRows = false;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.ReadOnly = true;
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(655, 786);
            this.dtgvCategory.TabIndex = 7;
            // 
            // fcCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 786);
            this.Controls.Add(this.dtgvCategory);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fcCategory";
            this.Text = "fcCategory";
            this.panel15.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnActive;
        private FontAwesome.Sharp.IconButton btnAddCategory;
        private FontAwesome.Sharp.IconButton btnEditCategory;
        private System.Windows.Forms.Label lbCategoryName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label label2;
    }
}