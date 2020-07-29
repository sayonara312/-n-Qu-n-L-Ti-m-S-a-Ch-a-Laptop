namespace DoAnQLyTiemSuaChuaLaptop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 423);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 27);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangXuat,
            this.btnNhanVien,
            this.btnDoiMatKhau,
            this.btnKhachHang,
            this.btnDonHang,
            this.btnTaiChinh,
            this.btnInHoaDon,
            this.barButtonItem8,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 2;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 3;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách Hàng";
            this.btnKhachHang.Id = 4;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Caption = "Đơn Hàng";
            this.btnDonHang.Id = 5;
            this.btnDonHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonHang.ImageOptions.Image")));
            this.btnDonHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonHang.ImageOptions.LargeImage")));
            this.btnDonHang.Name = "btnDonHang";
            // 
            // btnTaiChinh
            // 
            this.btnTaiChinh.Caption = "Tài Chính";
            this.btnTaiChinh.Id = 6;
            this.btnTaiChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiChinh.ImageOptions.Image")));
            this.btnTaiChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiChinh.ImageOptions.LargeImage")));
            this.btnTaiChinh.Name = "btnTaiChinh";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Caption = "In Hóa Đơn";
            this.btnInHoaDon.Id = 7;
            this.btnInHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.Image")));
            this.btnInHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.LargeImage")));
            this.btnInHoaDon.Name = "btnInHoaDon";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Trợ Giúp";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Liên Hệ";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Menu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hệ Thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDonHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản Lý";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTaiChinh);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnInHoaDon);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thống Kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hỗ Trợ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Khách Hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 282);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnDonHang;
        private DevExpress.XtraBars.BarButtonItem btnTaiChinh;
        private DevExpress.XtraBars.BarButtonItem btnInHoaDon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

