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
    public partial class frmInHDDH : Form
    {
        public frmInHDDH()
        {
            InitializeComponent();
        }

        private void frmInHDDH_Load(object sender, EventArgs e)
        {
            string query = "SELECT DONHANG.TenMay, DONHANG.NgayLap, DONHANG.MaDH, CTHD.SoTien, CTHD.TrinhTrangMay, CTHD.HinhThucSua, CTHD.TenDichVu, KHACHHANG.TenKH" +
                "FROM DONHANG INNER JOIN CTHD ON DONHANG.MaDH = CTHD.MaDH INNER JOIN KHACHHANG ON DONHANG.MaKH = KHACHHANG.MaKH INNER JOIN NHANVIEN ON CTHD.MaNV = NHANVIEN.MaNV" +
                "where month(Ngay) = "+ DateTime.Now.Month + "and year(Ngay)=" + DateTime.Now.Year;
            DataTable tblHDDH = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                da.Fill(tblHDDH);
                rptDonHang rpt = new rptDonHang();
                rpt.SetDataSource(tblHDDH);
                rptvDonHang.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
