namespace QuanLyQuanCafe
{
    partial class FoodDetails
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
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ID.Location = new System.Drawing.Point(33, 39);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 22);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(33, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbID.Location = new System.Drawing.Point(38, 79);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(180, 29);
            this.txbID.TabIndex = 4;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // txbFoodName
            // 
            this.txbFoodName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbFoodName.Location = new System.Drawing.Point(38, 204);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(336, 29);
            this.txbFoodName.TabIndex = 5;
            this.txbFoodName.TextChanged += new System.EventHandler(this.txbFoodName_TextChanged);
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPrice.Location = new System.Drawing.Point(38, 436);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(336, 29);
            this.txbPrice.TabIndex = 7;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(40, 321);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(336, 30);
            this.cbFoodCategory.TabIndex = 8;
            this.cbFoodCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFoodCategory_KeyPress);
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.BackColor = System.Drawing.Color.White;
            this.pbFoodImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoodImage.Location = new System.Drawing.Point(33, 135);
            this.pbFoodImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(306, 283);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodImage.TabIndex = 9;
            this.pbFoodImage.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(160, 13);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(179, 56);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(33, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 56);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Teal;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(33, 96);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(37, 33);
            this.btnAddImage.TabIndex = 12;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFoodCategory);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Controls.Add(this.txbFoodName);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 542);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddImage);
            this.panel2.Controls.Add(this.pbFoodImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 542);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(405, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 89);
            this.panel3.TabIndex = 15;
            // 
            // FoodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FoodDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FoodDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}