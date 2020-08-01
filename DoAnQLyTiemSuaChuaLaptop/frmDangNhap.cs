using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLyTiemSuaChuaLaptop
{
    public partial class frmDangNhap : Form
    {
        frmMain fMain = null;
        DataTable tblNHANVIEN;
        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            tblNHANVIEN = new DataTable();
            DataRow[] r = tblNHANVIEN.Select("Username='" + tbTK.Text + "' and Password ='" + tbMK.Text + "'");
            if(r.Count()>0)
            {
                fMain.Text = "Quản lý Tiệm Sửa Chữa Laptop - Chào " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                this.Close();
            }
        }
    }
}
