using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//新增
using System.Configuration;
using AxWMPLib;

namespace TeaShopMIS
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.Size = new Size(900, 650);
        }

        //打开窗口
        private void Frm_Main_Load(object sender, EventArgs e)
        {
             // lbl_Name.Text = ConfigurationManager.AppSettings["RealName"]; //获取配置文件中的当前服务员姓名
            lbl_Name.Text = System.Configuration.ConfigurationSettings.AppSettings["RealName"];
        }

        //菜单--饮品信息管理
        private void menu_TeaInfoManage_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoManage frm = new Frm_TeaInfoManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //饮品价格管理
        private void menu_TeaPriceManage_Click(object sender, EventArgs e)
        {
            Frm_TeaPriceManage frm = new Frm_TeaPriceManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }


        //菜单--会员信息管理
        private void menu_MemberInfoManage_Click(object sender, EventArgs e)
        {
            Frm_MemberInfoManage frm = new Frm_MemberInfoManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--员工信息管理
        private void menu_UserInfoManage_Click(object sender, EventArgs e)
        {
            Frm_UserInfoManage frm = new Frm_UserInfoManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--修改密码
        private void menu_ChangePassword_Click(object sender, EventArgs e)
        {
            Frm_ChangePassword frm = new Frm_ChangePassword();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--退出系统
        private void menu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //菜单--点餐收银
        private void menu_Order_Click(object sender, EventArgs e)
        {
            Frm_Order frm = new Frm_Order();
            frm.Size = new Size(1100, 700);
            frm.Show();
        }


        //菜单--播放音乐
        private void menu_PlayMusic_Click(object sender, EventArgs e)
        {
            Frm_PlayMusic frm = new Frm_PlayMusic();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--饮品信息查询
        private void menu_TeaInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoQuery frm = new Frm_TeaInfoQuery();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--会员信息查询
        private void menu_MemberInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_MemberInfoQuery frm = new Frm_MemberInfoQuery();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--营业信息查询
        private void menu_OrderInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_OrderInfoQuery frm = new Frm_OrderInfoQuery();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //菜单--业绩统计分析
        private void menu_BusinessChart_Click(object sender, EventArgs e)
        {
            Frm_BusinessChart frm = new Frm_BusinessChart();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //工具栏按钮--饮品信息管理
        private void btn_TeaInfoManage_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoManage frm = new Frm_TeaInfoManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        //工具栏按钮--会员信息管理
        private void btn_MemberInfoManage_Click(object sender, EventArgs e)
        {
            Frm_MemberInfoManage frm = new Frm_MemberInfoManage();
            frm.Size = new Size(900, 650);
            frm.Show();
        }

        

        //工具栏按钮--点餐收银
        private void btn_Order_Click(object sender, EventArgs e)
        {
            Frm_Order frm = new Frm_Order();
            frm.Size = new Size(1100, 700);
            frm.Show();
        }

        //工具栏按钮--播放音乐
        private void btn_PlayMusic_Click(object sender, EventArgs e)
        {
            Frm_PlayMusic frm = new Frm_PlayMusic();
            frm.Size = new Size(900, 650);
            frm.Show();


        }


        //时间控件
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString();
        }


        //窗体关闭
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确实要退出吗", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();  // 清理正在使用的资源
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void lbl_Time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString();
        }

        private void 饮品信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TeaInfoQuery_Click(object sender, EventArgs e)
        {

        }
    }
}   