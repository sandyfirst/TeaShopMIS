namespace TeaShopMIS
{
    partial class Frm_UserInfoManage
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtn_Status2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Status1 = new System.Windows.Forms.RadioButton();
            this.cbox_UserType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ReSetPassword = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_UserInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_RealName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "类别";
            // 
            // rbtn_Status2
            // 
            this.rbtn_Status2.AutoSize = true;
            this.rbtn_Status2.Location = new System.Drawing.Point(606, 326);
            this.rbtn_Status2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtn_Status2.Name = "rbtn_Status2";
            this.rbtn_Status2.Size = new System.Drawing.Size(147, 52);
            this.rbtn_Status2.TabIndex = 5;
            this.rbtn_Status2.Text = "禁用";
            this.rbtn_Status2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Status1
            // 
            this.rbtn_Status1.AutoSize = true;
            this.rbtn_Status1.Checked = true;
            this.rbtn_Status1.Location = new System.Drawing.Point(347, 326);
            this.rbtn_Status1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtn_Status1.Name = "rbtn_Status1";
            this.rbtn_Status1.Size = new System.Drawing.Size(147, 52);
            this.rbtn_Status1.TabIndex = 4;
            this.rbtn_Status1.TabStop = true;
            this.rbtn_Status1.Text = "启用";
            this.rbtn_Status1.UseVisualStyleBackColor = true;
            // 
            // cbox_UserType
            // 
            this.cbox_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_UserType.FormattingEnabled = true;
            this.cbox_UserType.Items.AddRange(new object[] {
            "职员",
            "经理"});
            this.cbox_UserType.Location = new System.Drawing.Point(1181, 262);
            this.cbox_UserType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbox_UserType.Name = "cbox_UserType";
            this.cbox_UserType.Size = new System.Drawing.Size(330, 56);
            this.cbox_UserType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 48);
            this.label6.TabIndex = 29;
            this.label6.Text = "状  态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 48);
            this.label2.TabIndex = 27;
            this.label2.Text = "用户类别：";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(1181, 118);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(330, 62);
            this.txt_Password.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(896, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 48);
            this.label4.TabIndex = 25;
            this.label4.Text = "密  码：";
            // 
            // btn_ReSetPassword
            // 
            this.btn_ReSetPassword.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_ReSetPassword.Location = new System.Drawing.Point(852, 0);
            this.btn_ReSetPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ReSetPassword.Name = "btn_ReSetPassword";
            this.btn_ReSetPassword.Size = new System.Drawing.Size(150, 58);
            this.btn_ReSetPassword.TabIndex = 30;
            this.btn_ReSetPassword.Text = "重置密码";
            this.btn_ReSetPassword.UseVisualStyleBackColor = true;
            this.btn_ReSetPassword.Click += new System.EventHandler(this.btn_ReSetPassword_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_Del.Location = new System.Drawing.Point(677, 0);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(163, 58);
            this.btn_Del.TabIndex = 31;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ReSetPassword);
            this.groupBox2.Controls.Add(this.lv_UserInfo);
            this.groupBox2.Controls.Add(this.btn_Disable);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_Enable);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 18F);
            this.groupBox2.Location = new System.Drawing.Point(52, 632);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1703, 550);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息列表";
            // 
            // lv_UserInfo
            // 
            this.lv_UserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_UserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_UserInfo.FullRowSelect = true;
            this.lv_UserInfo.GridLines = true;
            this.lv_UserInfo.HideSelection = false;
            this.lv_UserInfo.Location = new System.Drawing.Point(6, 61);
            this.lv_UserInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lv_UserInfo.MultiSelect = false;
            this.lv_UserInfo.Name = "lv_UserInfo";
            this.lv_UserInfo.Size = new System.Drawing.Size(1691, 483);
            this.lv_UserInfo.TabIndex = 0;
            this.lv_UserInfo.UseCompatibleStateImageBehavior = false;
            this.lv_UserInfo.View = System.Windows.Forms.View.Details;
            this.lv_UserInfo.SelectedIndexChanged += new System.EventHandler(this.lv_UserInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "用户名";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "密码";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "姓名";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            this.columnHeader6.Width = 55;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("宋体", 18F);
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(397, 565);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(212, 48);
            this.lbl_Note.TabIndex = 34;
            this.lbl_Note.Text = "结果提示";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(574, 0);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(116, 48);
            this.lbl_Status.TabIndex = 24;
            this.lbl_Status.Text = "添加";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1042, 416);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(202, 61);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(347, 416);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(204, 61);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "保  存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_RealName
            // 
            this.txt_RealName.Location = new System.Drawing.Point(347, 221);
            this.txt_RealName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_RealName.Name = "txt_RealName";
            this.txt_RealName.Size = new System.Drawing.Size(406, 62);
            this.txt_RealName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓  名：";
            // 
            // btn_Disable
            // 
            this.btn_Disable.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_Disable.Location = new System.Drawing.Point(517, 0);
            this.btn_Disable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(148, 58);
            this.btn_Disable.TabIndex = 29;
            this.btn_Disable.Text = "禁用";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(347, 118);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(406, 62);
            this.txt_UserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // btn_Enable
            // 
            this.btn_Enable.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_Enable.Location = new System.Drawing.Point(353, 0);
            this.btn_Enable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(152, 58);
            this.btn_Enable.TabIndex = 28;
            this.btn_Enable.Text = "启用";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Status2);
            this.groupBox1.Controls.Add(this.rbtn_Status1);
            this.groupBox1.Controls.Add(this.cbox_UserType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_RealName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 18F);
            this.groupBox1.Location = new System.Drawing.Point(58, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1697, 512);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑员工信息 当前操作：";
            // 
            // Frm_UserInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 1212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_UserInfoManage";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_UserInfoManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RadioButton rbtn_Status2;
        private System.Windows.Forms.RadioButton rbtn_Status1;
        private System.Windows.Forms.ComboBox cbox_UserType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ReSetPassword;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_UserInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_RealName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}