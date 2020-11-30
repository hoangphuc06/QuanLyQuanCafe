namespace QuanLyQuanCafe
{
    partial class fAccount
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pannelDesktop = new System.Windows.Forms.Panel();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.btnPassword);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 577);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 98);
            this.panel2.TabIndex = 2;
            // 
            // pannelDesktop
            // 
            this.pannelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelDesktop.Location = new System.Drawing.Point(204, 0);
            this.pannelDesktop.Name = "pannelDesktop";
            this.pannelDesktop.Size = new System.Drawing.Size(723, 577);
            this.pannelDesktop.TabIndex = 1;
            // 
            // btnPassword
            // 
            this.btnPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnPassword.IconColor = System.Drawing.Color.White;
            this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(0, 177);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(204, 79);
            this.btnPassword.TabIndex = 4;
            this.btnPassword.Text = "Đổi mật khẩu";
            this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 98);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(204, 79);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(927, 577);
            this.Controls.Add(this.pannelDesktop);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccount";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRight;
        private FontAwesome.Sharp.IconButton btnPassword;
        private FontAwesome.Sharp.IconButton btnInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pannelDesktop;
    }
}