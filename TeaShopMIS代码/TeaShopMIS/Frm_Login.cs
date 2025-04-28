using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Configuration;

namespace TeaShopMIS
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.Size = new Size(900, 600);
        }




        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = StringFilter(txt_UserName.Text);
            string password = StringFilter(txt_Password.Text);

            if (username == "")
            {

                lbl_Note.Text = "帐号不能为空!";
                txt_UserName.Text = "";
                txt_UserName.Focus();
            }
            else if (password == "")
            {
                lbl_Note.Text = "密码不能为空!";
                txt_Password.Text = "";
                txt_Password.Focus();
            }
            else
            {
                //1 SQL查询语句
                string sqlstr = string.Format("select * from User_Info where UserName='{0}'", username);

                //2 调用DataWork中的DataQuery函数，执行数据查询
                DataTable dt = DataWork.DataQuery(sqlstr);

                //3处理结果
                if (dt.Rows.Count == 0)
                {
                    lbl_Note.Text = "对不起，帐号不存在！";
                    txt_UserName.Focus();
                }
                else if (dt.Rows[0]["Password"].ToString() != password)
                {
                    lbl_Note.Text = "对不起，密码不正确！";
                    txt_Password.Focus();
                }
                else if (dt.Rows[0]["Status"].ToString() != "1")
                {
                    lbl_Note.Text = "该用户状态已经失效，请联系系统管理员！";
                }
                else
                {
                    Frm_Main frm = new Frm_Main();

                    ConfigurationManager.AppSettings["UserID"] = dt.Rows[0]["UserID"].ToString();
                    ConfigurationManager.AppSettings["UserName"] = dt.Rows[0]["UserName"].ToString();
                    ConfigurationManager.AppSettings["RealName"] = dt.Rows[0]["RealName"].ToString();

                    frm.Show();
                    this.Hide();
                }

            }
            //Frm_Main frm = new Frm_Main();
            //frm.Show();
            //this.Hide();
        }

        //过滤非法字符
        protected string StringFilter(string str)
        {
            
            str = str.Replace(" or ", "");
            str = str.Replace(" and ", "");
            str = str.Replace("--", "");
            str = str.Replace("_", "");
            str = str.Replace("//", "");
            str = str.Replace(" ", "");
            return str;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
