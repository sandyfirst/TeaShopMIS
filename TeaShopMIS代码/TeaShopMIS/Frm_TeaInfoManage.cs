using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaShopMIS
{
    public partial class Frm_TeaInfoManage : Form
    {
        int teaid = 0;  //定义全局变量，用于存储饮品编号

        public Frm_TeaInfoManage()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
        }

        private void Frm_TeaInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();
        }

        //加载饮品信息
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";
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

        //选择图片
        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaName = txt_TeaName.Text.Trim();
            string teaImage = pictureBox1.ImageLocation;
            double priceSmall = double.Parse(txt_Price_Small.Text);
            double priceMedium = double.Parse(txt_Price_Medium.Text);
            double priceLarge = double.Parse(txt_Price_Large.Text);
            int status = ccb_Status.SelectedIndex + 1;

            if (teaName == "")
            {
                lbl_Note.Text = "饮品名称不能为空";
                txt_TeaName.Focus();
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = string.Format("insert into Tea_Info values ('{0}','{1}',{2}, {3}, {4}, {5})", teaName, teaImage, priceSmall, priceMedium, priceLarge, status);

                int i = DataWork.DataExecute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = " 饮品信息添加成功!";
                    DataBind_TeaInfo();
                    ClearTextBox();
                }
                else
                {
                    lbl_Note.Text = "饮品信息添加失败!";
                }
            }
            else if (lbl_Operation.Text == "修改")
            {
                string sqlstr = string.Format("update Tea_Info set TeaName='{0}', TeaImage='{1}', Price_Small={2}, Price_Medium={3}, Price_Large={4}, Status={5} where TeaID={6}", teaName, teaImage, priceSmall, priceMedium, priceLarge, status, teaid);

                int i = DataWork.DataExecute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = " 饮品信息修改成功!";
                    DataBind_TeaInfo();
                    ClearTextBox();
                }
                else
                {
                    lbl_Note.Text = "饮品信息修改失败!";
                }
            }
        }

        protected void ClearTextBox()
        {
            teaid = 0;
            txt_TeaName.Text = "";
            pictureBox1.ImageLocation = "";
            txt_Price_Small.Text = "";
            txt_Price_Medium.Text = "";
            txt_Price_Large.Text = "";
            ccb_Status.SelectedIndex = 0;
            lbl_Operation.Text = "添加";
        }



        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0];  //获取选中的第一行
                teaid = int.Parse(myitem.SubItems[0].Text);
                txt_TeaName.Text = myitem.SubItems[1].Text;
                txt_Price_Small.Text = myitem.SubItems[2].Text;
                txt_Price_Medium.Text = myitem.SubItems[3].Text;
                txt_Price_Large.Text = myitem.SubItems[4].Text;

                switch (myitem.SubItems[5].Text)
                {
                    case "在售": ccb_Status.SelectedIndex = 0; break;
                    case "售完": ccb_Status.SelectedIndex = 1; break;
                    case "停售": ccb_Status.SelectedIndex = 2; break;
                    default: ccb_Status.SelectedIndex = 0; break;
                }

                pictureBox1.ImageLocation = myitem.SubItems[6].Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Operation.Text = "修改";
            }
        }

        //在售
        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            if (teaid == 0 || lbl_Operation.Text == "添加")
            {
                MessageBox.Show("请先选择要设置的饮品信息");
            }
            else
            {
                string sqlstr = string.Format("update Tea_Info set Status=1 where TeaId={0}", teaid);

                int i = DataWork.DataExecute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = " 饮品信息状态修改成功!";
                    DataBind_TeaInfo();
                    ClearTextBox();
                }
                else
                {
                    lbl_Note.Text = "饮品信息状态修改失败!";
                }
            }
        }

        //删除
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (teaid == 0 || lbl_Operation.Text == "添加")
            {
                MessageBox.Show("请先选择要删除的饮品信息");
            }
            else
            {
               DialogResult result = MessageBox.Show("确定要删除选中的饮品信息吗?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Tea_Info where TeaId={0}", teaid);

                    int i = DataWork.DataExecute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = " 饮品信息删除成功!";
                        DataBind_TeaInfo();
                        ClearTextBox();
                    }
                    else
                    {
                        lbl_Note.Text = "饮品信息删除失败!";
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void lbl_Note_Click(object sender, EventArgs e)
        {

        }
    }
}
