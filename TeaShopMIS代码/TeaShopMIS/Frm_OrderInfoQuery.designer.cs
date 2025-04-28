namespace TeaShopMIS
{
    partial class Frm_OrderInfoQuery
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
            this.lv_OrderInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.chb_MemberNumber = new System.Windows.Forms.CheckBox();
            this.chb_OrderDate = new System.Windows.Forms.CheckBox();
            this.chb_Payway = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.cbb_Payway = new System.Windows.Forms.ComboBox();
            this.cbb_Tea = new System.Windows.Forms.ComboBox();
            this.chb_Tea = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_OrderInfo
            // 
            this.lv_OrderInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.lv_OrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_OrderInfo.FullRowSelect = true;
            this.lv_OrderInfo.GridLines = true;
            this.lv_OrderInfo.Location = new System.Drawing.Point(3, 16);
            this.lv_OrderInfo.MultiSelect = false;
            this.lv_OrderInfo.Name = "lv_OrderInfo";
            this.lv_OrderInfo.Size = new System.Drawing.Size(711, 353);
            this.lv_OrderInfo.TabIndex = 3;
            this.lv_OrderInfo.UseCompatibleStateImageBehavior = false;
            this.lv_OrderInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "订单编号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "会员卡号";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "订单内容";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "饮品数量";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "订单金额";
            this.columnHeader11.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "折扣比例";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "折扣金额";
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(408, 51);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(98, 20);
            this.txt_MemberNumber.TabIndex = 14;
            // 
            // chb_MemberNumber
            // 
            this.chb_MemberNumber.AutoSize = true;
            this.chb_MemberNumber.Location = new System.Drawing.Point(338, 53);
            this.chb_MemberNumber.Name = "chb_MemberNumber";
            this.chb_MemberNumber.Size = new System.Drawing.Size(74, 17);
            this.chb_MemberNumber.TabIndex = 13;
            this.chb_MemberNumber.Text = "会员卡号";
            this.chb_MemberNumber.UseVisualStyleBackColor = true;
            // 
            // chb_OrderDate
            // 
            this.chb_OrderDate.AutoSize = true;
            this.chb_OrderDate.Location = new System.Drawing.Point(9, 20);
            this.chb_OrderDate.Name = "chb_OrderDate";
            this.chb_OrderDate.Size = new System.Drawing.Size(74, 17);
            this.chb_OrderDate.TabIndex = 7;
            this.chb_OrderDate.Text = "销售日期";
            this.chb_OrderDate.UseVisualStyleBackColor = true;
            // 
            // chb_Payway
            // 
            this.chb_Payway.AutoSize = true;
            this.chb_Payway.Location = new System.Drawing.Point(338, 21);
            this.chb_Payway.Name = "chb_Payway";
            this.chb_Payway.Size = new System.Drawing.Size(74, 17);
            this.chb_Payway.TabIndex = 5;
            this.chb_Payway.Text = "付款方式";
            this.chb_Payway.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(631, 21);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 43);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清  空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Tea);
            this.groupBox1.Controls.Add(this.chb_Tea);
            this.groupBox1.Controls.Add(this.cbb_Payway);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Controls.Add(this.txt_MemberNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chb_MemberNumber);
            this.groupBox1.Controls.Add(this.dtp_BeginDate);
            this.groupBox1.Controls.Add(this.chb_OrderDate);
            this.groupBox1.Controls.Add(this.chb_Payway);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 77);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(531, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 43);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "查  询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_OrderInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 372);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "营业信息列表";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "实收金额";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "支付方式";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "销售日期";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "操作员";
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(79, 18);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(108, 20);
            this.dtp_BeginDate.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "至";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(218, 18);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(108, 20);
            this.dtp_EndDate.TabIndex = 20;
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
            this.cbb_Payway.Location = new System.Drawing.Point(408, 19);
            this.cbb_Payway.Name = "cbb_Payway";
            this.cbb_Payway.Size = new System.Drawing.Size(98, 21);
            this.cbb_Payway.TabIndex = 22;
            this.cbb_Payway.Text = "全部";
            // 
            // cbb_Tea
            // 
            this.cbb_Tea.FormattingEnabled = true;
            this.cbb_Tea.Location = new System.Drawing.Point(79, 49);
            this.cbb_Tea.Name = "cbb_Tea";
            this.cbb_Tea.Size = new System.Drawing.Size(247, 21);
            this.cbb_Tea.TabIndex = 24;
            this.cbb_Tea.Text = "全部";
            // 
            // chb_Tea
            // 
            this.chb_Tea.AutoSize = true;
            this.chb_Tea.Location = new System.Drawing.Point(9, 51);
            this.chb_Tea.Name = "chb_Tea";
            this.chb_Tea.Size = new System.Drawing.Size(74, 17);
            this.chb_Tea.TabIndex = 23;
            this.chb_Tea.Text = "饮品名称";
            this.chb_Tea.UseVisualStyleBackColor = true;
            // 
            // Frm_OrderInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Frm_OrderInfoQuery";
            this.Text = "营业信息查询";
            this.Load += new System.EventHandler(this.Frm_OrderInfoQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_OrderInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.CheckBox chb_MemberNumber;
        private System.Windows.Forms.CheckBox chb_OrderDate;
        private System.Windows.Forms.CheckBox chb_Payway;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.ComboBox cbb_Payway;
        private System.Windows.Forms.ComboBox cbb_Tea;
        private System.Windows.Forms.CheckBox chb_Tea;
    }
}