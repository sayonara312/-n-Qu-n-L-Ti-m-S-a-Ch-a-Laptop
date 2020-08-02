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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNHANVIEN;
        XLCHAMCONG tblCHAMCONG;
 
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            tblNHANVIEN = new XLNHANVIEN();
            tblCHAMCONG= new XLCHAMCONG();
            loadNhanVien();
            addcolNV();
            dateNCCong.Value = DateTime.Now;
        }
        private void loadNhanVien()
        {
            lbDSNV.DataSource = tblNHANVIEN;
            lbDSNV.ValueMember = "MaNV";
            lbDSNV.DisplayMember = "TenNV";
        }

        private void addcolNV()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNHANVIEN, tblCHAMCONG });
            DataRelation qh = new DataRelation("FRK_NHANVIEN_CHAMCONG", tblNHANVIEN.Columns["MaNV"], tblCHAMCONG.Columns["MaNV"]);
            ds.Relations.Add(qh);

            DataColumn cTenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent(FRK_NHANVIEN_CHAMCONG).TenNV");
            tblCHAMCONG.Columns.Add(cTenNV);

            dgvNgayCC.AutoGenerateColumns = false;
            dgvNgayCC.DataSource = tblCHAMCONG;
        }

        private void dgvNgayCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {


                if (e.ColumnIndex == 5) tblCHAMCONG.Rows[e.RowIndex].Delete();

                tblCHAMCONG.ghi();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateNCCong_ValueChanged(object sender, EventArgs e)
        {
            tblCHAMCONG.locDuLieu("Ngay='" + dateNCCong.Value.ToShortDateString() + "'");
        }

        private void dgvNgayCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvNgayCC.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow r = tblCHAMCONG.NewRow();
            r["MaNV"] = lbDSNV.SelectedValue;
            r["Ngay"] = dateNCCong.Value.ToShortDateString();
            r["SoGio"] = numSoGio.Value;
            tblCHAMCONG.Rows.Add(r);
            tblCHAMCONG.ghi();
        }
    }
}
