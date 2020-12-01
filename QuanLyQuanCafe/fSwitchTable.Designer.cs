namespace QuanLyQuanCafe
{
    partial class fSwitchTable
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
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbCurTable = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.Teal;
            this.cbSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSwitchTable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSwitchTable.ForeColor = System.Drawing.Color.White;
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(352, 43);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(192, 38);
            this.cbSwitchTable.TabIndex = 8;
            this.cbSwitchTable.TabStop = false;
            //this.cbSwitchTable.SelectedIndexChanged += new System.EventHandler(this.cbSwitchTable_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Red;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(240, 154);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(305, 64);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "CHUYỂN BÀN";
            this.btnOK.UseVisualStyleBackColor = false;
            //this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCurTable
            // 
            this.lbCurTable.BackColor = System.Drawing.Color.Teal;
            this.lbCurTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCurTable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCurTable.ForeColor = System.Drawing.Color.White;
            this.lbCurTable.Location = new System.Drawing.Point(52, 42);
            this.lbCurTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurTable.Name = "lbCurTable";
            this.lbCurTable.Size = new System.Drawing.Size(193, 39);
            this.lbCurTable.TabIndex = 11;
            this.lbCurTable.Text = "label1";
            this.lbCurTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 64;
            this.iconPictureBox1.Location = new System.Drawing.Point(266, 33);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 66);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // fSwitchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 256);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lbCurTable);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSwitchTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fSwitchTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển bàn";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbCurTable;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}