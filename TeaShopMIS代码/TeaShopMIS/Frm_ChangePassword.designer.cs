namespace TeaShopMIS
{
    partial class Frm_ChangePassword
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
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NewPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NewPassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Font = new System.Drawing.Font("宋体", 18F);
            this.txt_OldPassword.Location = new System.Drawing.Point(851, 257);
            this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.PasswordChar = '*';
            this.txt_OldPassword.Size = new System.Drawing.Size(425, 62);
            this.txt_OldPassword.TabIndex = 28;
            this.txt_OldPassword.TextChanged += new System.EventHandler(this.txt_OldPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(531, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 48);
            this.label4.TabIndex = 31;
            this.label4.Text = "原密码：";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Clear.Location = new System.Drawing.Point(1019, 753);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(257, 84);
            this.btn_Clear.TabIndex = 30;
            this.btn_Clear.Text = "清  空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Save.Location = new System.Drawing.Point(539, 753);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(260, 85);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "修改密码";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("宋体", 18F);
            this.txt_UserName.Location = new System.Drawing.Point(851, 164);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(425, 62);
            this.txt_UserName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(531, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 27;
            this.label1.Text = "用户名：";
            // 
            // txt_NewPassword2
            // 
            this.txt_NewPassword2.Font = new System.Drawing.Font("宋体", 18F);
            this.txt_NewPassword2.Location = new System.Drawing.Point(851, 444);
            this.txt_NewPassword2.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NewPassword2.Name = "txt_NewPassword2";
            this.txt_NewPassword2.PasswordChar = '*';
            this.txt_NewPassword2.Size = new System.Drawing.Size(425, 62);
            this.txt_NewPassword2.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F);
            this.label2.Location = new System.Drawing.Point(531, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 48);
            this.label2.TabIndex = 33;
            this.label2.Text = "确认新密码：";
            // 
            // txt_NewPassword1
            // 
            this.txt_NewPassword1.Font = new System.Drawing.Font("宋体", 18F);
            this.txt_NewPassword1.Location = new System.Drawing.Point(851, 348);
            this.txt_NewPassword1.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NewPassword1.Name = "txt_NewPassword1";
            this.txt_NewPassword1.PasswordChar = '*';
            this.txt_NewPassword1.Size = new System.Drawing.Size(425, 62);
            this.txt_NewPassword1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F);
            this.label3.Location = new System.Drawing.Point(531, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 35;
            this.label3.Text = "新密码：";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(535, 604);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(191, 43);
            this.lbl_Note.TabIndex = 36;
            this.lbl_Note.Text = "提示信息";
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 1212);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.txt_NewPassword1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NewPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_ChangePassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Frm_ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NewPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NewPassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Note;
    }
}