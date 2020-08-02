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
        public string MaDH;
        private void frmInHDDH_Load(object sender, EventArgs e)
        {
            var query = "SELECT KH.TenKH, DH.TenMay, CT.TrinhTrangMay, CT.TenDichVu, CT.HinhThucSua, CT.SoTien, DH.MaDH "
                        +" FROM  CTHD CT INNER JOIN "
                        +" DONHANG DH ON CT.MaDH = DH.MaDH INNER JOIN "
                        +" KHACHHANG KH ON DH.MaKH = KH.MaKH INNER JOIN "
                        +" NHANVIEN  NV ON CT.MaNV = NV.MaNV"+
                        "where DH.MaDH='" + MaDH +"'";

           
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnn);
            try
            {
                DataTable tblHDDH = new DataTable();
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
