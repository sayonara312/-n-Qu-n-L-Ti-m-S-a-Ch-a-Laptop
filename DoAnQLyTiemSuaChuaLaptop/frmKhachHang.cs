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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        DataTable tblKHACHHANG;
        SqlDataAdapter daKH;
        BindingManagerBase bindKH;
        bool capnhat;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bindKH.AddNew();
            capnhat = true;
            enablebutton();
        }
        private void enablebutton()
        {
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            dgvKhachHang.Enabled = capnhat;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            tblKHACHHANG = new DataTable();

            daKH = new SqlDataAdapter("Select * from KHACHHANG", XLBANG.cnnStr);
            try
            {
                daKH.Fill(tblKHACHHANG);

                SqlCommandBuilder cmdNV = new SqlCommandBuilder(daKH);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadKH();
            loadDSKH();
            capnhat = false;
            enablebutton();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvKhachHang.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        private void loadDSKH()
        {
            tbMaKH.DataBindings.Add("text", tblKHACHHANG, "MaKH", true);
            tbSDT.DataBindings.Add("text", tblKHACHHANG, "SoDT", true);
            tbTenKH.DataBindings.Add("text", tblKHACHHANG, "TenKH", true);
            tbDiaChi.DataBindings.Add("text", tblKHACHHANG, "DiaChi", true);
            tbEmail.DataBindings.Add("text", tblKHACHHANG, "Email", true);
            raNam.DataBindings.Add("Checked", tblKHACHHANG, "GioiTinh", true);


            bindKH = this.BindingContext[tblKHACHHANG];

        }
        private void loadKH()
        {
            bindKH = this.BindingContext[tblKHACHHANG];
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = tblKHACHHANG;


        }

        private void raNam_CheckedChanged(object sender, EventArgs e)
        {
            raNu.Checked = !raNam.Checked;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bindKH.EndCurrentEdit();
                daKH.Update(tblKHACHHANG);
                tblKHACHHANG.AcceptChanges();
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
            tblKHACHHANG.RejectChanges();
            capnhat = false;
            enablebutton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = bindKH.Position;
            if (index >= 0)
                bindKH.RemoveAt(index);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblKHACHHANG.Select("MaKH ='" + tbTim.Text + "'")[0];
                bindKH.Position = tblKHACHHANG.Rows.IndexOf(r);


            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(sender, e);
        }

        private void raNu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
