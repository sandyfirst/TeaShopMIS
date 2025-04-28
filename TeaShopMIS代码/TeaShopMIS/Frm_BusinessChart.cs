using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//new
//using System.Windows.Forms.DataVisualization.Charting;

namespace TeaShopMIS
{
    public partial class Frm_BusinessChart : Form
    {
        public Frm_BusinessChart()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void Frm_BusinessChart_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();   //加载饮品信息
            DataBind_UserInfo();   //加载用户信息
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
     
            cbb_Tea.Items.Clear();
            cbb_Tea.Items.Add("全部");
            foreach (DataRow dr in dt.Rows)
            {
                cbb_Tea.Items.Add(dr["TeaName"].ToString());
            }
        }

        //加载用户信息
        protected void DataBind_UserInfo()
        {
            string sqlstr = "select * from User_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);

            cbb_User.Items.Clear();
            cbb_User.Items.Add("全部");
            foreach (DataRow dr in dt.Rows)
            {
                cbb_User.Items.Add(dr["UserName"].ToString());
            }
        }

        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select sum(PaidupMoney) as business, convert(varchar,OrderDate,111) as date from Order_Info where 1=1 ";
            
            if (chb_OrderDate.Checked) // 销售日期
            {
                sqlstr += string.Format(" and OrderDate between '{0}' and '{1}' ", dtp_BeginDate.Value, dtp_EndDate.Value);
            }

            if (chb_Payway.Checked && cbb_Payway.SelectedIndex != 0) //付款方式
            {
                sqlstr += string.Format(" and Payway={0}", cbb_Payway.SelectedIndex);
            }

            if (chb_Tea.Checked && cbb_Tea.SelectedIndex != 0) //饮品名称
            {
                sqlstr += string.Format(" and TeaNames like '%{0}%'", cbb_Tea.Text);
            }

            if (chb_User.Checked && cbb_User.SelectedIndex != 0) //销售员
            {
                sqlstr += string.Format(" and UserName ='{0}'", cbb_User.Text);
            }

            sqlstr += " Group by convert(varchar,OrderDate,111) order by convert(varchar,OrderDate,111)";

            DataBind_OrderInfo(sqlstr);
        }

        protected void DataBind_OrderInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);
            double[] business = new double[dt.Rows.Count];
            string[] date = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                business[i] = double.Parse(dt.Rows[i]["business"].ToString());
                date[i] = dt.Rows[i]["date"].ToString();
            }

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisX.Title = "日期";
            chart1.ChartAreas[0].AxisY.Title = "营业额(元)";

            chart1.Series[0].Points.DataBindXY(date, business);
        }
      

        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            chb_OrderDate.Checked = false;
            chb_Payway.Checked = false;
            chb_User.Checked = false;

            dtp_BeginDate.Value = DateTime.Now;
            dtp_EndDate.Value = DateTime.Now;
            cbb_Payway.SelectedIndex = 0;
            cbb_User.SelectedIndex = 0;
            cbb_Tea.SelectedIndex = 0;

            //chart1.Series.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
