using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Configuration;
using System.IO;

namespace TeaShopMIS
{
    public partial class Frm_Order : Form
    {
        int teaid = 0; //创建全局变量，用于存储饮品编号

        public Frm_Order()
        {
            InitializeComponent();
        }

        private void Frm_Order_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            //查询数据
            string sqlstr = "select * from Tea_Info where Status=1";

            DataTable dt = DataWork.DataQuery(sqlstr);

            ////加载图片到imagelist控件中
            //imageList1.Images.Clear();
            //foreach (DataRow dr in dt.Rows)
            //    imageList1.Images.Add(Image.FromFile(dr["TeaImage"].ToString()));

            // 加载图片到 imageList 控件中
            foreach (DataRow dr in dt.Rows)
            {
                string imagePath = dr["TeaImage"].ToString();

                // 检查数据库路径并进行替换
                if (imagePath.StartsWith(@"D:\C#\Projects"))
                {
                    // 替换为您实际的路径
                    imagePath = imagePath.Replace(@"D:\C#\Projects\TeaShopMIS\TeaShopMIS\Tea_images", @"D:\Grade-2\C#\TeaShopMIS\TeaShopMIS\Tea_images");
                }

                // 拼接完整的图片路径
                string fullImagePath = Path.Combine(@"D:\Grade-2\C#\TeaShopMIS\TeaShopMIS\Tea_images", imagePath);

                // 输出拼接后的路径
                //Console.WriteLine("Full Image Path: " + fullImagePath);

                // 检查文件是否存在
                if (File.Exists(fullImagePath))
                {
                    try
                    {
                        // 添加图片到 ImageList
                        imageList1.Images.Add(Image.FromFile(fullImagePath));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("加载图片时出错: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("图片文件未找到: " + fullImagePath);
                }
            }

            //加载饮品信息到Listview控件中
            lv_TeaInfo.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string title = dt.Rows[i]["TeaName"].ToString() + "\n";
                title += "小份：" + double.Parse(dt.Rows[i]["Price_Small"].ToString()).ToString("C") + "\n";
                title += "中份：" + double.Parse(dt.Rows[i]["Price_Medium"].ToString()).ToString("C") + "\n";
                title += "大份：" + double.Parse(dt.Rows[i]["Price_Large"].ToString()).ToString("C") + "\n";

                ListViewItem myitem = new ListViewItem(title);
                myitem.SubItems.Add(dt.Rows[i]["TeaID"].ToString());
                myitem.ImageIndex = i;

                lv_TeaInfo.Items.Add(myitem);
            }
        }


        //选中饮品信息
        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedIndices.Count > 0)
            {
                teaid = int.Parse(lv_TeaInfo.SelectedItems[0].SubItems[1].Text);

                string sqlstr = string.Format("select * from Tea_Info where TeaID={0}", teaid);
                DataTable dt = DataWork.DataQuery(sqlstr);

                if (dt.Rows.Count > 0)
                {
                    lbl_TeaName.Text = dt.Rows[0]["TeaName"].ToString();
                    lbl_Price_Large.Text = dt.Rows[0]["Price_Large"].ToString();
                    lbl_Price_Medium.Text = dt.Rows[0]["Price_Medium"].ToString();
                    lbl_Price_Small.Text = dt.Rows[0]["Price_Small"].ToString();
                    pictureBox1.ImageLocation = dt.Rows[0]["TeaImage"].ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_Quantity.Text);
            txt_Quantity.Text = (quantity + 1).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_Quantity.Text);
            if (quantity > 1)
            {
                txt_Quantity.Text = (quantity - 1).ToString();
            }
            else
            {
                txt_Quantity.Text = "1";
            }
        }

        //加入订单
        private void btn_AppendtoOrder_Click(object sender, EventArgs e)
        {
            if (teaid == 0)
            {
                MessageBox.Show("请先选择要下单的饮品!");
            }
            else
            {
                string[] data = new string[6];
                data[0] = teaid.ToString();
                data[1] = lbl_TeaName.Text;
                string size = "";
                double unitprice = 0;
                if (rb_Small.Checked == true)
                {
                    size = "小份";
                    unitprice = double.Parse(lbl_Price_Small.Text);
                }
                else if (rb_Medium.Checked == true)
                {
                    size = "中份";
                    unitprice = double.Parse(lbl_Price_Medium.Text);
                }
                else if (rb_Large.Checked == true)
                {
                    size = "大份";
                    unitprice = double.Parse(lbl_Price_Large.Text);
                }
                data[2] = size;
                data[3] = unitprice.ToString();
                data[4] = txt_Quantity.Text;
                data[5] = txt_Remark1.Text;

                ListViewItem myitem = new ListViewItem(data);
                lv_OrderInfo.Items.Add(myitem);

                ResetTextBoxs(); //重置控件

                UpdateOrderPrice(); //自动更新订单金额
            }
        }

        //重置控件
        protected void ResetTextBoxs()
        {
            pictureBox1.ImageLocation = "";
            lbl_TeaName.Text = "";
            lbl_Price_Small.Text = "";
            lbl_Price_Medium.Text = "";
            lbl_Price_Large.Text = "";
            txt_Quantity.Text = "1";
            txt_Remark1.Text = "";
        }

        int selectitemindex = -1; //定义全局变量，用于存储选中的订单项目的行号

  
        private void lv_OrderInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_OrderInfo.SelectedIndices.Count > 0)
                selectitemindex = lv_OrderInfo.SelectedIndices[0];
                //selectitemindex = lv_OrderInfo.SelectedItems[0].Index;

        }

        //增加订单项的份数
        private void btn_plus2_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要增加份数的订单项!");
            }
            else
            {
                int quantity = int.Parse(lv_OrderInfo.Items[selectitemindex].SubItems[4].Text);
                lv_OrderInfo.Items[selectitemindex].SubItems[4].Text = (quantity + 1).ToString();
                UpdateOrderPrice(); //更新订单价格
            }
        }

        //减少订单项的份数
        private void btn_minus2_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要减少份数的订单项!");
            }
            else
            {
                int quantity = int.Parse(lv_OrderInfo.Items[selectitemindex].SubItems[4].Text);
                if (quantity > 1)
                {
                    lv_OrderInfo.Items[selectitemindex].SubItems[4].Text = (quantity - 1).ToString();
                }
                UpdateOrderPrice(); //更新订单价格
            }
        }

        //移除订单项
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要移除的订单项!");
            }
            else
            {
                lv_OrderInfo.Items[selectitemindex].Remove();
                UpdateOrderPrice(); //更新订单价格
            }
        }


        //更新订单价格
        protected void UpdateOrderPrice()
        {
            double duemoney = 0; //订单金额
            foreach (ListViewItem item in lv_OrderInfo.Items)
            {
                double unitprice = double.Parse(item.SubItems[3].Text);
                int quantity = int.Parse(item.SubItems[4].Text);
                duemoney += unitprice * quantity;
            }
            txt_DueMoney.Text = duemoney.ToString();

            txt_DiscountRate_Leave(null, null); //自动计算折扣
        }

        //自动计算折扣
        private void txt_DiscountRate_Leave(object sender, EventArgs e)
        {
            double duemoney = double.Parse(txt_DueMoney.Text);
            double discountrate = double.Parse(txt_DiscountRate.Value.ToString());
            double discountmoney = duemoney * (discountrate / 100.00);
            double paidupmoney = duemoney - discountmoney;

            txt_DiscountMoney.Text = discountmoney.ToString();
            txt_PaidUpMoney.Text = paidupmoney.ToString();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            //订单名称
            string teanames = "";
            int teaaccount = 0;
            foreach (ListViewItem item in lv_OrderInfo.Items)
            {
                teanames += item.SubItems[1].Text + ",";
                teaaccount += int.Parse(item.SubItems[4].Text);
            }         

            int payway = 0; //付款方式
            if (rb_Payway1.Checked == true) payway = 1;
            //else if (rb_Payway2.Checked == true) payway = 2;
            else if (rb_Payway3.Checked == true) payway = 3;
            else if (rb_Payway4.Checked == true) payway = 4;

            string username = ConfigurationManager.AppSettings["UserName"];

            int status = 1; //订单状态

            //插入一条订单信息到订单信息表，并获取生成的订单编号
            string sqlstr1 = string.Format("insert into Order_Info values ('{0}', {1}, '{2}', {3}, {4} , {5}, {6}, {7}, '{8}', '{9}', {10}, '{11}')", teanames, teaaccount, txt_MemberNumber.Text, txt_DueMoney.Text, txt_DiscountRate.Value.ToString(), txt_DiscountMoney.Text, txt_PaidUpMoney.Text, payway, DateTime.Now.ToString(), username, status, txt_Remark2.Text);
            sqlstr1 += "SELECT @@IDENTITY";

            int orderid = DataWork.ExecuteScalar(sqlstr1);

            //逐条插入订单详细项目
            int i = 0;
            foreach (ListViewItem item in lv_OrderInfo.Items)
            {
                int size = 0;
                switch (item.SubItems[2].Text)
                {
                    case "小份": size = 1; break;
                    case "中份": size = 2; break;
                    case "大份": size = 3; break;
                    default: size = 1; break;
                }

                string teaid = item.SubItems[0].Text;
                string unitprice = item.SubItems[3].Text;
                string quantity = item.SubItems[4].Text;
                string remark = item.SubItems[5].Text;

                string sqlstr2 = string.Format("insert into Order_Items values ({0}, {1}, {2}, {3}, {4}, '{5}')", orderid, teaid, size, unitprice, quantity, remark );

               i+= DataWork.DataExecute(sqlstr2);
            }

            if (orderid != 0 && i == lv_OrderInfo.Items.Count)
            {
                MessageBox.Show("付款成功！");
            }
            else
            {
                MessageBox.Show("订单保存失败!");
            }
        }

        //重置
        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            Frm_Order_Load(null, null);
        }
    }
}
