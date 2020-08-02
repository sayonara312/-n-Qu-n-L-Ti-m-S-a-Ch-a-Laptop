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
        DataTable tblCHAMCONG,tblNHANVIEN;
        SqlDataAdapter daCC,daNV;
        BindingManagerBase bindCC,bindNV;
        bool capnhat;
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            tblCHAMCONG = new DataTable();
            tblNHANVIEN = new DataTable();
            daCC = new SqlDataAdapter("Select * from CHAMCONG", XLCHAMCONG.cnnStr);
            daNV = new SqlDataAdapter("Select * from NHANVIEN", XLNHANVIEN.cnnStr);
            try
            {
                daNV.Fill(tblNHANVIEN);
                daCC.Fill(tblCHAMCONG);
                SqlCommandBuilder cmdCC = new SqlCommandBuilder(daCC);

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadDSCC();
            addcolNV();

        }
        private void loadDSCC()
        {
            
            lbDSNV.DataBindings.Add("text", tblNHANVIEN, "TenNV", true);

            bindNV = this.BindingContext[tblNHANVIEN];
            bindCC = this.BindingContext[tblCHAMCONG];

        }
        private void addcolNV()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNHANVIEN,tblCHAMCONG});

            DataRelation qh = new DataRelation("FRK_NHANVIEN_CHAMCONG", tblNHANVIEN.Columns["MaNV"], tblCHAMCONG.Columns["MaNV"]);
            ds.Relations.Add(qh);
            DataColumn cot_TenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent(FRK_NHANVIEN_CHAMCONG).TenNV");

            tblCHAMCONG.Columns.Add(cot_TenNV);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateNCCong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvNgayCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvNgayCC.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
    }
}
