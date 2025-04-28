namespace TeaShopMIS
{
    partial class Frm_BusinessChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_User = new System.Windows.Forms.ComboBox();
            this.cbb_Tea = new System.Windows.Forms.ComboBox();
            this.chb_Tea = new System.Windows.Forms.CheckBox();
            this.chb_User = new System.Windows.Forms.CheckBox();
            this.cbb_Payway = new System.Windows.Forms.ComboBox();
            this.chb_Payway = new System.Windows.Forms.CheckBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.chb_OrderDate = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_User);
            this.groupBox1.Controls.Add(this.cbb_Tea);
            this.groupBox1.Controls.Add(this.chb_Tea);
            this.groupBox1.Controls.Add(this.chb_User);
            this.groupBox1.Controls.Add(this.cbb_Payway);
            this.groupBox1.Controls.Add(this.chb_Payway);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_BeginDate);
            this.groupBox1.Controls.Add(this.chb_OrderDate);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1296, 197);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbb_User
            // 
            this.cbb_User.FormattingEnabled = true;
            this.cbb_User.Location = new System.Drawing.Point(1070, 146);
            this.cbb_User.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbb_User.Name = "cbb_User";
            this.cbb_User.Size = new System.Drawing.Size(192, 51);
            this.cbb_User.TabIndex = 32;
            this.cbb_User.Text = "全部";
            // 
            // cbb_Tea
            // 
            this.cbb_Tea.FormattingEnabled = true;
            this.cbb_Tea.Location = new System.Drawing.Point(692, 144);
            this.cbb_Tea.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbb_Tea.Name = "cbb_Tea";
            this.cbb_Tea.Size = new System.Drawing.Size(148, 51);
            this.cbb_Tea.TabIndex = 31;
            this.cbb_Tea.Text = "全部";
            // 
            // chb_Tea
            // 
            this.chb_Tea.AutoSize = true;
            this.chb_Tea.Location = new System.Drawing.Point(466, 146);
            this.chb_Tea.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chb_Tea.Name = "chb_Tea";
            this.chb_Tea.Size = new System.Drawing.Size(223, 47);
            this.chb_Tea.TabIndex = 30;
            this.chb_Tea.Text = "饮品名称";
            this.chb_Tea.UseVisualStyleBackColor = true;
            // 
            // chb_User
            // 
            this.chb_User.AutoSize = true;
            this.chb_User.Location = new System.Drawing.Point(890, 149);
            this.chb_User.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chb_User.Name = "chb_User";
            this.chb_User.Size = new System.Drawing.Size(180, 47);
            this.chb_User.TabIndex = 28;
            this.chb_User.Text = "销售员";
            this.chb_User.UseVisualStyleBackColor = true;
            // 
            // cbb_Payway
            // 
            this.cbb_Payway.FormattingEnabled = true;
            this.cbb_Payway.Items.AddRange(new object[] {
            "全部",
            "现金",
            "银行卡",
            "支付宝",
            "微信"});
            this.cbb_Payway.Location = new System.Drawing.Point(240, 138);
            this.cbb_Payway.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbb_Payway.Name = "cbb_Payway";
            this.cbb_Payway.Size = new System.Drawing.Size(192, 51);
            this.cbb_Payway.TabIndex = 29;
            this.cbb_Payway.Text = "全部";
            // 
            // chb_Payway
            // 
            this.chb_Payway.AutoSize = true;
            this.chb_Payway.Location = new System.Drawing.Point(18, 141);
            this.chb_Payway.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chb_Payway.Name = "chb_Payway";
            this.chb_Payway.Size = new System.Drawing.Size(223, 47);
            this.chb_Payway.TabIndex = 27;
            this.chb_Payway.Text = "付款方式";
            this.chb_Payway.UseVisualStyleBackColor = true;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(856, 43);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(406, 56);
            this.dtp_EndDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "至";
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(283, 42);
            this.dtp_BeginDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(406, 56);
            this.dtp_BeginDate.TabIndex = 18;
            // 
            // chb_OrderDate
            // 
            this.chb_OrderDate.AutoSize = true;
            this.chb_OrderDate.Font = new System.Drawing.Font("宋体", 16F);
            this.chb_OrderDate.Location = new System.Drawing.Point(18, 48);
            this.chb_OrderDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chb_OrderDate.Name = "chb_OrderDate";
            this.chb_OrderDate.Size = new System.Drawing.Size(223, 47);
            this.chb_OrderDate.TabIndex = 7;
            this.chb_OrderDate.Text = "销售日期";
            this.chb_OrderDate.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Clear.Location = new System.Drawing.Point(1332, 160);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(356, 59);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清  空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Search.Location = new System.Drawing.Point(1332, 64);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(356, 57);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "生成报表";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(126, 356);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1537, 767);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            // 
            // Frm_BusinessChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 1212);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BusinessChart";
            this.Text = "业绩统计分析";
            this.Load += new System.EventHandler(this.Frm_BusinessChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.CheckBox chb_OrderDate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chb_Payway;
        private System.Windows.Forms.ComboBox cbb_Payway;
        private System.Windows.Forms.CheckBox chb_User;
        private System.Windows.Forms.CheckBox chb_Tea;
        private System.Windows.Forms.ComboBox cbb_Tea;
        private System.Windows.Forms.ComboBox cbb_User;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}