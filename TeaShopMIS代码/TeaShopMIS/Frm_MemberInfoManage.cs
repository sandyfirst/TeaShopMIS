using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_MemberInfoManage : Form
    {
        public Frm_MemberInfoManage()
        {
            InitializeComponent();
        }
        
        string memberNumber = ""; //全局变量，用于存储会员卡号 (根据会员卡号修改和删除信息，不根据会员编号，读者可以修改为根据会员编号)

        //窗体加载事件
        private void Frm_MemberInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_MemberInfo(); //加载会员信息
        }


        //加载会员信息
        protected void DataBind_MemberInfo()
        {
            //SQL查询语句
            string sqlstr = "select * from Member_Info";

            //调用业务逻辑对象的方法
            DataTable dt = DataWork.DataQuery(sqlstr);

            lv_MemberInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());  //创建一个ListViewItem项，并为第1列赋值，会员姓名
                myitem.SubItems.Add(dr["MemberName"].ToString());   //第2列，姓名
                myitem.SubItems.Add(dr["MemberNumber"].ToString());  //第3列，会员卡号
                switch (dr["Sex"].ToString())  //第4列，性别
                {
                    case "1": myitem.SubItems.Add("男"); break;
                    case "2": myitem.SubItems.Add("女"); break;
                }                
                myitem.SubItems.Add(dr["Telephone"].ToString());//第5列，电话
                switch (dr["Status"].ToString())  //第6列，状态
                {
                    case "1": myitem.SubItems.Add("正常"); break;
                    case "2": myitem.SubItems.Add("删除"); break;
                }
                myitem.SubItems.Add(dr["Remark"].ToString()); //第7列，备注
                lv_MemberInfo.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }

        //保存按钮
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //为实体对象赋值
            string memberName = txt_MemberName.Text.Trim();
            memberNumber = txt_MemberNumber.Text.Trim();
            int sex = rbtn_Sex1.Checked ? 1 : 2;
            string telephone = txt_Telephone.Text.Trim();
            int status = rbtn_Status1.Checked ? 1 : 2;
            string remark = txt_Remark.Text;

            if (telephone == "")
            {
                lbl_Note.Text = "联系电话不能为空！";
                txt_Telephone.Focus();
            }
            else if (memberName == "")
            {
                lbl_Note.Text = "会员姓名不能为空！";
                txt_MemberName.Focus();
            }
            else if (memberNumber == "")
            {
                lbl_Note.Text = "会员卡号不能为空！";
                txt_MemberNumber.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                try
                {
                    //先查询会员卡号是否存在
                    string sqlstr = string.Format("select * from Member_Info where MemberNumber ='{0}'", memberNumber);

                    //调用业务逻辑对象的方法
                    DataTable dt = DataWork.DataQuery(sqlstr);

                    if (dt.Rows.Count>0) //通过电话判断会员是否存在
                    {
                        lbl_Note.Text = "该会员卡号已存在，请重新设定新的卡号！";
                        txt_Telephone.Focus();
                    }
                    else
                    {
                        //添加会员信息
                        string sqlstr2 = string.Format("insert into Member_Info values('{0}', '{1}', {2}, '{3}', {4}, '{5}' )", memberName, memberNumber, sex, telephone, status, remark);

                        //调用业务逻辑对象的方法
                        int i = DataWork.DataExecute(sqlstr2);
                        if (i > 0)
                        {
                            lbl_Note.Text = "会员信息添加成功";
                            ClearTextBox();
                            DataBind_MemberInfo();
                        }
                        else
                        {
                            lbl_Note.Text = "对不起，会员信息添加失败！";
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("对不起，会员信息添加失败！" + er.Message);
                }
            }
            else
            {
                try
                {
                    //修改会员信息
                    string sqlstr2 = string.Format("update Member_Info set MemberName='{0}', Sex={1}, Telephone='{2}', Status={3}, Remark='{4}' where MemberNumber='{5}' ", memberName, sex, telephone, status, remark, memberNumber);

                    //调用业务逻辑对象的方法
                    int i = DataWork.DataExecute(sqlstr2);
                    if (i > 0)
                    {
                        lbl_Note.Text = "会员信息修改成功";
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员信息修改失败！";
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("对不起，会员信息修改失败！" + er.Message);
                }
            }
        }

        //清空各控件
        protected void ClearTextBox()
        {
            txt_MemberNumber.Text = "";
            txt_MemberName.Text = "";
            txt_Remark.Text = "";
            txt_Telephone.Text = "";
            rbtn_Sex1.Checked = true;
            rbtn_Status1.Checked = true;
            lbl_Status.Text = "添加";
            memberNumber = "";
            txt_MemberNumber.Enabled = true;
        }



        //会员信息选中项改变事件
        private void lv_MemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_MemberInfo.SelectedItems.Count > 0)  //如果有选中项
            {
                ListViewItem myitem = lv_MemberInfo.SelectedItems[0]; //获取选中的第一行（一次只能选一行）

                txt_MemberName.Text = myitem.SubItems[1].Text;
                memberNumber = myitem.SubItems[2].Text; //将选中行的第3列的值赋值全局变量，会员卡号
                txt_MemberNumber.Text = myitem.SubItems[2].Text;
                rbtn_Sex1.Checked = myitem.SubItems[3].Text.Trim() == "男" ? true : false;   //状态
                rbtn_Sex2.Checked = myitem.SubItems[3].Text.Trim() == "女" ? true : false;   //状态
                txt_Telephone.Text = myitem.SubItems[4].Text;               
                rbtn_Status1.Checked = myitem.SubItems[5].Text.Trim() == "正常" ? true : false;   //状态
                rbtn_Status2.Checked = myitem.SubItems[5].Text.Trim() == "删除" ? true : false;   //状态
                txt_Remark.Text = myitem.SubItems[6].Text;   //备注
                lbl_Status.Text = "修改";  //当前状态
                txt_MemberNumber.Enabled = false;   //会员卡号不能修改,将文本框设为不可编辑
            }
        }

        //“取消”按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();  //调用函数，清空各控件
            lbl_Note.Text = "";
        }

        //“设为正常”按钮
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            if (memberNumber == "")   //如果没有选中要启用的会员信息
            {
                MessageBox.Show("请先选择要设为“正常”的会员信息！");
            }
            else
            {
                //修改会员信息
                string sqlstr = string.Format("update Member_Info set Status=1 where MemberNumber='{0}' ", memberNumber);

                //调用业务逻辑对象的方法
                int i = DataWork.DataExecute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，会员状态设置成功！";
                    ClearTextBox();       //清空各控件
                    DataBind_MemberInfo();  //重新加载会员信息
                }
                else
                {
                    lbl_Note.Text = "对不起，会员状态失败！";

                }
            }
        }

        //“删除”按钮
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (memberNumber == "")   //如果没有选中要删除的会员信息
            {
                MessageBox.Show("请先选择要删除的会员信息！");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的会员信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //如果确定删除
                {

                    //先查询该会员是否存在消费信息
                    string sqlstr = string.Format("select * from Sale_Info where MemberNumber ='{0}'", memberNumber);

                    //调用业务逻辑对象的方法
                    DataTable dt = DataWork.DataQuery(sqlstr);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("该会员有消费记录，不能删除！");
                    }
                    else
                    {
                        //删除会员信息
                        string sqlstr2 = string.Format("delete from Member_Info where MemberNumber='{0}' ", memberNumber);

                        //调用业务逻辑对象的方法
                        int i = DataWork.DataExecute(sqlstr2);
                        if (i > 0)
                        {
                            lbl_Note.Text = "恭喜您，会员信息删除成功！";

                            ClearTextBox();       //清空各控件
                            DataBind_MemberInfo();  //重新加载会员信息
                        }
                        else
                        {
                            lbl_Note.Text = "对不起，会员信息删除失败！";

                        }
                    }
                }
            }
        }
    }
}