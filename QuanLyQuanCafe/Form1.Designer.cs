namespace QuanLyQuanCafe
{
    partial class fLogin
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
            System.Windows.Forms.TextBox txbPassWord;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            txbPassWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 217);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUser);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 70);
            this.panel2.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUser.Location = new System.Drawing.Point(11, 14);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(193, 29);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập:";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(249, 20);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(298, 22);
            this.txbUser.TabIndex = 1;
            this.txbUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(txbPassWord);
            this.panel3.Controls.Add(this.lbPassWord);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 70);
            this.panel3.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new System.Drawing.Point(249, 20);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new System.Drawing.Size(298, 22);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassWord.Location = new System.Drawing.Point(11, 14);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(125, 29);
            this.lbPassWord.TabIndex = 0;
            this.lbPassWord.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(277, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 229);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

