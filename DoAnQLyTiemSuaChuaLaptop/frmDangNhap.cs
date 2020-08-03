using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLyTiemSuaChuaLaptop.Modules;
namespace DoAnQLyTiemSuaChuaLaptop
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }
        bool capnhat;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        frmMain fMain = null;
        XLNHANVIEN tblNHANVIEN;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            tblNHANVIEN = new XLNHANVIEN();
            DataRow[] r =tblNHANVIEN.Select("Username='" + tbTK.Text + "' and Password ='" + tbMK.Text + "'");
            if (r.Count()>0)
            {

                fMain.Text = "Quản lý Tiệm Sửa Chữa Laptop - Chào " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !!!");
            }
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btnDN_Click(sender, e);

            }
        }
    }
}
