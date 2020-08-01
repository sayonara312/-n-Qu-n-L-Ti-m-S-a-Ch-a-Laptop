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
namespace DoAnQLyTiemSuaChuaLaptop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
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
                frmDonhang f = new frmDonhang();
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
    }
}
