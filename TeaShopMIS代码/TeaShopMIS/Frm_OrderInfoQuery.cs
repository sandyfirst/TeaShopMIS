using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_OrderInfoQuery : Form
    {
        public Frm_OrderInfoQuery()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void Frm_OrderInfoQuery_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();   //加载饮品信息
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";

            //调用数据查询函数
            DataTable dt = DataWork.DataQuery(sqlstr);

            cbb_Tea.Items.Clear();
            cbb_Tea.Items.Add("全部");
            foreach (DataRow dr in dt.Rows)
            {
                cbb_Tea.Items.Add(dr["TeaName"].ToString());
            }

        }

        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from Order_Info where 1=1 ";
            if (chb_OrderDate.Checked)  //销售日期
                sqlstr += string.Format(" and OrderDate between '{0}' and '{1}' ", dtp_BeginDate.Value, dtp_EndDate.Value);
            if (chb_Payway.Checked && cbb_Payway.SelectedIndex != 0) //付款方式, 0为全部
                sqlstr += string.Format(" and Payway = {0} ", cbb_Payway.SelectedIndex);
            if (chb_MemberNumber.Checked && txt_MemberNumber.Text.Trim() != "")  //会员卡号
                sqlstr += string.Format(" and MemberNumber like '%{0}%' ", txt_MemberNumber.Text);
            if (chb_Tea.Checked && cbb_Tea.SelectedIndex != 0 && cbb_Tea.Text != "全部")  //饮品名称
                sqlstr += string.Format(" and TeaNames like '%{0}%' ", cbb_Tea.Text);
            DataBind_OrderInfo(sqlstr);
        }


    //根据条件查询会员信息
    protected void DataBind_OrderInfo(string sqlstr)
        {
            //调用业务逻辑对象的方法
            DataTable dt = DataWork.DataQuery(sqlstr);

            lv_OrderInfo.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                string[] data = new string[11];
                data[0] = dr["OrderID"].ToString();       //订单编号
                data[1] = dr["MemberNumber"].ToString();  //会员卡号
                data[2] = dr["TeaNames"].ToString();      //订单内容
                data[3] = dr["TeaAccount"].ToString();   //饮品数量
                data[4] = dr["DueMoney"].ToString();      //订单金额
                data[5] = dr["DiscountRate"].ToString();  //折扣比例
                data[6] = dr["DiscountMoney"].ToString(); //折扣金额
                data[7] = dr["PaidUpMoney"].ToString();   //实收金额
                switch (dr["Payway"].ToString())          //支付方式
                {
                    case "1": data[8] = "现金"; break;
                    case "2": data[8] = "银行卡"; break;
                    case "3": data[8] = "支付宝"; break;
                    case "4": data[8] = "微信"; break;
                }
                data[9] = dr["OrderDate"].ToString();   //销售日期
                data[10] = dr["UserName"].ToString();	//操作员

                lv_OrderInfo.Items.Add(new ListViewItem(data));  //将新建项添加到ListView控件中
            }
        }


        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            chb_OrderDate.Checked = false;
            chb_Payway.Checked = false;
            chb_MemberNumber.Checked = false;

            dtp_BeginDate.Value = DateTime.Now;
            dtp_EndDate.Value = DateTime.Now;
            cbb_Payway.SelectedIndex = 0;
            txt_MemberNumber.Text = "";
            
            lv_OrderInfo.Items.Clear();
        }
    }
}
