namespace QuanLyQuanCafe.FormChildren
{
    partial class fcAccountList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.btnAddAccount = new FontAwesome.Sharp.IconButton();
            this.btnActiveAccount = new FontAwesome.Sharp.IconButton();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbTypeAccount = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel28);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picAccount);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 786);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnResetPassword);
            this.panel4.Controls.Add(this.btnAddAccount);
            this.panel4.Controls.Add(this.btnActiveAccount);
            this.panel4.Controls.Add(this.btnEditAccount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 685);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 99);
            this.panel4.TabIndex = 8;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Teal;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnResetPassword.IconColor = System.Drawing.Color.White;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.IconSize = 40;
            this.btnResetPassword.Location = new System.Drawing.Point(267, 26);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(51, 47);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Teal;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddAccount.IconColor = System.Drawing.Color.White;
            this.btnAddAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAccount.IconSize = 40;
            this.btnAddAccount.Location = new System.Drawing.Point(25, 26);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(60, 48);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnActiveAccount
            // 
            this.btnActiveAccount.BackColor = System.Drawing.Color.Teal;
            this.btnActiveAccount.FlatAppearance.BorderSize = 0;
            this.btnActiveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveAccount.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnActiveAccount.IconColor = System.Drawing.Color.White;
            this.btnActiveAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActiveAccount.IconSize = 40;
            this.btnActiveAccount.Location = new System.Drawing.Point(190, 26);
            this.btnActiveAccount.Name = "btnActiveAccount";
            this.btnActiveAccount.Size = new System.Drawing.Size(51, 47);
            this.btnActiveAccount.TabIndex = 4;
            this.btnActiveAccount.UseVisualStyleBackColor = false;
            this.btnActiveAccount.Click += new System.EventHandler(this.btnActiveAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.Teal;
            this.btnEditAccount.FlatAppearance.BorderSize = 0;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditAccount.IconColor = System.Drawing.Color.White;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.IconSize = 40;
            this.btnEditAccount.Location = new System.Drawing.Point(107, 27);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(59, 48);
            this.btnEditAccount.TabIndex = 4;
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAccountType);
            this.panel3.Controls.Add(this.lbTypeAccount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 101);
            this.panel3.TabIndex = 7;
            // 
            // lbAccountType
            // 
            this.lbAccountType.BackColor = System.Drawing.Color.White;
            this.lbAccountType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAccountType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccountType.Location = new System.Drawing.Point(25, 53);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(268, 36);
            this.lbAccountType.TabIndex = 4;
            this.lbAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTypeAccount
            // 
            this.lbTypeAccount.AutoSize = true;
            this.lbTypeAccount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTypeAccount.Location = new System.Drawing.Point(21, 17);
            this.lbTypeAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeAccount.Name = "lbTypeAccount";
            this.lbTypeAccount.Size = new System.Drawing.Size(159, 24);
            this.lbTypeAccount.TabIndex = 0;
            this.lbTypeAccount.Text = "Loại tài khoản:";
            this.lbTypeAccount.Click += new System.EventHandler(this.lbTypeAccount_Click);
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.White;
            this.panel28.Controls.Add(this.lbDisplayName);
            this.panel28.Controls.Add(this.label1);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 375);
            this.panel28.Margin = new System.Windows.Forms.Padding(2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(343, 101);
            this.panel28.TabIndex = 3;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.BackColor = System.Drawing.Color.White;
            this.lbDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisplayName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDisplayName.Location = new System.Drawing.Point(25, 44);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(268, 36);
            this.lbDisplayName.TabIndex = 4;
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 101);
            this.panel2.TabIndex = 4;
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.White;
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUser.Location = new System.Drawing.Point(25, 44);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(268, 36);
            this.lbUser.TabIndex = 4;
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Location = new System.Drawing.Point(21, 20);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(154, 24);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên tài khoản:";
            // 
            // picAccount
            // 
            this.picAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAccount.Location = new System.Drawing.Point(0, 45);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(343, 229);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAccount.TabIndex = 9;
            this.picAccount.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 45);
            this.panel5.TabIndex = 10;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAccount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(633, 786);
            this.dtgvAccount.TabIndex = 3;
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbActive);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 577);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 101);
            this.panel6.TabIndex = 11;
            // 
            // lbActive
            // 
            this.lbActive.BackColor = System.Drawing.Color.White;
            this.lbActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbActive.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbActive.Location = new System.Drawing.Point(25, 53);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(268, 36);
            this.lbActive.TabIndex = 4;
            this.lbActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái làm việc:";
            // 
            // fcAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 786);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fcAccountList";
            this.Text = "fcAccountList";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbTypeAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnAddAccount;
        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnActiveAccount;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label label3;
    }
}