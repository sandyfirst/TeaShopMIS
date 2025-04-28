namespace TeaShopMIS
{
    partial class Frm_TeaPriceManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_TeaPrice = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Price_Large = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Price_Medium = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price_Small = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TeaName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_TeaInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 450);
            this.groupBox3.TabIndex = 31;
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
            this.lv_TeaInfo.Size = new System.Drawing.Size(324, 431);
            this.lv_TeaInfo.TabIndex = 8;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.View = System.Windows.Forms.View.Details;
            this.lv_TeaInfo.SelectedIndexChanged += new System.EventHandler(this.lv_TeaInfo_SelectedIndexChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_TeaPrice);
            this.groupBox1.Location = new System.Drawing.Point(348, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 232);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "饮品价格列表";
            // 
            // lv_TeaPrice
            // 
            this.lv_TeaPrice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lv_TeaPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_TeaPrice.FullRowSelect = true;
            this.lv_TeaPrice.GridLines = true;
            this.lv_TeaPrice.Location = new System.Drawing.Point(3, 16);
            this.lv_TeaPrice.MultiSelect = false;
            this.lv_TeaPrice.Name = "lv_TeaPrice";
            this.lv_TeaPrice.Size = new System.Drawing.Size(375, 213);
            this.lv_TeaPrice.TabIndex = 8;
            this.lv_TeaPrice.UseCompatibleStateImageBehavior = false;
            this.lv_TeaPrice.View = System.Windows.Forms.View.Details;
            this.lv_TeaPrice.SelectedIndexChanged += new System.EventHandler(this.lv_TeaPrice_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No";
            this.columnHeader7.Width = 30;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "价格(小)";
            this.columnHeader9.Width = 55;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "价格(中)";
            this.columnHeader10.Width = 55;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "价格(大)";
            this.columnHeader11.Width = 55;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "生效日期";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "失效日期";
            this.columnHeader13.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Note);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dtp_EndDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_BeginDate);
            this.groupBox2.Controls.Add(this.txt_Price_Large);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Price_Medium);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Price_Small);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_TeaName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.lbl_Operation);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 212);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑饮品价格    当前操作：";
            // 
            // txt_Price_Large
            // 
            this.txt_Price_Large.Location = new System.Drawing.Point(80, 100);
            this.txt_Price_Large.Name = "txt_Price_Large";
            this.txt_Price_Large.Size = new System.Drawing.Size(60, 20);
            this.txt_Price_Large.TabIndex = 3;
            this.txt_Price_Large.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "(大份)";
            // 
            // txt_Price_Medium
            // 
            this.txt_Price_Medium.Location = new System.Drawing.Point(80, 75);
            this.txt_Price_Medium.Name = "txt_Price_Medium";
            this.txt_Price_Medium.Size = new System.Drawing.Size(60, 20);
            this.txt_Price_Medium.TabIndex = 1;
            this.txt_Price_Medium.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "(中份)";
            // 
            // txt_Price_Small
            // 
            this.txt_Price_Small.Location = new System.Drawing.Point(80, 50);
            this.txt_Price_Small.Name = "txt_Price_Small";
            this.txt_Price_Small.Size = new System.Drawing.Size(60, 20);
            this.txt_Price_Small.TabIndex = 2;
            this.txt_Price_Small.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "饮品价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "生效日期：";
            // 
            // txt_TeaName
            // 
            this.txt_TeaName.Location = new System.Drawing.Point(80, 25);
            this.txt_TeaName.Name = "txt_TeaName";
            this.txt_TeaName.ReadOnly = true;
            this.txt_TeaName.Size = new System.Drawing.Size(131, 20);
            this.txt_TeaName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "(正常/小份)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "饮品名称：";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1034, 243);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "客户信息列表";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(131, 179);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "重置";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(26, 179);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 25);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.Location = new System.Drawing.Point(151, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(31, 13);
            this.lbl_Operation.TabIndex = 7;
            this.lbl_Operation.Text = "添加";
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(80, 126);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(131, 20);
            this.dtp_BeginDate.TabIndex = 96;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(78, 153);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(131, 20);
            this.dtp_EndDate.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "失效日期：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "图片";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(214, 185);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(55, 13);
            this.lbl_Note.TabIndex = 100;
            this.lbl_Note.Text = "提示信息";
            // 
            // Frm_TeaPriceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Frm_TeaPriceManage";
            this.Text = "饮品价格管理";
            this.Load += new System.EventHandler(this.Frm_TeaPriceManage_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_TeaPrice;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.TextBox txt_Price_Large;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Price_Medium;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Price_Small;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TeaName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lbl_Note;
    }
}