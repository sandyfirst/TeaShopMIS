using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_TeaInfoQuery : Form
    {
        public Frm_TeaInfoQuery()
        {
            InitializeComponent();
        }


        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from Tea_Info where 1=1 ";

            //价格（小）
            if (chb_Price_Small.Checked && txt_Price_Small.Text.Trim() != "")
            {
                //判断=, <, >
                switch (cbb_Price_Small.SelectedIndex)
                {
                    case 0: sqlstr += string.Format(" and Price_Small={0} ", txt_Price_Small.Text); break;
                    case 1: sqlstr += string.Format(" and Price_Small<{0} ", txt_Price_Small.Text); break;
                    case 2: sqlstr += string.Format(" and Price_Small>{0} ", txt_Price_Small.Text); break;
                }
            }

            //价格(中)
            if (chb_Price_Medium.Checked && txt_Price_Medium.Text.Trim() != "")
            {
                switch (cbb_Price_Medium.SelectedIndex)
                {
                    case 0: sqlstr += string.Format(" and Price_Medium={0} ", txt_Price_Medium.Text); break;
                    case 1: sqlstr += string.Format(" and Price_Medium<{0} ", txt_Price_Medium.Text); break;
                    case 2: sqlstr += string.Format(" and Price_Medium>{0} ", txt_Price_Medium.Text); break;
                }
            }

            //价格(大)
            if (chb_Price_Large.Checked && txt_Price_Large.Text.Trim() != "")
            {
                switch (cbb_Price_Large.SelectedIndex)
                {
                    case 0: sqlstr += string.Format(" and Price_Large ={0} ", txt_Price_Large.Text); break;
                    case 1: sqlstr += string.Format(" and Price_Large <{0} ", txt_Price_Large.Text); break;
                    case 2: sqlstr += string.Format(" and Price_Large >{0} ", txt_Price_Large.Text); break;
                }
            }

            //状态
            if (chb_Status.Checked)
            {
                if (cbb_Status.SelectedIndex != 0)
                {
                    sqlstr += string.Format(" and Status = {0}", cbb_Status.SelectedIndex);
                }
            }

            DataBind_TeaInfo(sqlstr); //调用函数
        }

        //查询饮品信息
        protected void DataBind_TeaInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);

            lv_TeaInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString());
                myitem.SubItems.Add(dr["TeaName"].ToString());
                myitem.SubItems.Add(dr["Price_Small"].ToString());
                myitem.SubItems.Add(dr["Price_Medium"].ToString());
                myitem.SubItems.Add(dr["Price_Large"].ToString());
                switch (dr["Status"].ToString())
                {
                    case "1": myitem.SubItems.Add("在售"); break;
                    case "2": myitem.SubItems.Add("售完"); break;
                    case "3": myitem.SubItems.Add("停售"); break;
                    default: myitem.SubItems.Add(""); break;
                }

                myitem.SubItems.Add(dr["TeaImage"].ToString());

                lv_TeaInfo.Items.Add(myitem);
            }
        }


        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            chb_Price_Small.Checked = false;
            chb_Price_Medium.Checked = false;
            chb_Price_Large.Checked = false;
            chb_Status.Checked = false;

            cbb_Price_Small.SelectedIndex = 0;
            cbb_Price_Medium.SelectedIndex = 0;
            cbb_Price_Large.SelectedIndex = 0;
            cbb_Status.SelectedIndex = 0;

            txt_Price_Small.Text = "";
            txt_Price_Medium.Text = "";
            txt_Price_Large.Text = "";
            lv_TeaInfo.Items.Clear();
        }
    }
}
