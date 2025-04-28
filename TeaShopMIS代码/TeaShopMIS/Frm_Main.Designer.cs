namespace TeaShopMIS
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeaInfoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeaInfoQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MemberInfoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.会员信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_UserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.前台接待ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PlayMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_TeaInfoManage = new System.Windows.Forms.ToolStripButton();
            this.btn_MemberInfoManage = new System.Windows.Forms.ToolStripButton();
            this.btn_Order = new System.Windows.Forms.ToolStripButton();
            this.btn_PlayMusic = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.员工信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.前台接待ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(24, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1787, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TeaInfoManage,
            this.menu_MemberInfoManage,
            this.menu_UserManage,
            this.toolStripMenuItem1,
            this.menu_Exit});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 35);
            this.系统管理ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // menu_TeaInfoManage
            // 
            this.menu_TeaInfoManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TeaInfoQuery});
            this.menu_TeaInfoManage.Name = "menu_TeaInfoManage";
            this.menu_TeaInfoManage.Size = new System.Drawing.Size(359, 44);
            this.menu_TeaInfoManage.Text = "饮品信息管理";
            this.menu_TeaInfoManage.Click += new System.EventHandler(this.menu_TeaInfoManage_Click);
            // 
            // menu_TeaInfoQuery
            // 
            this.menu_TeaInfoQuery.Name = "menu_TeaInfoQuery";
            this.menu_TeaInfoQuery.Size = new System.Drawing.Size(359, 44);
            this.menu_TeaInfoQuery.Text = "饮品信息查询";
            this.menu_TeaInfoQuery.Click += new System.EventHandler(this.TeaInfoQuery_Click);
            // 
            // menu_MemberInfoManage
            // 
            this.menu_MemberInfoManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员信息查询ToolStripMenuItem});
            this.menu_MemberInfoManage.Name = "menu_MemberInfoManage";
            this.menu_MemberInfoManage.Size = new System.Drawing.Size(359, 44);
            this.menu_MemberInfoManage.Text = "会员信息管理";
            this.menu_MemberInfoManage.Click += new System.EventHandler(this.menu_MemberInfoManage_Click);
            // 
            // 会员信息查询ToolStripMenuItem
            // 
            this.会员信息查询ToolStripMenuItem.Name = "会员信息查询ToolStripMenuItem";
            this.会员信息查询ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.会员信息查询ToolStripMenuItem.Text = "会员信息查询";
            // 
            // menu_UserManage
            // 
            this.menu_UserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息查询ToolStripMenuItem});
            this.menu_UserManage.Name = "menu_UserManage";
            this.menu_UserManage.Size = new System.Drawing.Size(359, 44);
            this.menu_UserManage.Text = "员工信息管理";
            this.menu_UserManage.Click += new System.EventHandler(this.menu_UserInfoManage_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(359, 44);
            this.menu_Exit.Text = "退出系统";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // 前台接待ToolStripMenuItem
            // 
            this.前台接待ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Order,
            this.menu_PlayMusic});
            this.前台接待ToolStripMenuItem.Name = "前台接待ToolStripMenuItem";
            this.前台接待ToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.前台接待ToolStripMenuItem.Text = "点餐服务(&F)";
            // 
            // menu_Order
            // 
            this.menu_Order.Name = "menu_Order";
            this.menu_Order.Size = new System.Drawing.Size(243, 44);
            this.menu_Order.Text = "点餐收银";
            this.menu_Order.Click += new System.EventHandler(this.menu_Order_Click);
            // 
            // menu_PlayMusic
            // 
            this.menu_PlayMusic.Name = "menu_PlayMusic";
            this.menu_PlayMusic.Size = new System.Drawing.Size(243, 44);
            this.menu_PlayMusic.Text = "播放音乐";
            this.menu_PlayMusic.Click += new System.EventHandler(this.menu_PlayMusic_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.lbl_Name,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel11,
            this.toolStripStatusLabel1,
            this.lbl_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 56, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1787, 88);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(158, 78);
            this.toolStripStatusLabel7.Text = "当前操作员：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = false;
            this.lbl_Name.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 78);
            this.lbl_Name.Text = "人名";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.AutoSize = false;
            this.toolStripStatusLabel10.ForeColor = System.Drawing.Color.MediumBlue;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(350, 78);
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(0, 78);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 78);
            this.toolStripStatusLabel1.Text = "当前时间：";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = false;
            this.lbl_Time.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Time.Size = new System.Drawing.Size(150, 78);
            this.lbl_Time.Click += new System.EventHandler(this.lbl_Time_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TeaInfoManage,
            this.btn_MemberInfoManage,
            this.toolStripSeparator2,
            this.btn_Order,
            this.btn_PlayMusic});
            this.toolStrip1.Location = new System.Drawing.Point(0, 51);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1787, 93);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_TeaInfoManage
            // 
            this.btn_TeaInfoManage.Image = global::TeaShopMIS.Properties.Resources.饮品信息;
            this.btn_TeaInfoManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TeaInfoManage.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btn_TeaInfoManage.Name = "btn_TeaInfoManage";
            this.btn_TeaInfoManage.Size = new System.Drawing.Size(162, 83);
            this.btn_TeaInfoManage.Text = "饮品信息管理";
            this.btn_TeaInfoManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TeaInfoManage.Click += new System.EventHandler(this.btn_TeaInfoManage_Click);
            // 
            // btn_MemberInfoManage
            // 
            this.btn_MemberInfoManage.Image = global::TeaShopMIS.Properties.Resources.用户信息;
            this.btn_MemberInfoManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MemberInfoManage.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btn_MemberInfoManage.Name = "btn_MemberInfoManage";
            this.btn_MemberInfoManage.Size = new System.Drawing.Size(162, 83);
            this.btn_MemberInfoManage.Text = "会员信息管理";
            this.btn_MemberInfoManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_MemberInfoManage.Click += new System.EventHandler(this.btn_MemberInfoManage_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Image = global::TeaShopMIS.Properties.Resources.点餐;
            this.btn_Order.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Order.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(114, 83);
            this.btn_Order.Text = "点餐收银";
            this.btn_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_PlayMusic
            // 
            this.btn_PlayMusic.Image = global::TeaShopMIS.Properties.Resources.音乐;
            this.btn_PlayMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PlayMusic.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btn_PlayMusic.Name = "btn_PlayMusic";
            this.btn_PlayMusic.Size = new System.Drawing.Size(114, 83);
            this.btn_PlayMusic.Text = "播放音乐";
            this.btn_PlayMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PlayMusic.Click += new System.EventHandler(this.btn_PlayMusic_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // 员工信息查询ToolStripMenuItem
            // 
            this.员工信息查询ToolStripMenuItem.Name = "员工信息查询ToolStripMenuItem";
            this.员工信息查询ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.员工信息查询ToolStripMenuItem.Text = "员工信息查询";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1787, 1312);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 18F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Frm_Main";
            this.Text = "饮品店点餐收银系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_TeaInfoManage;
        private System.Windows.Forms.ToolStripMenuItem menu_MemberInfoManage;
        private System.Windows.Forms.ToolStripMenuItem menu_UserManage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem 前台接待ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Order;
        private System.Windows.Forms.ToolStripMenuItem menu_PlayMusic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Name;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_PlayMusic;
        private System.Windows.Forms.ToolStripButton btn_Order;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_MemberInfoManage;
        private System.Windows.Forms.ToolStripButton btn_TeaInfoManage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menu_TeaInfoQuery;
        private System.Windows.Forms.ToolStripMenuItem 会员信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息查询ToolStripMenuItem;
    }
}