using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_MemberInfoQuery : Form
    {
        public Frm_MemberInfoQuery()
        {
            InitializeComponent();
        }

        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //查询会员信息
            string sqlstr = "select * from Member_Info where 1=1 ";

            //会员姓名
            if (chb_MemberName.Checked && txt_MemberName.Text.Trim() != "")
            {
                sqlstr += string.Format(" and MemberName like '%{0}%' ", txt_MemberName.Text);                   
            }

            //会员卡号
            if (chb_MemberNumber.Checked && txt_MemberNumber.Text.Trim() != "")
            {
                sqlstr += string.Format(" and MemberNumber like '%{0}%' ", txt_MemberNumber.Text);
            }

            //电话号码
            if (chb_Telephone.Checked && txt_Telephone.Text.Trim() != "")
            {
                sqlstr += string.Format(" and Telephone like '%{0}%' ", txt_Telephone.Text);
            }

            //性别
            if (chb_Sex.Checked)
            {
                if (cbb_Sex.SelectedIndex != 0)  //0为全部，即不用设条件
                {
                    sqlstr += string.Format(" and Sex = {0} ", cbb_Sex.SelectedIndex);
                }
            }

            DataBind_MemberInfo(sqlstr);
        }


        //根据条件查询会员信息
        protected void DataBind_MemberInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);

            lv_MemberInfo.Items.Clear();  
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());  
                myitem.SubItems.Add(dr["MemberName"].ToString());   
                myitem.SubItems.Add(dr["MemberNumber"].ToString());  
                switch (dr["Sex"].ToString())  
                {
                    case "1": myitem.SubItems.Add("男"); break;
                    case "2": myitem.SubItems.Add("女"); break;
                }
                myitem.SubItems.Add(dr["Telephone"].ToString());
                switch (dr["Status"].ToString()) 
                {
                    case "1": myitem.SubItems.Add("正常"); break;
                    case "2": myitem.SubItems.Add("删除"); break;
                }
                myitem.SubItems.Add(dr["Remark"].ToString()); 
                lv_MemberInfo.Items.Add(myitem);  
            }
        }

        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            chb_MemberName.Checked = false;
            chb_MemberNumber.Checked = false;
            chb_Telephone.Checked = false;
            chb_Sex.Checked = false;
            cbb_Sex.SelectedIndex = 0;
            txt_MemberName.Text = "";
            txt_MemberNumber.Text = "";
            txt_Telephone.Text = "";

            lv_MemberInfo.Items.Clear();
        }
    }
}
