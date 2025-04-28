using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_UserInfoManage : Form
    {
        public Frm_UserInfoManage()
        {
            InitializeComponent();
        }

        string userid = "";  //全局变量，用于存储员工编号

        //窗体加载事件
        private void Frm_UserInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_UserInfo(); //加载员工信息
        }


        //加载员工信息
        protected void DataBind_UserInfo()
        {
            //SQL查询语句
            string sqlstr = "select * from User_Info";

            //调用业务逻辑对象的方法
            DataTable dt = DataWork.DataQuery(sqlstr);

            lv_UserInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["UserID"].ToString());  //创建一个ListViewItem项，并为第1列赋值，员工编号
                myitem.SubItems.Add(dr["UserName"].ToString());  //第2列，帐号
                myitem.SubItems.Add(dr["Password"].ToString()); //第3列，密码
                myitem.SubItems.Add(dr["RealName"].ToString()); //第4列，姓名
                switch (dr["UserType"].ToString())   //第5列，用户类别
                {
                    case "1": myitem.SubItems.Add("职员"); break;
                    case "2": myitem.SubItems.Add("经理"); break;
                    default: myitem.SubItems.Add("职员"); break;
                }
                switch (dr["Status"].ToString())//第6列，状态
                {
                    case "1": myitem.SubItems.Add("启用"); break;
                    case "2": myitem.SubItems.Add("禁用"); break;
                    default: myitem.SubItems.Add("禁用"); break;
                }

                lv_UserInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        //保存按钮
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();
            string realName = txt_RealName.Text.Trim();
            int userType = cbox_UserType.Text == "职员" ? 1 : 2;
            int status = rbtn_Status1.Checked ? 1 : 2;

            if (userName == "")
            {
                lbl_Note.Text = "帐号不能为空！";
                txt_UserName.Focus();
            }
            else if (password == "")
            {
                lbl_Note.Text = "密码不能为空！";
                txt_Password.Focus();
            }
            else if (realName == "")
            {
                lbl_Note.Text = "姓名不能为空！";
                txt_RealName.Focus();
            }
            else
            {
                if (lbl_Status.Text == "添加")  //添加操作
                {
                    //SQL插入语句
                    string sqlstr = string.Format("insert into User_Info values('{0}', '{1}', '{2}', {3}, {4} )", userName, password, realName, userType, status);

                    //调用业务逻辑对象的方法
                    int i = DataWork.DataExecute(sqlstr);

                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息添加成功！";
                        ClearTextBox();       //清空各控件
                        DataBind_UserInfo();  //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息添加失败！";
                    }
                }
                else  //修改操作
                {
                    //SQL修改语句
                    string sqlstr = string.Format("update User_Info set UserName='{0}', Password='{1}', RealName='{2}', UserType={3}, Status={4} where UserID={5}", userName, password, realName, userType, status, userid);

                    //调用业务逻辑对象的方法
                    int i = DataWork.DataExecute(sqlstr);

                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息修改成功！";
                        ClearTextBox();       //清空各控件
                        DataBind_UserInfo();  //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息修改失败！";
                    }
                }
            }
        }


        //清空各控件
        protected void ClearTextBox()
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_RealName.Text = "";
            cbox_UserType.SelectedIndex = 0;
            rbtn_Status1.Checked = true;
            lbl_Status.Text = "添加";
            userid = "";
        }



        //员工信息选中项改变事件
        private void lv_UserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_UserInfo.SelectedItems.Count > 0)  //如果有选中项
            {
                ListViewItem myitem = lv_UserInfo.SelectedItems[0]; //获取选中的第一行（一次只能选一行）

                userid = myitem.SubItems[0].Text; //将选中行的第1列的值赋值全局变量，员工编号
                txt_UserName.Text = myitem.SubItems[1].Text;    //选中行第2列，帐号
                txt_Password.Text = myitem.SubItems[2].Text;   //密码
                txt_RealName.Text = myitem.SubItems[3].Text;   //姓名
                cbox_UserType.SelectedIndex = myitem.SubItems[4].Text.Trim() == "职员" ? 0 : 1;   //身份
                rbtn_Status1.Checked = myitem.SubItems[5].Text.Trim() == "启用" ? true : false;   //状态
                rbtn_Status2.Checked = myitem.SubItems[5].Text.Trim() == "禁用" ? true : false;   //状态
                lbl_Status.Text = "修改";  //当前状态
            }
        }

        //“取消”按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();  //调用函数，清空各控件
            lbl_Note.Text = "";
        }

        //“启用”按钮
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            if (userid == "")   //如果没有选中要启用的员工信息
            {
                MessageBox.Show("请先选择要启用的员工信息！");
            }
            else
            {
                //SQL修改语句
                string sqlstr = string.Format("update User_Info set Status=1 where UserID={0}", userid);

                //调用业务逻辑对象的方法
                int i = DataWork.DataExecute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息启用成功！";

                    ClearTextBox();       //清空各控件
                    DataBind_UserInfo();  //重新加载员工信息
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息启用失败！";

                }
            }
        }

        //“禁用”按钮
        private void btn_Disable_Click(object sender, EventArgs e)
        {
            if (userid == "")   //如果没有选中要禁用的员工信息
            {
                MessageBox.Show("请先选择要禁用的员工信息！");
            }
            else
            {
                //SQL修改语句
                string sqlstr = string.Format("update User_Info set Status=0 where UserID={0}", userid);

                //调用业务逻辑对象的方法
                int i = DataWork.DataExecute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息禁用成功！";

                    ClearTextBox();       //清空各控件
                    DataBind_UserInfo();  //重新加载员工信息
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息禁用失败！";

                }
            }
        }

        //“重置密码”按钮
        private void btn_ReSetPassword_Click(object sender, EventArgs e)
        {
            if (userid == "")   //如果没有选中要重置密码的员工信息
            {
                MessageBox.Show("请先选择要重置密码的员工信息！");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要将选中员工的密码重置？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //如果确定删除
                {

                    //SQL修改语句
                    string sqlstr = string.Format("update User_Info set Password='123' where UserID={0}", userid);

                    //调用业务逻辑对象的方法
                    int i = DataWork.DataExecute(sqlstr);

                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息密码重置成功。新密码:123";

                        ClearTextBox();       //清空各控件
                        DataBind_UserInfo();  //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息密码重置失败！";

                    }
                }
            }
        }

        //“删除”按钮
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (userid == "")   //如果没有选中要删除的员工信息
            {
                MessageBox.Show("请先选择要删除的员工信息！");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的员工信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //如果确定删除
                {
                    //SQL修改语句
                    string sqlstr = string.Format("delete from User_Info where UserID={0}", userid);

                    //调用业务逻辑对象的方法
                    int i = DataWork.DataExecute(sqlstr);

                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息删除成功！";

                        ClearTextBox();       //清空各控件
                        DataBind_UserInfo();  //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";

                    }
                }
            }
        }
    }
}
