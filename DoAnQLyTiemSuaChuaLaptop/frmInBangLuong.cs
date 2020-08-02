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
    public partial class frmInBangLuong : Form
    {
        public frmInBangLuong()
        {
            InitializeComponent();
        }

        private void frmInBangLuong_Load(object sender, EventArgs e)
        {
            string query = "SELECT        NHANVIEN.MaNV, NHANVIEN.TenNV, CHAMCONG.Ngay, CHAMCONG.SoGio, CHAMCONG.SoGio * 30000 AS ThanhTien"+
                            "FROM NHANVIEN INNER JOIN CHAMCONG ON NHANVIEN.MaNV = CHAMCONG.MaNV "+
                            "where month(ngay)=" + DateTime.Now.Month + "and year(ngay)=" + DateTime.Now.Year;
            DataTable tblTinhLuong = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnn);
            try
            {
                da.Fill(tblTinhLuong);
                rptTinhLuong rpt = new rptTinhLuong();
                rpt.SetDataSource(tblTinhLuong);
                rptvTinhLuong.ReportSource = rpt;
            }catch(SqlException ex)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
