using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_ChangePassword : Form
    {
        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            //txt_UserName.Text = ConfigurationManager.AppSettings["UserName"]; //获取配置文件中的当前用户名
            txt_UserName.Text = System.Configuration.ConfigurationSettings.AppSettings["UserName"];
        }


        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_OldPassword.Text = "";
            txt_NewPassword2.Text = "";
            txt_NewPassword1.Text = "";
        }


        //保存
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_OldPassword.Text.Trim() == "")
            {
                lbl_Note.Text = "请输入原密码！";
                txt_OldPassword.Focus();
            }
            else if (txt_NewPassword1.Text.Trim()=="")
            {
                lbl_Note.Text = "请输入新密码！";
                txt_NewPassword1.Focus();
            }
            else if (txt_NewPassword2.Text.Trim() == "")
            {
                lbl_Note.Text = "请输入确认新密码！";
                txt_NewPassword2.Focus();
            }
            else if (txt_NewPassword1.Text.Trim() != txt_NewPassword2.Text.Trim())
            {
                lbl_Note.Text = "两次输入的新密码不一致，请重新输入！";
                txt_NewPassword2.Focus();
            }
            else
            {
                string sqlstr = string.Format("select * from User_Info where UserName='{0}' and Password = '{1}'", txt_UserName.Text, txt_OldPassword.Text);
                DataTable dt = DataWork.DataQuery(sqlstr);

                if (dt.Rows.Count == 0)
                {
                    lbl_Note.Text = "原密码错误，请重新输入！";
                    txt_OldPassword.Focus();
                }
                else
                {
                    string sqlstr2 = string.Format("update User_Info set Password = '{0}' where UserName='{1}'",txt_NewPassword1.Text, txt_UserName.Text);

                    int i = DataWork.DataExecute(sqlstr2);

                    if (i > 0)
                    {
                        lbl_Note.Text = "密码修改成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        txt_OldPassword.Text = "";
                        txt_NewPassword1.Text = "";
                        txt_NewPassword2.Text = "";
                    }
                    else
                    {
                        lbl_Note.Text = "密码修改失败";
                    }
                }

            }

        }

        private void txt_OldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
