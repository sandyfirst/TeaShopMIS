using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_TeaPriceManage : Form
    {
        public Frm_TeaPriceManage()
        {
            InitializeComponent();
        }

        string teaid = ""; //定义全局变量，用于存储选中的饮品编号
        string tpid = ""; //定义全局变量，用于存储选中的饮品价格编号

        //窗体加载事件
        private void Frm_TeaPriceManage_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo(); //加载饮品信息
        }


        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            //查询所有饮品信息
            string sqlstr = "select * from Tea_Info";

            //调用数据查询函数
            DataTable dt = DataWork.DataQuery(sqlstr);

            //7、显示结果
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
                    default: break;
                }
                myitem.SubItems.Add(dr["TeaImage"].ToString());  

                lv_TeaInfo.Items.Add(myitem); 
            }
        }


        //选中某个饮品信息，加载饮品信息和价格信息
        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0) 
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0]; 

                teaid = myitem.SubItems[0].Text; 
                txt_TeaName.Text = myitem.SubItems[1].Text;                 
                txt_Price_Small.Text = myitem.SubItems[2].Text;  
                txt_Price_Medium.Text = myitem.SubItems[3].Text; 
                txt_Price_Large.Text = myitem.SubItems[4].Text;  
                pictureBox1.ImageLocation = myitem.SubItems[6].Text;      
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                DataBind_TeaPrice(teaid); 
            }
        }


        //加载饮品价格
        protected void DataBind_TeaPrice(string teaid)
        {
            //查询所有饮品信息
            string sqlstr = string.Format("select * from Tea_Price where TeaID={0}", teaid);

            //调用数据查询函数
            DataTable dt = DataWork.DataQuery(sqlstr);

            //7、显示结果
            lv_TeaPrice.Items.Clear();  //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TPID"].ToString());  //第1列，价格编号
                myitem.SubItems.Add(dr["Price_Small"].ToString());  //第2列，价格(小)
                myitem.SubItems.Add(dr["Price_Medium"].ToString()); //第3列，价格(中)
                myitem.SubItems.Add(dr["Price_Large"].ToString());  //第4列，价格(大)
                myitem.SubItems.Add(dr["BeginDate"].ToString());  //第5列，价格生效日期
                myitem.SubItems.Add(dr["EndDate"].ToString());  //第6列，价格失效日期

                lv_TeaPrice.Items.Add(myitem);  //将新建项添加到ListView控件中
            }
        }


        //保存饮品价格
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dtp_EndDate.Value <= dtp_BeginDate.Value)
            {
                lbl_Note.Text = "失效日期应大于生效日期.";
                lbl_Note.ForeColor = Color.Red;
            }
            else if (lbl_Operation.Text=="添加")
            {
                string sqlstr = "insert into Tea_Price (TeaID, Price_Small, Price_Medium, Price_Large, BeginDate, EndDate) ";
                sqlstr += string.Format(" values ({0}, {1}, {2}, {3}, '{4}', '{5}')", teaid, txt_Price_Small.Text, txt_Price_Medium.Text, txt_Price_Large.Text, dtp_BeginDate.Value, dtp_EndDate.Value);

                int i = DataWork.DataExecute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "饮品价格添加成功！";
                    lbl_Note.ForeColor = Color.Blue;

                    DataBind_TeaPrice(teaid); //重新加载饮品价格
                }
                else
                {
                    lbl_Note.Text = "饮品价格添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else if (lbl_Operation.Text == "修改")
            {
                string sqlstr = string.Format("update Tea_Price set Price_Small={0}, Price_Medium={1}, Price_Large={2}, BeginDate='{3}', EndDate='{4}' where TPID={5}", txt_Price_Small.Text, txt_Price_Medium.Text, txt_Price_Large.Text, dtp_BeginDate.Value, dtp_EndDate.Value, tpid);

                int i = DataWork.DataExecute(sqlstr);

                if (i > 0)
                {
                    lbl_Note.Text = "饮品价格修改成功！";
                    lbl_Note.ForeColor = Color.Blue;

                    DataBind_TeaPrice(teaid); //重新加载饮品价格
                }
                else
                {
                    lbl_Note.Text = "饮品价格修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }


        //选择某个饮品价格
        private void lv_TeaPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaPrice.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_TeaPrice.SelectedItems[0]; //获取选中的第一行(一次只能选一行) 

                tpid = myitem.SubItems[0].Text; //将选中行第1列的值赋值全局变量，饮品编号

                txt_Price_Small.Text = myitem.SubItems[1].Text;  //价格(小)
                txt_Price_Medium.Text = myitem.SubItems[2].Text; //价格(中)
                txt_Price_Large.Text = myitem.SubItems[3].Text;  //价格(大)
                dtp_BeginDate.Value = DateTime.Parse(myitem.SubItems[4].Text);  //价格生效日期
                dtp_EndDate.Value = DateTime.Parse(myitem.SubItems[5].Text);  //价格失效日期               

                lbl_Operation.Text = "修改";
            }
        }
    }
}
