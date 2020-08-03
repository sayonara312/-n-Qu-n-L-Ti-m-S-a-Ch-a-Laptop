using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnQLyTiemSuaChuaLaptop.Modules;
namespace DoAnQLyTiemSuaChuaLaptop
{
    
    public partial class frmMain : Form
    {
        public string maNV;
        public frmMain()
        {
            InitializeComponent();
        }
        bool capnhat;
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageQLNhanVien");
            if(index>=0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageQLNhanVien";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();
                
            }

        }
        public void enabledbutton()
        {
            btnDangXuat.Enabled = !capnhat;
            btnDoiMatKhau.Enabled = !capnhat;
            btnDonHang.Enabled = !capnhat;
            btnKhachHang.Enabled = !capnhat;
            btnNhanVien.Enabled = !capnhat;
            btnChamCong.Enabled = !capnhat;
            
        }
        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageQLKHACHHANG");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageQLKHACHHANG";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();

            }
        }

        private void btnDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageQLDONHANG");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                frmDonHang f = new frmDonHang();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageQLDONHANG";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();

            }

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl1.TabPages.Clear();
            frmMain_Load(sender, e);
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageDoiMatKhau");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;
            }
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageChamCong");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;
            }
            else
            {
                frmChamCong f = new frmChamCong();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageChamCong";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageLienHe");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;
            }
            else
            {
                frmLienHe f = new frmLienHe();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageLienHe";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabPageTroGiup");
            if (index >= 0)
            {
                tabControl1.SelectedIndex = index;
            }
            else
            {
                frmTroGiup f = new frmTroGiup();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageTroGiup";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                f.Show();
            }
        }
    }
}
