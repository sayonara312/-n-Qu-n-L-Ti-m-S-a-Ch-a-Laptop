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
    public partial class frmDonhang : Form
    {
        public frmDonhang()
        {
            InitializeComponent();
        }
        DataTable tblDONHANG,tblCTHD,tblKHACHHANG,tblNHANVIEN;
        SqlDataAdapter daDH,daCTHD,daKH,daNV;
        BindingManagerBase bindDH,bindCTHD,bindKH,bindNV;
        private void dgvDonHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDonHang.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        private void loadDSKH()
        {
            tbMaDH.DataBindings.Add("text", tblDONHANG, "MaDH", true);
            tbTenKH.DataBindings.Add("text", tblKHACHHANG, "TenKH", true);
            tbSDT.DataBindings.Add("text", tblKHACHHANG, "SoDT", true);
            tbKTS.DataBindings.Add("text", tblNHANVIEN, "TenNV", true);
            dateNLap.DataBindings.Add("value", tblDONHANG, "NgayLap", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "TenMay", true);
            tbTTM.DataBindings.Add("text", tblDONHANG, "TrinhTrangMay", true);
            tbTenDV.DataBindings.Add("text", tblCTHD, "TenDichVu", true);
            tbSoTien.DataBindings.Add("text", tblCTHD, "SoTien", true);

            bindKH = this.BindingContext[tblKHACHHANG];
            bindDH = this.BindingContext[tblDONHANG];
            bindDH = this.BindingContext[tblNHANVIEN];
        }
        private void loadTrangThai()
        {
            cbTrangThai.DataSource = tblCTHD;
            cbTrangThai.ValueMember = "MaCTHD";
            cbTrangThai.DisplayMember = "TrangThai";
            cbTrangThai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTrangThai.AutoCompleteSource = AutoCompleteSource.ListItems;
           
        }
        bool capnhat;

        private void addColCTHD()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblDONHANG, tblKHACHHANG, tblCTHD, tblNHANVIEN });
            DataRelation qh = new DataRelation("FRK_DONHANG_CTHD", tblDONHANG.Columns["MaDH"], tblCTHD.Columns["MaDH"]);
            DataRelation qh1 = new DataRelation("FRK_KHACHHANG_CTHD", tblKHACHHANG.Columns["MaKH"], tblCTHD.Columns["MaKH"]);
            DataRelation qh2 = new DataRelation("FRK_NHANVIEN_CTHD", tblNHANVIEN.Columns["MaNV"], tblCTHD.Columns["MaNV"]);
            ds.Relations.Add(qh);
            DataColumn cot_SoTien = new DataColumn("SoTien", Type.GetType("System.String"), "Parent(FRK_DONHANG_CTHD).SoTien");
            DataColumn cot_TenDichVu = new DataColumn("TenDichVu", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).TenDichVu");
            DataColumn cot_HinhThucSua = new DataColumn("HinhThucSua", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).HinhThucSua");
            DataColumn cot_TrangThai = new DataColumn("TrangThai", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).TrangThai");
            tblCTHD.Columns.Add(cot_SoTien);
            tblCTHD.Columns.Add(cot_TenDichVu);
            tblCTHD.Columns.Add(cot_HinhThucSua);
            tblCTHD.Columns.Add(cot_TrangThai);
        }
        private void loadDONHANG()
        {
            tbMaDH.DataBindings.Add("text", tblDONHANG, "MaNV", true);
            tbTenKH.DataBindings.Add("text", tblDONHANG, "TenNV", true);
            dateNLap.DataBindings.Add("value", tblDONHANG, "NgayLap", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "TenMay", true);
            tbTTM.DataBindings.Add("text", tblDONHANG, "TrinhTrangMay", true);
            bindDH = this.BindingContext[tblDONHANG];
        }

        private void loadCTDB()
        {
            bindCTHD = this.BindingContext[tblCTHD];
            dgvDonHang.AutoGenerateColumns = false;
            dgvDonHang.DataSource = tblCTHD;
        }


        private void frmDonhang_Load(object sender, EventArgs e)
        {
            tblDONHANG = new DataTable();
            tblKHACHHANG = new DataTable();
            tblNHANVIEN = new DataTable();
            tblCTHD = new DataTable();
            daDH = new SqlDataAdapter("Select * from DONHANG",XLDONHANG.cnnStr);
            daCTHD = new SqlDataAdapter("Select * from CTHD", XLCTHD.cnnStr);
            daKH = new SqlDataAdapter("Select * from KHACHHANG", XLKHACHHANG.cnnStr);
            daNV = new SqlDataAdapter("Select * from NHANVIEN", XLNHANVIEN.cnnStr);
            try
            {
                daNV.Fill(tblNHANVIEN);
                daKH.Fill(tblKHACHHANG);
                daDH.Fill(tblDONHANG);
                daCTHD.Fill(tblCTHD);
                SqlCommandBuilder cmdDH = new SqlCommandBuilder(daDH);
                SqlCommandBuilder cmdCTHD = new SqlCommandBuilder(daCTHD);
                SqlCommandBuilder cmdKH = new SqlCommandBuilder(daKH);
                SqlCommandBuilder cmdNV = new SqlCommandBuilder(daNV);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadTrangThai();
            loadCTDB();
            addColCTHD();
            loadDSKH();
            capnhat = false;
        }


    }
}
