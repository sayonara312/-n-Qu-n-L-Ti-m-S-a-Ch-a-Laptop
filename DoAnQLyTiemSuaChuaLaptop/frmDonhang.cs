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
        DataTable tblDONHANG, tblCTHD, tblKHACHHANG, tblNHANVIEN;
        SqlDataAdapter daDH, daCTHD, daKH, daNV;
        BindingManagerBase bindDH, bindCTHD, bindKH, bindNV;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bindKH.EndCurrentEdit();
                bindNV.EndCurrentEdit();
                bindCTHD.EndCurrentEdit();
                bindDH.EndCurrentEdit();
                daKH.Update(tblKHACHHANG);
                daCTHD.Update(tblCTHD);
                daDH.Update(tblDONHANG);
                daKH.Update(tblKHACHHANG);
                daNV.Update(tblNHANVIEN);
                tblKHACHHANG.AcceptChanges();
                tblCTHD.AcceptChanges();
                tblDONHANG.AcceptChanges();
                tblNHANVIEN.AcceptChanges();
                MessageBox.Show("Lưu thành công!!!");
                capnhat = false;
                enablebutton();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enablebutton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bindKH.CancelCurrentEdit();
            bindNV.CancelCurrentEdit();
            bindCTHD.CancelCurrentEdit();
            bindDH.CancelCurrentEdit();
            tblKHACHHANG.RejectChanges();
            tblCTHD.RejectChanges();
            tblDONHANG.RejectChanges();
            tblNHANVIEN.RejectChanges();
            capnhat = false;
            enablebutton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = bindKH.Position;
            int index1 = bindNV.Position;
            int index2 = bindCTHD.Position;
            int index3 = bindDH.Position;
            if (index1 >= 0 && index >=0 && index2>=0 && index3 >=0)
                bindKH.RemoveAt(index);
                bindNV.RemoveAt(index1);
                bindCTHD.RemoveAt(index2);
                bindDH.RemoveAt(index3);
        }

        private void dgvDonHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDonHang.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        bool capnhat;


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


        private void addColCTHD()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblDONHANG, tblKHACHHANG, tblCTHD, tblNHANVIEN });
            DataRelation qh = new DataRelation("FRK_DONHANG_CTHD", tblDONHANG.Columns["MaDH"], tblCTHD.Columns["MaDH"]);
            DataRelation qh1 = new DataRelation("FRK_KHACHHANG_CTHD", tblKHACHHANG.Columns["MaKH"], tblCTHD.Columns["MaKH"]);
            DataRelation qh2 = new DataRelation("FRK_NHANVIEN_CTHD", tblNHANVIEN.Columns["MaNV"], tblCTHD.Columns["MaNV"]);
            ds.Relations.Add(qh);
            ds.Relations.Add(qh1);
            ds.Relations.Add(qh2);
            DataColumn cot_TenKH = new DataColumn("TenKH", Type.GetType("System.String"), "Parent(FRK_DONHANG_CTHD).TenKH");
            DataColumn cot_SoDT = new DataColumn("SoDT", Type.GetType("System.String"), "Parent (FRK_KHACHHANG_CTHD).SoDT");
            DataColumn cot_NgayLap = new DataColumn("NgayLap", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).NgayLap");
            DataColumn cot_TrinhTrangMay = new DataColumn("TrinhTrangMay", Type.GetType("System.String"), "Parent (FRK_DONHANG_CTHD).TrinhTrangMay");
            DataColumn cot_TenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent (FRK_NHANVIEN_CTHD).TenNV");
            tblCTHD.Columns.Add(cot_TenKH);
            tblCTHD.Columns.Add(cot_SoDT);
            tblCTHD.Columns.Add(cot_NgayLap);
            tblCTHD.Columns.Add(cot_TenNV);
            tblCTHD.Columns.Add(cot_TrinhTrangMay);
        }


        private void loadCTHD()
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
            daDH = new SqlDataAdapter("Select * from DONHANG", XLDONHANG.cnnStr);
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
            loadCTHD();
            addColCTHD();
            loadDSKH();
            capnhat = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DataRow r = tblCTHD.NewRow();
            r["MaDH"] = tbMaDH.Text;
            r["TenKH"] = tbTenKH.Text;
            r["SoDT"] = tbSDT.Text;
            r["TenNV"] = tbKTS.Text;
            r["NgayLap"] = dateNLap.Value;
            r["TenMay"] = tbTenMay.Text;
            r["TrinhTrangMay"] = tbTTM.Text;
            r["TrangThai"] = cbTrangThai.SelectedText;
            r["TenDichVu"] = tbTenDV.Text;
            r["SoTien"] = tbSoTien.Text;
            tblCTHD.Rows.Add(r);
            capnhat = true;
            enablebutton();
        }
        private void enablebutton()
        {
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            dgvDonHang.Enabled = capnhat;
        }

    }
}
