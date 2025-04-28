namespace TeaShopMIS
{
    partial class Frm_Order
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
            this.lv_TeaInfo = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Remark1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Price_Large = new System.Windows.Forms.Label();
            this.lbl_Price_Medium = new System.Windows.Forms.Label();
            this.lbl_Price_Small = new System.Windows.Forms.Label();
            this.lbl_TeaName = new System.Windows.Forms.Label();
            this.btn_AppendtoOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.rb_Medium = new System.Windows.Forms.RadioButton();
            this.rb_Large = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Small = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Payway4 = new System.Windows.Forms.RadioButton();
            this.rb_Payway3 = new System.Windows.Forms.RadioButton();
            this.rb_Payway1 = new System.Windows.Forms.RadioButton();
            this.txt_Remark2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_DiscountRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CancelOrder = new System.Windows.Forms.Button();
            this.txt_PaidUpMoney = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_DiscountMoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DueMoney = new System.Windows.Forms.TextBox();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.btn_plus2 = new System.Windows.Forms.Button();
            this.btn_minus2 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lv_OrderInfo = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiscountRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_TeaInfo
            // 
            this.lv_TeaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_TeaInfo.HideSelection = false;
            this.lv_TeaInfo.LargeImageList = this.imageList1;
            this.lv_TeaInfo.Location = new System.Drawing.Point(6, 43);
            this.lv_TeaInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lv_TeaInfo.MultiSelect = false;
            this.lv_TeaInfo.Name = "lv_TeaInfo";
            this.lv_TeaInfo.Size = new System.Drawing.Size(1228, 563);
            this.lv_TeaInfo.SmallImageList = this.imageList1;
            this.lv_TeaInfo.StateImageList = this.imageList1;
            this.lv_TeaInfo.TabIndex = 9;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.SelectedIndexChanged += new System.EventHandler(this.lv_TeaInfo_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Remark1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_Price_Large);
            this.groupBox1.Controls.Add(this.lbl_Price_Medium);
            this.groupBox1.Controls.Add(this.lbl_Price_Small);
            this.groupBox1.Controls.Add(this.lbl_TeaName);
            this.groupBox1.Controls.Add(this.btn_AppendtoOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_minus);
            this.groupBox1.Controls.Add(this.btn_plus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.rb_Medium);
            this.groupBox1.Controls.Add(this.rb_Large);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_Small);
            this.groupBox1.Controls.Add(this.lv_TeaInfo);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(43, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1240, 1009);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择饮品信息";
            // 
            // txt_Remark1
            // 
            this.txt_Remark1.Location = new System.Drawing.Point(534, 871);
            this.txt_Remark1.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Remark1.Name = "txt_Remark1";
            this.txt_Remark1.Size = new System.Drawing.Size(374, 44);
            this.txt_Remark1.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 873);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 33);
            this.label9.TabIndex = 42;
            this.label9.Text = "备注：";
            // 
            // lbl_Price_Large
            // 
            this.lbl_Price_Large.AutoSize = true;
            this.lbl_Price_Large.Location = new System.Drawing.Point(814, 788);
            this.lbl_Price_Large.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Price_Large.Name = "lbl_Price_Large";
            this.lbl_Price_Large.Size = new System.Drawing.Size(31, 33);
            this.lbl_Price_Large.TabIndex = 35;
            this.lbl_Price_Large.Text = "0";
            // 
            // lbl_Price_Medium
            // 
            this.lbl_Price_Medium.AutoSize = true;
            this.lbl_Price_Medium.Location = new System.Drawing.Point(670, 788);
            this.lbl_Price_Medium.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Price_Medium.Name = "lbl_Price_Medium";
            this.lbl_Price_Medium.Size = new System.Drawing.Size(31, 33);
            this.lbl_Price_Medium.TabIndex = 34;
            this.lbl_Price_Medium.Text = "0";
            // 
            // lbl_Price_Small
            // 
            this.lbl_Price_Small.AutoSize = true;
            this.lbl_Price_Small.Location = new System.Drawing.Point(526, 788);
            this.lbl_Price_Small.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Price_Small.Name = "lbl_Price_Small";
            this.lbl_Price_Small.Size = new System.Drawing.Size(31, 33);
            this.lbl_Price_Small.TabIndex = 33;
            this.lbl_Price_Small.Text = "0";
            // 
            // lbl_TeaName
            // 
            this.lbl_TeaName.AutoSize = true;
            this.lbl_TeaName.Location = new System.Drawing.Point(568, 696);
            this.lbl_TeaName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TeaName.Name = "lbl_TeaName";
            this.lbl_TeaName.Size = new System.Drawing.Size(79, 33);
            this.lbl_TeaName.TabIndex = 32;
            this.lbl_TeaName.Text = "绿茶";
            // 
            // btn_AppendtoOrder
            // 
            this.btn_AppendtoOrder.Location = new System.Drawing.Point(940, 771);
            this.btn_AppendtoOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AppendtoOrder.Name = "btn_AppendtoOrder";
            this.btn_AppendtoOrder.Size = new System.Drawing.Size(231, 70);
            this.btn_AppendtoOrder.TabIndex = 31;
            this.btn_AppendtoOrder.Text = "加入订单";
            this.btn_AppendtoOrder.UseVisualStyleBackColor = true;
            this.btn_AppendtoOrder.Click += new System.EventHandler(this.btn_AppendtoOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 788);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "价格：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 652);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 302);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(696, 819);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(6);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(46, 46);
            this.btn_minus.TabIndex = 28;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(556, 819);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(6);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(46, 46);
            this.btn_plus.TabIndex = 27;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 830);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 25;
            this.label5.Text = "数量：";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(614, 823);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.ReadOnly = true;
            this.txt_Quantity.Size = new System.Drawing.Size(66, 44);
            this.txt_Quantity.TabIndex = 26;
            this.txt_Quantity.Text = "1";
            // 
            // rb_Medium
            // 
            this.rb_Medium.AutoSize = true;
            this.rb_Medium.Location = new System.Drawing.Point(670, 738);
            this.rb_Medium.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Medium.Name = "rb_Medium";
            this.rb_Medium.Size = new System.Drawing.Size(110, 37);
            this.rb_Medium.TabIndex = 13;
            this.rb_Medium.TabStop = true;
            this.rb_Medium.Text = "中份";
            this.rb_Medium.UseVisualStyleBackColor = true;
            // 
            // rb_Large
            // 
            this.rb_Large.AutoSize = true;
            this.rb_Large.Location = new System.Drawing.Point(814, 738);
            this.rb_Large.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Large.Name = "rb_Large";
            this.rb_Large.Size = new System.Drawing.Size(110, 37);
            this.rb_Large.TabIndex = 12;
            this.rb_Large.TabStop = true;
            this.rb_Large.Text = "大份";
            this.rb_Large.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 696);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "饮品名称：";
            // 
            // rb_Small
            // 
            this.rb_Small.AutoSize = true;
            this.rb_Small.Checked = true;
            this.rb_Small.Location = new System.Drawing.Point(526, 738);
            this.rb_Small.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Small.Name = "rb_Small";
            this.rb_Small.Size = new System.Drawing.Size(110, 37);
            this.rb_Small.TabIndex = 10;
            this.rb_Small.TabStop = true;
            this.rb_Small.Text = "小份";
            this.rb_Small.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(872, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "HEY TEAER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Payway4);
            this.groupBox2.Controls.Add(this.rb_Payway3);
            this.groupBox2.Controls.Add(this.rb_Payway1);
            this.groupBox2.Controls.Add(this.txt_Remark2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_DiscountRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_CancelOrder);
            this.groupBox2.Controls.Add(this.txt_PaidUpMoney);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_DiscountMoney);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_DueMoney);
            this.groupBox2.Controls.Add(this.txt_MemberNumber);
            this.groupBox2.Controls.Add(this.btn_plus2);
            this.groupBox2.Controls.Add(this.btn_minus2);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_Pay);
            this.groupBox2.Controls.Add(this.lv_OrderInfo);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1343, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(602, 1002);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单信息";
            // 
            // rb_Payway4
            // 
            this.rb_Payway4.AutoSize = true;
            this.rb_Payway4.Location = new System.Drawing.Point(486, 834);
            this.rb_Payway4.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Payway4.Name = "rb_Payway4";
            this.rb_Payway4.Size = new System.Drawing.Size(110, 37);
            this.rb_Payway4.TabIndex = 55;
            this.rb_Payway4.Text = "微信";
            this.rb_Payway4.UseVisualStyleBackColor = true;
            // 
            // rb_Payway3
            // 
            this.rb_Payway3.AutoSize = true;
            this.rb_Payway3.Location = new System.Drawing.Point(320, 834);
            this.rb_Payway3.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Payway3.Name = "rb_Payway3";
            this.rb_Payway3.Size = new System.Drawing.Size(142, 37);
            this.rb_Payway3.TabIndex = 54;
            this.rb_Payway3.Text = "支付宝";
            this.rb_Payway3.UseVisualStyleBackColor = true;
            // 
            // rb_Payway1
            // 
            this.rb_Payway1.AutoSize = true;
            this.rb_Payway1.Checked = true;
            this.rb_Payway1.Location = new System.Drawing.Point(198, 834);
            this.rb_Payway1.Margin = new System.Windows.Forms.Padding(6);
            this.rb_Payway1.Name = "rb_Payway1";
            this.rb_Payway1.Size = new System.Drawing.Size(110, 37);
            this.rb_Payway1.TabIndex = 53;
            this.rb_Payway1.TabStop = true;
            this.rb_Payway1.Text = "现金";
            this.rb_Payway1.UseVisualStyleBackColor = true;
            // 
            // txt_Remark2
            // 
            this.txt_Remark2.Location = new System.Drawing.Point(191, 466);
            this.txt_Remark2.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Remark2.Name = "txt_Remark2";
            this.txt_Remark2.Size = new System.Drawing.Size(310, 44);
            this.txt_Remark2.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 469);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 33);
            this.label13.TabIndex = 51;
            this.label13.Text = "订单备注：";
            // 
            // txt_DiscountRate
            // 
            this.txt_DiscountRate.Location = new System.Drawing.Point(191, 655);
            this.txt_DiscountRate.Margin = new System.Windows.Forms.Padding(6);
            this.txt_DiscountRate.Name = "txt_DiscountRate";
            this.txt_DiscountRate.Size = new System.Drawing.Size(312, 44);
            this.txt_DiscountRate.TabIndex = 50;
            this.txt_DiscountRate.Leave += new System.EventHandler(this.txt_DiscountRate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 657);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "%";
            // 
            // btn_CancelOrder
            // 
            this.btn_CancelOrder.Location = new System.Drawing.Point(323, 922);
            this.btn_CancelOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btn_CancelOrder.Name = "btn_CancelOrder";
            this.btn_CancelOrder.Size = new System.Drawing.Size(150, 46);
            this.btn_CancelOrder.TabIndex = 48;
            this.btn_CancelOrder.Text = "重  置";
            this.btn_CancelOrder.UseVisualStyleBackColor = true;
            this.btn_CancelOrder.Click += new System.EventHandler(this.btn_CancelOrder_Click);
            // 
            // txt_PaidUpMoney
            // 
            this.txt_PaidUpMoney.Location = new System.Drawing.Point(191, 773);
            this.txt_PaidUpMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txt_PaidUpMoney.Name = "txt_PaidUpMoney";
            this.txt_PaidUpMoney.Size = new System.Drawing.Size(308, 44);
            this.txt_PaidUpMoney.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 784);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 33);
            this.label12.TabIndex = 46;
            this.label12.Text = "实收金额：";
            // 
            // txt_DiscountMoney
            // 
            this.txt_DiscountMoney.Location = new System.Drawing.Point(191, 711);
            this.txt_DiscountMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txt_DiscountMoney.Name = "txt_DiscountMoney";
            this.txt_DiscountMoney.Size = new System.Drawing.Size(308, 44);
            this.txt_DiscountMoney.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 722);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 33);
            this.label11.TabIndex = 44;
            this.label11.Text = "折扣金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 657);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 33);
            this.label10.TabIndex = 42;
            this.label10.Text = "折扣比例：";
            // 
            // txt_DueMoney
            // 
            this.txt_DueMoney.Location = new System.Drawing.Point(191, 594);
            this.txt_DueMoney.Margin = new System.Windows.Forms.Padding(6);
            this.txt_DueMoney.Name = "txt_DueMoney";
            this.txt_DueMoney.ReadOnly = true;
            this.txt_DueMoney.Size = new System.Drawing.Size(308, 44);
            this.txt_DueMoney.TabIndex = 41;
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(191, 532);
            this.txt_MemberNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(308, 44);
            this.txt_MemberNumber.TabIndex = 40;
            // 
            // btn_plus2
            // 
            this.btn_plus2.Location = new System.Drawing.Point(50, 376);
            this.btn_plus2.Margin = new System.Windows.Forms.Padding(6);
            this.btn_plus2.Name = "btn_plus2";
            this.btn_plus2.Size = new System.Drawing.Size(108, 46);
            this.btn_plus2.TabIndex = 32;
            this.btn_plus2.Text = "+1";
            this.btn_plus2.UseVisualStyleBackColor = true;
            this.btn_plus2.Click += new System.EventHandler(this.btn_plus2_Click);
            // 
            // btn_minus2
            // 
            this.btn_minus2.Location = new System.Drawing.Point(203, 376);
            this.btn_minus2.Margin = new System.Windows.Forms.Padding(6);
            this.btn_minus2.Name = "btn_minus2";
            this.btn_minus2.Size = new System.Drawing.Size(108, 46);
            this.btn_minus2.TabIndex = 33;
            this.btn_minus2.Text = "-1";
            this.btn_minus2.UseVisualStyleBackColor = true;
            this.btn_minus2.Click += new System.EventHandler(this.btn_minus2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(365, 376);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 46);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "移除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 838);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 33);
            this.label8.TabIndex = 36;
            this.label8.Text = "付款方式：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 597);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 33);
            this.label7.TabIndex = 35;
            this.label7.Text = "订单金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 535);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 34;
            this.label6.Text = "会员卡号：";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(104, 922);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(185, 46);
            this.btn_Pay.TabIndex = 32;
            this.btn_Pay.Text = "确定支付";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lv_OrderInfo
            // 
            this.lv_OrderInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lv_OrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_OrderInfo.FullRowSelect = true;
            this.lv_OrderInfo.GridLines = true;
            this.lv_OrderInfo.HideSelection = false;
            this.lv_OrderInfo.Location = new System.Drawing.Point(6, 43);
            this.lv_OrderInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lv_OrderInfo.MultiSelect = false;
            this.lv_OrderInfo.Name = "lv_OrderInfo";
            this.lv_OrderInfo.Size = new System.Drawing.Size(590, 305);
            this.lv_OrderInfo.TabIndex = 32;
            this.lv_OrderInfo.UseCompatibleStateImageBehavior = false;
            this.lv_OrderInfo.View = System.Windows.Forms.View.Details;
            this.lv_OrderInfo.SelectedIndexChanged += new System.EventHandler(this.lv_OrderInfo_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No";
            this.columnHeader8.Width = 30;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "饮品名称";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "规格";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "价格";
            this.columnHeader11.Width = 40;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "数量";
            this.columnHeader12.Width = 40;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "备注";
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 1209);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Order";
            this.Text = "点餐收银";
            this.Load += new System.EventHandler(this.Frm_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiscountRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_TeaInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AppendtoOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.RadioButton rb_Medium;
        private System.Windows.Forms.RadioButton rb_Large;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Small;
        private System.Windows.Forms.ListView lv_OrderInfo;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_plus2;
        private System.Windows.Forms.Button btn_minus2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_Price_Large;
        private System.Windows.Forms.Label lbl_Price_Medium;
        private System.Windows.Forms.Label lbl_Price_Small;
        private System.Windows.Forms.Label lbl_TeaName;
        private System.Windows.Forms.TextBox txt_DueMoney;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.TextBox txt_Remark1;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_CancelOrder;
        private System.Windows.Forms.TextBox txt_PaidUpMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_DiscountMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_DiscountRate;
        private System.Windows.Forms.TextBox txt_Remark2;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_Payway4;
        private System.Windows.Forms.RadioButton rb_Payway3;
        private System.Windows.Forms.RadioButton rb_Payway1;
    }
}