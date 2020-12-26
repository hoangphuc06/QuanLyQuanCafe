namespace QuanLyQuanCafe.FormChildren
{
    partial class AccountDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.ptbPicture = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại tài khoản:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDisplayName.Location = new System.Drawing.Point(15, 178);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(380, 29);
            this.txbDisplayName.TabIndex = 4;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmAccountType.Location = new System.Drawing.Point(237, 271);
            this.nmAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(159, 29);
            this.nmAccountType.TabIndex = 5;
            this.nmAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmAccountType.ValueChanged += new System.EventHandler(this.nmAccountType_ValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(451, 354);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(253, 59);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txbAccountName
            // 
            this.txbAccountName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbAccountName.Location = new System.Drawing.Point(15, 79);
            this.txbAccountName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(380, 29);
            this.txbAccountName.TabIndex = 8;
            this.txbAccountName.TextChanged += new System.EventHandler(this.txbAccountName_TextChanged);
            // 
            // ptbPicture
            // 
            this.ptbPicture.BackColor = System.Drawing.Color.White;
            this.ptbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPicture.Location = new System.Drawing.Point(451, 62);
            this.ptbPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPicture.Name = "ptbPicture";
            this.ptbPicture.Size = new System.Drawing.Size(254, 262);
            this.ptbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPicture.TabIndex = 6;
            this.ptbPicture.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Teal;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(451, 24);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(37, 33);
            this.btnAddImage.TabIndex = 13;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 438);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txbAccountName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbPicture);
            this.Controls.Add(this.nmAccountType);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.PictureBox ptbPicture;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Button btnAddImage;
    }
}