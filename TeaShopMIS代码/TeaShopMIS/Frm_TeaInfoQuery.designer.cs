namespace TeaShopMIS
{
    partial class Frm_TeaInfoQuery
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_TeaInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.chb_Status = new System.Windows.Forms.CheckBox();
            this.chb_Price_Small = new System.Windows.Forms.CheckBox();
            this.cbb_Price_Small = new System.Windows.Forms.ComboBox();
            this.txt_Price_Small = new System.Windows.Forms.TextBox();
            this.cbb_Price_Medium = new System.Windows.Forms.ComboBox();
            this.chb_Price_Medium = new System.Windows.Forms.CheckBox();
            this.txt_Price_Medium = new System.Windows.Forms.TextBox();
            this.txt_Price_Large = new System.Windows.Forms.TextBox();
            this.chb_Price_Large = new System.Windows.Forms.CheckBox();
            this.cbb_Price_Large = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_TeaInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 372);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "饮品信息列表";
            // 
            // lv_TeaInfo
            // 
            this.lv_TeaInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader8});
            this.lv_TeaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_TeaInfo.FullRowSelect = true;
            this.lv_TeaInfo.GridLines = true;
            this.lv_TeaInfo.Location = new System.Drawing.Point(3, 16);
            this.lv_TeaInfo.MultiSelect = false;
            this.lv_TeaInfo.Name = "lv_TeaInfo";
            this.lv_TeaInfo.Size = new System.Drawing.Size(711, 353);
            this.lv_TeaInfo.TabIndex = 8;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "饮品名称";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格(小)";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "价格(中)";
            this.columnHeader6.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "价格(大)";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "状态";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "图片";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Price_Large);
            this.groupBox1.Controls.Add(this.chb_Price_Large);
            this.groupBox1.Controls.Add(this.cbb_Price_Large);
            this.groupBox1.Controls.Add(this.txt_Price_Medium);
            this.groupBox1.Controls.Add(this.chb_Price_Medium);
            this.groupBox1.Controls.Add(this.cbb_Price_Medium);
            this.groupBox1.Controls.Add(this.txt_Price_Small);
            this.groupBox1.Controls.Add(this.chb_Price_Small);
            this.groupBox1.Controls.Add(this.cbb_Price_Small);
            this.groupBox1.Controls.Add(this.chb_Status);
            this.groupBox1.Controls.Add(this.cbb_Status);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 77);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(484, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 43);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "查  询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(584, 22);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 43);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清  空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cbb_Status
            // 
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "全部",
            "在售",
            "售完",
            "停售"});
            this.cbb_Status.Location = new System.Drawing.Point(266, 48);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(121, 21);
            this.cbb_Status.TabIndex = 3;
            this.cbb_Status.Text = "全部";
            // 
            // chb_Status
            // 
            this.chb_Status.AutoSize = true;
            this.chb_Status.Location = new System.Drawing.Point(210, 50);
            this.chb_Status.Name = "chb_Status";
            this.chb_Status.Size = new System.Drawing.Size(50, 17);
            this.chb_Status.TabIndex = 5;
            this.chb_Status.Text = "状态";
            this.chb_Status.UseVisualStyleBackColor = true;
            // 
            // chb_Price_Small
            // 
            this.chb_Price_Small.AutoSize = true;
            this.chb_Price_Small.Location = new System.Drawing.Point(9, 18);
            this.chb_Price_Small.Name = "chb_Price_Small";
            this.chb_Price_Small.Size = new System.Drawing.Size(68, 17);
            this.chb_Price_Small.TabIndex = 7;
            this.chb_Price_Small.Text = "价格(小)";
            this.chb_Price_Small.UseVisualStyleBackColor = true;
            // 
            // cbb_Price_Small
            // 
            this.cbb_Price_Small.FormattingEnabled = true;
            this.cbb_Price_Small.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Small.Location = new System.Drawing.Point(78, 16);
            this.cbb_Price_Small.Name = "cbb_Price_Small";
            this.cbb_Price_Small.Size = new System.Drawing.Size(37, 21);
            this.cbb_Price_Small.TabIndex = 6;
            this.cbb_Price_Small.Text = "=";
            // 
            // txt_Price_Small
            // 
            this.txt_Price_Small.Location = new System.Drawing.Point(116, 16);
            this.txt_Price_Small.Name = "txt_Price_Small";
            this.txt_Price_Small.Size = new System.Drawing.Size(71, 20);
            this.txt_Price_Small.TabIndex = 11;
            // 
            // cbb_Price_Medium
            // 
            this.cbb_Price_Medium.FormattingEnabled = true;
            this.cbb_Price_Medium.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Medium.Location = new System.Drawing.Point(278, 16);
            this.cbb_Price_Medium.Name = "cbb_Price_Medium";
            this.cbb_Price_Medium.Size = new System.Drawing.Size(37, 21);
            this.cbb_Price_Medium.TabIndex = 12;
            this.cbb_Price_Medium.Text = "=";
            // 
            // chb_Price_Medium
            // 
            this.chb_Price_Medium.AutoSize = true;
            this.chb_Price_Medium.Location = new System.Drawing.Point(209, 18);
            this.chb_Price_Medium.Name = "chb_Price_Medium";
            this.chb_Price_Medium.Size = new System.Drawing.Size(68, 17);
            this.chb_Price_Medium.TabIndex = 13;
            this.chb_Price_Medium.Text = "价格(中)";
            this.chb_Price_Medium.UseVisualStyleBackColor = true;
            // 
            // txt_Price_Medium
            // 
            this.txt_Price_Medium.Location = new System.Drawing.Point(316, 16);
            this.txt_Price_Medium.Name = "txt_Price_Medium";
            this.txt_Price_Medium.Size = new System.Drawing.Size(71, 20);
            this.txt_Price_Medium.TabIndex = 14;
            // 
            // txt_Price_Large
            // 
            this.txt_Price_Large.Location = new System.Drawing.Point(116, 48);
            this.txt_Price_Large.Name = "txt_Price_Large";
            this.txt_Price_Large.Size = new System.Drawing.Size(71, 20);
            this.txt_Price_Large.TabIndex = 17;
            // 
            // chb_Price_Large
            // 
            this.chb_Price_Large.AutoSize = true;
            this.chb_Price_Large.Location = new System.Drawing.Point(9, 50);
            this.chb_Price_Large.Name = "chb_Price_Large";
            this.chb_Price_Large.Size = new System.Drawing.Size(68, 17);
            this.chb_Price_Large.TabIndex = 16;
            this.chb_Price_Large.Text = "价格(大)";
            this.chb_Price_Large.UseVisualStyleBackColor = true;
            // 
            // cbb_Price_Large
            // 
            this.cbb_Price_Large.FormattingEnabled = true;
            this.cbb_Price_Large.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Large.Location = new System.Drawing.Point(78, 48);
            this.cbb_Price_Large.Name = "cbb_Price_Large";
            this.cbb_Price_Large.Size = new System.Drawing.Size(37, 21);
            this.cbb_Price_Large.TabIndex = 15;
            this.cbb_Price_Large.Text = "=";
            // 
            // Frm_TeaInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Frm_TeaInfoQuery";
            this.Text = "饮品信息查询";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_TeaInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.TextBox txt_Price_Small;
        private System.Windows.Forms.CheckBox chb_Price_Small;
        private System.Windows.Forms.ComboBox cbb_Price_Small;
        private System.Windows.Forms.CheckBox chb_Status;
        private System.Windows.Forms.TextBox txt_Price_Large;
        private System.Windows.Forms.CheckBox chb_Price_Large;
        private System.Windows.Forms.ComboBox cbb_Price_Large;
        private System.Windows.Forms.TextBox txt_Price_Medium;
        private System.Windows.Forms.CheckBox chb_Price_Medium;
        private System.Windows.Forms.ComboBox cbb_Price_Medium;
    }
}