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
        DataTable tblDONHANG,tblCTHD;
        SqlDataAdapter daDH;
        BindingManagerBase bindDH;
        private void dgvDonHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDonHang.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        private void loadDSKH()
        {
            
        }
        bool capnhat;
        private void addColCTHD()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblDONHANG, tblCTHD });
            DataRelation qh = new DataRelation("FRK_DONHANG_CTHD", tblDONHANG.Columns["MaDH"], tblCTHD.Columns["MaDH"]);
            ds.Relations.Add(qh);
            DataColumn cot_SoTien = new DataColumn("SoTien", Type.GetType("System.String"), "Parent(FRK_DONHANG_CTHD).SoTien");
            DataColumn cot_TenDichVu = new DataColumn("TenDichVu", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).TenDichVu");
            DataColumn cot_HinhThucSua = new DataColumn("HinhThucSua", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).HinhThucSua)");
            DataColumn cot_TrangThai = new DataColumn("TrangThai", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).TrangThai)");
            tblCTHD.Columns.Add(cot_SoTien);
            tblCTHD.Columns.Add(cot_TenDichVu);
            tblCTHD.Columns.Add(cot_HinhThucSua);
            tblCTHD.Columns.Add(cot_TrangThai);
        }
        private void loadDONHANG()
        {
            tbMaDH.DataBindings.Add("text", tblDONHANG, "MaNV", true);
            tbTenKH.DataBindings.Add("text", tblDONHANG, "TenNV", true);
            dateNLap.DataBindings.Add("value", tblDONHANG, "NgayLa", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "TenMay", true);
            tbTTM.DataBindings.Add("text", tblDONHANG, "TrinhTrangMay", true);
            bindDH = this.BindingContext[tblDONHANG];
        }

        private void loadKH()
        {
            bindDH = this.BindingContext[tblDONHANG];
            dgvDonHang.AutoGenerateColumns = false;
            dgvDonHang.DataSource = tblDONHANG;

        }

        private void frmDonhang_Load(object sender, EventArgs e)
        {
            tblDONHANG = new DataTable();
            tblCTHD = new DataTable();
            daDH = new SqlDataAdapter("Select * from DONHANG", Modules.cnnStr);
            try
            {
                daDH.Fill(tblDONHANG);

                SqlCommandBuilder cmdDH = new SqlCommandBuilder(daDH);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadDONHANG();
            addColCTHD();
            capnhat = false;
        }
    }
}
