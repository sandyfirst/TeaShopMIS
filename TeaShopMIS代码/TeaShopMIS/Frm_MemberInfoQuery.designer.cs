namespace TeaShopMIS
{
    partial class Frm_MemberInfoQuery
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
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.chb_Telephone = new System.Windows.Forms.CheckBox();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.chb_MemberNumber = new System.Windows.Forms.CheckBox();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.chb_MemberName = new System.Windows.Forms.CheckBox();
            this.chb_Sex = new System.Windows.Forms.CheckBox();
            this.cbb_Sex = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_MemberInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(78, 48);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(109, 20);
            this.txt_Telephone.TabIndex = 17;
            // 
            // chb_Telephone
            // 
            this.chb_Telephone.AutoSize = true;
            this.chb_Telephone.Location = new System.Drawing.Point(9, 50);
            this.chb_Telephone.Name = "chb_Telephone";
            this.chb_Telephone.Size = new System.Drawing.Size(74, 17);
            this.chb_Telephone.TabIndex = 16;
            this.chb_Telephone.Text = "电话号码";
            this.chb_Telephone.UseVisualStyleBackColor = true;
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(289, 16);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(98, 20);
            this.txt_MemberNumber.TabIndex = 14;
            // 
            // chb_MemberNumber
            // 
            this.chb_MemberNumber.AutoSize = true;
            this.chb_MemberNumber.Location = new System.Drawing.Point(209, 18);
            this.chb_MemberNumber.Name = "chb_MemberNumber";
            this.chb_MemberNumber.Size = new System.Drawing.Size(74, 17);
            this.chb_MemberNumber.TabIndex = 13;
            this.chb_MemberNumber.Text = "会员卡号";
            this.chb_MemberNumber.UseVisualStyleBackColor = true;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(78, 16);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(109, 20);
            this.txt_MemberName.TabIndex = 11;
            // 
            // chb_MemberName
            // 
            this.chb_MemberName.AutoSize = true;
            this.chb_MemberName.Location = new System.Drawing.Point(9, 18);
            this.chb_MemberName.Name = "chb_MemberName";
            this.chb_MemberName.Size = new System.Drawing.Size(74, 17);
            this.chb_MemberName.TabIndex = 7;
            this.chb_MemberName.Text = "会员姓名";
            this.chb_MemberName.UseVisualStyleBackColor = true;
            // 
            // chb_Sex
            // 
            this.chb_Sex.AutoSize = true;
            this.chb_Sex.Location = new System.Drawing.Point(210, 50);
            this.chb_Sex.Name = "chb_Sex";
            this.chb_Sex.Size = new System.Drawing.Size(50, 17);
            this.chb_Sex.TabIndex = 5;
            this.chb_Sex.Text = "性别";
            this.chb_Sex.UseVisualStyleBackColor = true;
            // 
            // cbb_Sex
            // 
            this.cbb_Sex.FormattingEnabled = true;
            this.cbb_Sex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.cbb_Sex.Location = new System.Drawing.Point(266, 48);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(121, 21);
            this.cbb_Sex.TabIndex = 3;
            this.cbb_Sex.Text = "全部";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.chb_Telephone);
            this.groupBox1.Controls.Add(this.txt_MemberNumber);
            this.groupBox1.Controls.Add(this.chb_MemberNumber);
            this.groupBox1.Controls.Add(this.txt_MemberName);
            this.groupBox1.Controls.Add(this.chb_MemberName);
            this.groupBox1.Controls.Add(this.chb_Sex);
            this.groupBox1.Controls.Add(this.cbb_Sex);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 77);
            this.groupBox1.TabIndex = 35;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_MemberInfo);
            this.groupBox3.Location = new System.Drawing.Point(9, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 372);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "会员信息列表";
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
            this.lv_MemberInfo.Location = new System.Drawing.Point(3, 16);
            this.lv_MemberInfo.MultiSelect = false;
            this.lv_MemberInfo.Name = "lv_MemberInfo";
            this.lv_MemberInfo.Size = new System.Drawing.Size(711, 353);
            this.lv_MemberInfo.TabIndex = 3;
            this.lv_MemberInfo.UseCompatibleStateImageBehavior = false;
            this.lv_MemberInfo.View = System.Windows.Forms.View.Details;
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
            // Frm_MemberInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Frm_MemberInfoQuery";
            this.Text = "会员信息查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.CheckBox chb_Telephone;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.CheckBox chb_MemberNumber;
        private System.Windows.Forms.TextBox txt_MemberName;
        private System.Windows.Forms.CheckBox chb_MemberName;
        private System.Windows.Forms.CheckBox chb_Sex;
        private System.Windows.Forms.ComboBox cbb_Sex;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_MemberInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}