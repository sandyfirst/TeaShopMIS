namespace TeaShopMIS
{
    partial class Frm_MemberInfoManage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.lv_MemberInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Status1 = new System.Windows.Forms.RadioButton();
            this.rbtn_Status2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_Enable);
            this.groupBox2.Controls.Add(this.lv_MemberInfo);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox2.Location = new System.Drawing.Point(367, 681);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1145, 535);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息列表";
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Del.Location = new System.Drawing.Point(637, -4);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(229, 57);
            this.btn_Del.TabIndex = 36;
            this.btn_Del.Text = "删  除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Enable
            // 
            this.btn_Enable.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Enable.Location = new System.Drawing.Point(350, -4);
            this.btn_Enable.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(227, 57);
            this.btn_Enable.TabIndex = 40;
            this.btn_Enable.Text = "设为正常";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // lv_MemberInfo
            // 
            this.lv_MemberInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader10});
            this.lv_MemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_MemberInfo.FullRowSelect = true;
            this.lv_MemberInfo.GridLines = true;
            this.lv_MemberInfo.HideSelection = false;
            this.lv_MemberInfo.Location = new System.Drawing.Point(6, 55);
            this.lv_MemberInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lv_MemberInfo.MultiSelect = false;
            this.lv_MemberInfo.Name = "lv_MemberInfo";
            this.lv_MemberInfo.Size = new System.Drawing.Size(1133, 474);
            this.lv_MemberInfo.TabIndex = 2;
            this.lv_MemberInfo.UseCompatibleStateImageBehavior = false;
            this.lv_MemberInfo.View = System.Windows.Forms.View.Details;
            this.lv_MemberInfo.SelectedIndexChanged += new System.EventHandler(this.lv_MemberInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "会员姓名";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "会员卡号";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "性别";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "电话";
            this.columnHeader11.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "状态";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "备注";
            this.columnHeader10.Width = 40;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(555, 437);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 46);
            this.panel1.TabIndex = 130;
            // 
            // rbtn_Status1
            // 
            this.rbtn_Status1.AutoSize = true;
            this.rbtn_Status1.Checked = true;
            this.rbtn_Status1.Location = new System.Drawing.Point(250, 238);
            this.rbtn_Status1.Margin = new System.Windows.Forms.Padding(6);
            this.rbtn_Status1.Name = "rbtn_Status1";
            this.rbtn_Status1.Size = new System.Drawing.Size(136, 47);
            this.rbtn_Status1.TabIndex = 127;
            this.rbtn_Status1.TabStop = true;
            this.rbtn_Status1.Text = "正常";
            this.rbtn_Status1.UseVisualStyleBackColor = true;
            // 
            // rbtn_Status2
            // 
            this.rbtn_Status2.AutoSize = true;
            this.rbtn_Status2.Location = new System.Drawing.Point(420, 238);
            this.rbtn_Status2.Margin = new System.Windows.Forms.Padding(6);
            this.rbtn_Status2.Name = "rbtn_Status2";
            this.rbtn_Status2.Size = new System.Drawing.Size(136, 47);
            this.rbtn_Status2.TabIndex = 128;
            this.rbtn_Status2.Text = "删除";
            this.rbtn_Status2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 129;
            this.label1.Text = "状态：";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(804, 226);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(294, 56);
            this.txt_Remark.TabIndex = 125;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(644, 238);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(148, 43);
            this.label30.TabIndex = 126;
            this.label30.Text = "备注：";
            // 
            // label26
            // 
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(209, 456);
            this.label26.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(295, 49);
            this.label26.TabIndex = 124;
            this.label26.Text = "*";
            // 
            // label29
            // 
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(362, 37);
            this.label29.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 24);
            this.label29.TabIndex = 123;
            this.label29.Text = "*";
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(756, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 120;
            this.label10.Text = "*";
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(965, 153);
            this.rbtn_Sex2.Margin = new System.Windows.Forms.Padding(6);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(93, 47);
            this.rbtn_Sex2.TabIndex = 114;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Checked = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(804, 157);
            this.rbtn_Sex1.Margin = new System.Windows.Forms.Padding(6);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(93, 47);
            this.rbtn_Sex1.TabIndex = 112;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(250, 72);
            this.txt_MemberNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(306, 56);
            this.txt_MemberNumber.TabIndex = 111;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 85);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(234, 43);
            this.label22.TabIndex = 119;
            this.label22.Text = "会员卡号：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(644, 157);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(148, 43);
            this.label23.TabIndex = 118;
            this.label23.Text = "性别：";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(250, 144);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(306, 56);
            this.txt_Telephone.TabIndex = 109;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(12, 456);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(191, 43);
            this.lbl_Note.TabIndex = 39;
            this.lbl_Note.Text = "结果提示";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(28, 157);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(148, 43);
            this.label27.TabIndex = 113;
            this.label27.Text = "电话：";
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(804, 72);
            this.txt_MemberName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(294, 56);
            this.txt_MemberName.TabIndex = 107;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(644, 75);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(148, 43);
            this.label28.TabIndex = 108;
            this.label28.Text = "姓名：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(451, 0);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(105, 43);
            this.lbl_Status.TabIndex = 24;
            this.lbl_Status.Text = "添加";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(652, 336);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(193, 66);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(308, 336);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(192, 68);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "保  存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.rbtn_Status2);
            this.groupBox1.Controls.Add(this.rbtn_Status1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_Remark);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lbl_Note);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbtn_Sex2);
            this.groupBox1.Controls.Add(this.rbtn_Sex1);
            this.groupBox1.Controls.Add(this.txt_MemberNumber);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txt_MemberName);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox1.Location = new System.Drawing.Point(367, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1145, 505);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑会员信息  状态：";
            // 
            // Frm_MemberInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 1212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_MemberInfoManage";
            this.Text = "会员信息管理";
            this.Load += new System.EventHandler(this.Frm_MemberInfoManage_Load);
            this.Click += new System.EventHandler(this.Frm_MemberInfoManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_MemberInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_Status1;
        private System.Windows.Forms.RadioButton rbtn_Status2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_MemberName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btn_Enable;
    }
}