namespace SieuThiPhuongNam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userControl11 = new SieuThiPhuongNam.UserControl1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.tboxTimKiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMucGia = new System.Windows.Forms.Panel();
            this.rbTren10Trieu = new System.Windows.Forms.RadioButton();
            this.rbDuoi10Trieu = new System.Windows.Forms.RadioButton();
            this.rbDuoi5Trieu = new System.Windows.Forms.RadioButton();
            this.rbDuoi2Trieu = new System.Windows.Forms.RadioButton();
            this.rbTatCaMucGia = new System.Windows.Forms.RadioButton();
            this.panelHang = new System.Windows.Forms.Panel();
            this.rbTatCaHang = new System.Windows.Forms.RadioButton();
            this.rbHTC = new System.Windows.Forms.RadioButton();
            this.rbAsus = new System.Windows.Forms.RadioButton();
            this.rbSony = new System.Windows.Forms.RadioButton();
            this.rbApple = new System.Windows.Forms.RadioButton();
            this.rbSamsung = new System.Windows.Forms.RadioButton();
            this.panelHDH = new System.Windows.Forms.Panel();
            this.rbTatCaHDH = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbIOS = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelItems = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMucGia.SuspendLayout();
            this.panelHang.SuspendLayout();
            this.panelHDH.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userControl11);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(845, 402);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.BackColor = System.Drawing.SystemColors.Control;
            this.userControl11.BackImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackImage")));
            this.userControl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl11.Location = new System.Drawing.Point(731, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(105, 72);
            this.userControl11.State_DefaultImage = System.Drawing.Color.Empty;
            this.userControl11.State_HoveringImage = System.Drawing.Color.Empty;
            this.userControl11.State_PressedImage = System.Drawing.Color.Empty;
            this.userControl11.TabIndex = 7;
            this.userControl11.Title = "Chức Năng";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.pictureSearch);
            this.panel1.Controls.Add(this.tboxTimKiem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 76);
            this.panel1.TabIndex = 6;
            // 
            // pictureSearch
            // 
            this.pictureSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSearch.BackColor = System.Drawing.Color.White;
            this.pictureSearch.Image = global::SieuThiPhuongNam.Properties.Resources.search;
            this.pictureSearch.Location = new System.Drawing.Point(508, 24);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(25, 25);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSearch.TabIndex = 2;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.pictureSearch_Click);
            this.pictureSearch.MouseEnter += new System.EventHandler(this.pictureSearch_MouseEnter);
            this.pictureSearch.MouseLeave += new System.EventHandler(this.pictureSearch_MouseLeave);
            // 
            // tboxTimKiem
            // 
            this.tboxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTimKiem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTimKiem.Location = new System.Drawing.Point(22, 24);
            this.tboxTimKiem.Name = "tboxTimKiem";
            this.tboxTimKiem.Size = new System.Drawing.Size(486, 26);
            this.tboxTimKiem.TabIndex = 0;
            this.tboxTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxTimKiem_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(577, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panelMucGia, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelHang, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelHDH, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 323);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelMucGia
            // 
            this.panelMucGia.Controls.Add(this.rbTren10Trieu);
            this.panelMucGia.Controls.Add(this.rbDuoi10Trieu);
            this.panelMucGia.Controls.Add(this.rbDuoi5Trieu);
            this.panelMucGia.Controls.Add(this.rbDuoi2Trieu);
            this.panelMucGia.Controls.Add(this.rbTatCaMucGia);
            this.panelMucGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMucGia.Location = new System.Drawing.Point(565, 3);
            this.panelMucGia.Name = "panelMucGia";
            this.panelMucGia.Size = new System.Drawing.Size(277, 317);
            this.panelMucGia.TabIndex = 4;
            // 
            // rbTren10Trieu
            // 
            this.rbTren10Trieu.AutoSize = true;
            this.rbTren10Trieu.Location = new System.Drawing.Point(3, 115);
            this.rbTren10Trieu.Name = "rbTren10Trieu";
            this.rbTren10Trieu.Size = new System.Drawing.Size(69, 17);
            this.rbTren10Trieu.TabIndex = 0;
            this.rbTren10Trieu.Text = "> 10 triệu";
            this.rbTren10Trieu.UseVisualStyleBackColor = true;
            this.rbTren10Trieu.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbDuoi10Trieu
            // 
            this.rbDuoi10Trieu.AutoSize = true;
            this.rbDuoi10Trieu.Location = new System.Drawing.Point(3, 87);
            this.rbDuoi10Trieu.Name = "rbDuoi10Trieu";
            this.rbDuoi10Trieu.Size = new System.Drawing.Size(69, 17);
            this.rbDuoi10Trieu.TabIndex = 0;
            this.rbDuoi10Trieu.Text = "< 10 triệu";
            this.rbDuoi10Trieu.UseVisualStyleBackColor = true;
            this.rbDuoi10Trieu.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbDuoi5Trieu
            // 
            this.rbDuoi5Trieu.AutoSize = true;
            this.rbDuoi5Trieu.Location = new System.Drawing.Point(3, 59);
            this.rbDuoi5Trieu.Name = "rbDuoi5Trieu";
            this.rbDuoi5Trieu.Size = new System.Drawing.Size(63, 17);
            this.rbDuoi5Trieu.TabIndex = 0;
            this.rbDuoi5Trieu.Text = "< 5 triệu";
            this.rbDuoi5Trieu.UseVisualStyleBackColor = true;
            this.rbDuoi5Trieu.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbDuoi2Trieu
            // 
            this.rbDuoi2Trieu.AutoSize = true;
            this.rbDuoi2Trieu.Location = new System.Drawing.Point(3, 31);
            this.rbDuoi2Trieu.Name = "rbDuoi2Trieu";
            this.rbDuoi2Trieu.Size = new System.Drawing.Size(63, 17);
            this.rbDuoi2Trieu.TabIndex = 0;
            this.rbDuoi2Trieu.Text = "< 2 triệu";
            this.rbDuoi2Trieu.UseVisualStyleBackColor = true;
            this.rbDuoi2Trieu.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbTatCaMucGia
            // 
            this.rbTatCaMucGia.AutoSize = true;
            this.rbTatCaMucGia.Checked = true;
            this.rbTatCaMucGia.Location = new System.Drawing.Point(3, 3);
            this.rbTatCaMucGia.Name = "rbTatCaMucGia";
            this.rbTatCaMucGia.Size = new System.Drawing.Size(41, 17);
            this.rbTatCaMucGia.TabIndex = 0;
            this.rbTatCaMucGia.TabStop = true;
            this.rbTatCaMucGia.Text = "Tất Cả Giá";
            this.rbTatCaMucGia.UseVisualStyleBackColor = true;
            this.rbTatCaMucGia.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // panelHang
            // 
            this.panelHang.Controls.Add(this.rbTatCaHang);
            this.panelHang.Controls.Add(this.rbHTC);
            this.panelHang.Controls.Add(this.rbAsus);
            this.panelHang.Controls.Add(this.rbSony);
            this.panelHang.Controls.Add(this.rbApple);
            this.panelHang.Controls.Add(this.rbSamsung);
            this.panelHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHang.Location = new System.Drawing.Point(284, 3);
            this.panelHang.Name = "panelHang";
            this.panelHang.Size = new System.Drawing.Size(275, 317);
            this.panelHang.TabIndex = 5;
            // 
            // rbTatCaHang
            // 
            this.rbTatCaHang.AutoSize = true;
            this.rbTatCaHang.Checked = true;
            this.rbTatCaHang.Location = new System.Drawing.Point(3, 3);
            this.rbTatCaHang.Name = "rbTatCaHang";
            this.rbTatCaHang.Size = new System.Drawing.Size(51, 17);
            this.rbTatCaHang.TabIndex = 0;
            this.rbTatCaHang.TabStop = true;
            this.rbTatCaHang.Text = "Tất Cả Hãng";
            this.rbTatCaHang.UseVisualStyleBackColor = true;
            this.rbTatCaHang.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbHTC
            // 
            this.rbHTC.AutoSize = true;
            this.rbHTC.Location = new System.Drawing.Point(6, 123);
            this.rbHTC.Name = "rbHTC";
            this.rbHTC.Size = new System.Drawing.Size(47, 17);
            this.rbHTC.TabIndex = 0;
            this.rbHTC.Text = "HTC";
            this.rbHTC.UseVisualStyleBackColor = true;
            this.rbHTC.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbAsus
            // 
            this.rbAsus.AutoSize = true;
            this.rbAsus.Location = new System.Drawing.Point(5, 54);
            this.rbAsus.Name = "rbAsus";
            this.rbAsus.Size = new System.Drawing.Size(54, 17);
            this.rbAsus.TabIndex = 0;
            this.rbAsus.Text = "ASUS";
            this.rbAsus.UseVisualStyleBackColor = true;
            this.rbAsus.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbSony
            // 
            this.rbSony.AutoSize = true;
            this.rbSony.Location = new System.Drawing.Point(5, 100);
            this.rbSony.Name = "rbSony";
            this.rbSony.Size = new System.Drawing.Size(49, 17);
            this.rbSony.TabIndex = 0;
            this.rbSony.Text = "Sony";
            this.rbSony.UseVisualStyleBackColor = true;
            this.rbSony.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbApple
            // 
            this.rbApple.AutoSize = true;
            this.rbApple.Location = new System.Drawing.Point(5, 31);
            this.rbApple.Name = "rbApple";
            this.rbApple.Size = new System.Drawing.Size(52, 17);
            this.rbApple.TabIndex = 0;
            this.rbApple.Text = "Apple";
            this.rbApple.UseVisualStyleBackColor = true;
            this.rbApple.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbSamsung
            // 
            this.rbSamsung.AutoSize = true;
            this.rbSamsung.Location = new System.Drawing.Point(5, 77);
            this.rbSamsung.Name = "rbSamsung";
            this.rbSamsung.Size = new System.Drawing.Size(69, 17);
            this.rbSamsung.TabIndex = 0;
            this.rbSamsung.Text = "Samsung";
            this.rbSamsung.UseVisualStyleBackColor = true;
            this.rbSamsung.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // panelHDH
            // 
            this.panelHDH.Controls.Add(this.rbTatCaHDH);
            this.panelHDH.Controls.Add(this.rbAndroid);
            this.panelHDH.Controls.Add(this.rbIOS);
            this.panelHDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHDH.Location = new System.Drawing.Point(3, 3);
            this.panelHDH.Name = "panelHDH";
            this.panelHDH.Size = new System.Drawing.Size(275, 317);
            this.panelHDH.TabIndex = 6;
            // 
            // rbTatCaHDH
            // 
            this.rbTatCaHDH.AutoSize = true;
            this.rbTatCaHDH.Checked = true;
            this.rbTatCaHDH.Location = new System.Drawing.Point(3, 3);
            this.rbTatCaHDH.Name = "rbTatCaHDH";
            this.rbTatCaHDH.Size = new System.Drawing.Size(93, 17);
            this.rbTatCaHDH.TabIndex = 0;
            this.rbTatCaHDH.TabStop = true;
            this.rbTatCaHDH.Text = "Tất Cả HĐH";
            this.rbTatCaHDH.UseVisualStyleBackColor = true;
            this.rbTatCaHDH.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(3, 31);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(61, 17);
            this.rbAndroid.TabIndex = 0;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            this.rbAndroid.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // rbIOS
            // 
            this.rbIOS.AutoSize = true;
            this.rbIOS.Location = new System.Drawing.Point(3, 59);
            this.rbIOS.Name = "rbIOS";
            this.rbIOS.Size = new System.Drawing.Size(42, 17);
            this.rbIOS.TabIndex = 0;
            this.rbIOS.Text = "iOS";
            this.rbIOS.UseVisualStyleBackColor = true;
            this.rbIOS.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tablePanelItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 531);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tablePanelItems
            // 
            this.tablePanelItems.AutoScroll = true;
            this.tablePanelItems.AutoSize = true;
            this.tablePanelItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelItems.ColumnCount = 5;
            this.tablePanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelItems.Location = new System.Drawing.Point(3, 411);
            this.tablePanelItems.Name = "tablePanelItems";
            this.tablePanelItems.RowCount = 1;
            this.tablePanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tablePanelItems.Size = new System.Drawing.Size(845, 117);
            this.tablePanelItems.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Siêu Thị Di Động Phương Nam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelMucGia.ResumeLayout(false);
            this.panelMucGia.PerformLayout();
            this.panelHang.ResumeLayout(false);
            this.panelHang.PerformLayout();
            this.panelHDH.ResumeLayout(false);
            this.panelHDH.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.TextBox tboxTimKiem;
        private System.Windows.Forms.Panel panelMucGia;
        private System.Windows.Forms.RadioButton rbTren10Trieu;
        private System.Windows.Forms.RadioButton rbDuoi10Trieu;
        private System.Windows.Forms.RadioButton rbDuoi5Trieu;
        private System.Windows.Forms.RadioButton rbDuoi2Trieu;
        private System.Windows.Forms.RadioButton rbTatCaMucGia;
        private System.Windows.Forms.Panel panelHang;
        private System.Windows.Forms.RadioButton rbTatCaHang;
        private System.Windows.Forms.RadioButton rbHTC;
        private System.Windows.Forms.RadioButton rbAsus;
        private System.Windows.Forms.RadioButton rbSony;
        private System.Windows.Forms.RadioButton rbApple;
        private System.Windows.Forms.RadioButton rbSamsung;
        private System.Windows.Forms.Panel panelHDH;
        private System.Windows.Forms.RadioButton rbTatCaHDH;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbIOS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tablePanelItems;
        private UserControl1 userControl11;
    }
}

