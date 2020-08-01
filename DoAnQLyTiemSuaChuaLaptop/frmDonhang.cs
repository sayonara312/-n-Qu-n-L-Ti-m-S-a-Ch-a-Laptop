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
    public partial class frmDonhang : Form
    {
        public frmDonhang()
        {
            InitializeComponent();
        }
        DataTable tblDONHANG;
        DataTable tblMaCTHD;
        SqlDataAdapter daDH;
        private void dgvDonHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDonHang.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        BindingManagerBase bindDH;
        bool capnhat;
        private void loadDSNV()
        {
            tbMaDH.DataBindings.Add("text", tblDONHANG, "MaNV", true);
            tbSDT.DataBindings.Add("text", tblDONHANG, "SoDT", true);
            tbTenKH.DataBindings.Add("text", tblDONHANG, "TenNV", true);
            tbKTS.DataBindings.Add("text", tblMaCTHD, "HinhThucSua", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "Email", true);
            dateNLap.DataBindings.Add("text", tblDONHANG, "NgayLap", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "TenMay", true);
            tbTTM.DataBindings.Add("text", tblDONHANG, "TrinhTrangMay", true);
            cbTrangThai.DataBindings.Add("text", tblMaCTHD, "TrangThai", true);
            tbTenDV.DataBindings.Add("text", tblMaCTHD, "TenDichVu", true);
            tbSoTien.DataBindings.Add("text", tblMaCTHD, "SoTien", true);
            bindDH = this.BindingContext[tblDONHANG];
            bindDH = this.BindingContext[tblMaCTHD];

        }
        private void loadKH()
        {
            bindDH = this.BindingContext[tblDONHANG];
            dgvDonHang.AutoGenerateColumns = false;
            dgvDonHang.DataSource = tblDONHANG;


        }
    }
}
