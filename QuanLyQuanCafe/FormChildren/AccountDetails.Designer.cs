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
            this.ptbPicture = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbAccountName = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại tài khoản:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.Location = new System.Drawing.Point(82, 143);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(315, 40);
            this.txbDisplayName.TabIndex = 4;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAccountType.Location = new System.Drawing.Point(238, 278);
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(159, 30);
            this.nmAccountType.TabIndex = 5;
            this.nmAccountType.ValueChanged += new System.EventHandler(this.nmAccountType_ValueChanged);
            // 
            // ptbPicture
            // 
            this.ptbPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ptbPicture.Location = new System.Drawing.Point(464, 30);
            this.ptbPicture.Name = "ptbPicture";
            this.ptbPicture.Size = new System.Drawing.Size(255, 278);
            this.ptbPicture.TabIndex = 6;
            this.ptbPicture.TabStop = false;
            this.ptbPicture.DoubleClick += new System.EventHandler(this.ptbPicture_DoubleClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(464, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(254, 39);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txbAccountName
            // 
            this.txbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountName.Location = new System.Drawing.Point(214, 30);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(183, 38);
            this.txbAccountName.TabIndex = 8;
            this.txbAccountName.TextChanged += new System.EventHandler(this.txbAccountName_TextChanged);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 414);
            this.Controls.Add(this.txbAccountName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbPicture);
            this.Controls.Add(this.nmAccountType);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountDetails";
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
    }
}