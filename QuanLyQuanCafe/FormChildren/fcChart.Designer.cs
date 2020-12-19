namespace QuanLyQuanCafe.FormChildren
{
    partial class fcChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnColumn = new FontAwesome.Sharp.IconButton();
            this.btnLine = new FontAwesome.Sharp.IconButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.BackColor = System.Drawing.Color.White;
            this.btnColumn.FlatAppearance.BorderSize = 0;
            this.btnColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColumn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnColumn.ForeColor = System.Drawing.Color.Teal;
            this.btnColumn.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnColumn.IconColor = System.Drawing.Color.Teal;
            this.btnColumn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColumn.IconSize = 20;
            this.btnColumn.Location = new System.Drawing.Point(84, 1);
            this.btnColumn.Margin = new System.Windows.Forms.Padding(2);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(93, 28);
            this.btnColumn.TabIndex = 10;
            this.btnColumn.Text = "Column";
            this.btnColumn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnColumn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColumn.UseVisualStyleBackColor = false;
            this.btnColumn.Visible = false;
            this.btnColumn.Click += new System.EventHandler(this.btnColumn_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLine.ForeColor = System.Drawing.Color.Teal;
            this.btnLine.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnLine.IconColor = System.Drawing.Color.Teal;
            this.btnLine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLine.IconSize = 20;
            this.btnLine.Location = new System.Drawing.Point(84, 0);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(79, 28);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // dtp
            // 
            this.dtp.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtp.Location = new System.Drawing.Point(440, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 8;
            this.dtp.Visible = false;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // cbOptions
            // 
            this.cbOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbOptions.Location = new System.Drawing.Point(0, 0);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(79, 28);
            this.cbOptions.TabIndex = 7;
            this.cbOptions.Text = "Năm";
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Doanh Thu";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(640, 647);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart3";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.OrangeRed;
            title4.Name = "Title1";
            title4.Text = "BIỂU ĐỒ DOANH THU";
            this.chart1.Titles.Add(title4);
            // 
            // fcChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 647);
            this.Controls.Add(this.btnColumn);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.chart1);
            this.Name = "fcChart";
            this.Text = "fcChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnColumn;
        private FontAwesome.Sharp.IconButton btnLine;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}