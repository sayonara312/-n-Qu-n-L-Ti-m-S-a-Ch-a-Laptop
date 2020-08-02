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
    public partial class frmDonHang : Form
    {

        public frmDonHang()
        {
            InitializeComponent();
        }
        DataTable tblNHANVIEN,tblDONHANG,tblKHACHHANG,tblCTHD;
        SqlDataAdapter daDH, daCTHD, daKH, daNV;
        bool capnhat;
        private void cbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSDT.SelectedIndex;
            if (index >= 0)
            {
                tbTenKH.Text = tblKHACHHANG.Rows[index]["TenKH"].ToString();
                tbDiaChi.Text = tblKHACHHANG.Rows[index]["DiaChi"].ToString();
            }
            else
            {
                tbTenKH.Text = "";
                tbDiaChi.Text = "";
            }
        }
        private void loadNHANVIEN()
        {
            cbNV.DataSource = tblNHANVIEN;
            cbNV.ValueMember = "MaNV";
            cbNV.DisplayMember = "TenNV";
            cbNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbNV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbNV.SelectedIndex = -1;
        }
        private void bdHD_PositionChanged(object sender, EventArgs e)
        {
            tblCTHD.DefaultView.RowFilter = "MaDH='" + tbMaDH.Text + "'";
            int s = 0;
            foreach (DataRowView r in tblCTHD.DefaultView)
            {
                s += int.Parse(r["SoTien"].ToString());

            }
            tbTien.Text = s.ToString();
        }

        private void addColCTHD()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblCTHD, tblNHANVIEN });

            DataRelation qh = new DataRelation("FRK_NHANVIEN_CTHD", tblNHANVIEN.Columns["MaNV"], tblCTHD.Columns["MaNV"]);

            ds.Relations.Add(qh);

            DataColumn cot_TenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent (FRK_NHANVIEN_CTHD).TenNV");

            tblCTHD.Columns.Add(cot_TenNV);

        }
        private void loadKH()
        {
            cbSDT.DataSource = tblKHACHHANG;
            cbSDT.ValueMember = "MaKH";
            cbSDT.DisplayMember = "SoDT";
            cbSDT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSDT.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void loadCTHD()
        {
            tbTTM.DataBindings.Add("text", tblCTHD, "TrinhTrangMay", true);
            tbTenDichVu.DataBindings.Add("text", tblCTHD, "TenDichVu", true);
            tbTrangThai.DataBindings.Add("text", tblCTHD, "TrangThai", true);
            tbHinhThucSua.DataBindings.Add("text", tblCTHD, "HinhThucSua", true);
            bindCTHD = this.BindingContext[tblCTHD];
            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.DataSource = tblCTHD;

        }
        private void loadDONHANG()
        {
            tbMaDH.DataBindings.Add("text", tblDONHANG, "MaDH", true);
            dateNLap.DataBindings.Add("value", tblDONHANG, "NgayLap", true);
            cbSDT.DataBindings.Add("SelectedValue", tblDONHANG, "MaKH", true);
            tbTenMay.DataBindings.Add("text", tblDONHANG, "TenMay", true);
            tbLoaiMay.DataBindings.Add("text", tblDONHANG, "LoaiMay", true);
            bindDH = this.BindingContext[tblDONHANG];
            bindDH.PositionChanged += new EventHandler(bdHD_PositionChanged);
            
        }
        private void enableButton()
        {
            btnNew.Enabled = !capnhat;
            btnUpdate.Enabled = !capnhat;
            btnDelete.Enabled = !capnhat;
            btnCancel.Enabled = capnhat;
            btnSave.Enabled = capnhat;
            btnAdd.Enabled = capnhat;
            btnDeleteCTHD.Enabled = capnhat;
            dgvCTHD.Enabled = capnhat;

        }

        private void frmDonHang_Load(object sender, EventArgs e)
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
            loadKH();
            loadDONHANG();
            loadCTHD();
            loadNHANVIEN();
            addColCTHD();
            capnhat = false;
            enableButton();
            bdHD_PositionChanged(sender, e);
        }

        BindingManagerBase bindDH, bindCTHD, bindKH, bindNV;

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindDH.Position = bindDH.Count - 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindDH.AddNew();
            dateNLap.Value = DateTime.Now;
            try
            {
                SqlCommand cmm = new SqlCommand("Select  dbo.fn_CreateMaDH()", XLDONHANG.cnn);
                XLDONHANG.cnn.Open();
                tbMaDH.Text = cmm.ExecuteScalar().ToString();
                capnhat = true;
                enableButton();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            XLDONHANG.cnn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = bindCTHD.Position;
            if (index >= 0)
            {
                bindCTHD.RemoveAt(index);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindCTHD.CancelCurrentEdit();
            tblCTHD.RejectChanges();
            bindDH.CancelCurrentEdit();
            tblDONHANG.RejectChanges();
            bdHD_PositionChanged(sender, e);
            capnhat = false;
            enableButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbNV.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn kỹ thuật viên!!");
                return;
            }
            int count = tblCTHD.Select("MaDH= '" + tbMaDH.Text + "' and MaNV= '" + cbNV.SelectedValue + "'").Count();
            if (count > 0)
            {
                MessageBox.Show("Kỹ thuật viên đã nhận công việc, chọn nhân viên khác");
                return;

            }
            DataRow r = tblCTHD.NewRow();
            r["MaNV"] = cbNV.SelectedValue;
            r["SoTien"] = tbTien.Text;
            r["TrinhTrangMay"] = tbTTM.Text;
            r["TenDichVu"] = tbTenDichVu.Text;
            r["HinhThucSua"] = tbHinhThucSua.Text;
            r["TrangThai"] = tbTrangThai.Text;
            tblCTHD.Rows.Add(r);
            bdHD_PositionChanged(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSDT.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn chức năng ");
                return;
            }
            try
            {
                bindDH.EndCurrentEdit();
                daDH.Update(tblDONHANG);
                tblDONHANG.AcceptChanges();


                bindCTHD.EndCurrentEdit();
                daCTHD.Update(tblCTHD);
                tblCTHD.AcceptChanges();

                MessageBox.Show("Cập nhật thành công ");
                capnhat = false;
                enableButton();
            }
            catch (SqlException ex)
            {
                tblCTHD.RejectChanges();
                tblDONHANG.RejectChanges();
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            int index = bindCTHD.Position;
            if (index >= 0)
            {
                bindCTHD.RemoveAt(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bindDH.Position < bindDH.Count - 1)
            {
                bindDH.Position += 1;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (bindDH.Position > 0)
            {
                bindDH.Position -= 1;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindDH.Position = 0;
        }

        private void dgvCTHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTHD.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
