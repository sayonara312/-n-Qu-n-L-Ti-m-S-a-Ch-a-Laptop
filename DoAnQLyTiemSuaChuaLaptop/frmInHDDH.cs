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
    public partial class frmInHDDH : Form
    {
        public frmInHDDH()
        {
            InitializeComponent();
        }
        public string MaDH;
        private void frmInHDDH_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Connect kn = new Connect();


            dt = kn.laybang( "SELECT DONHANG.MaDH, KHACHHANG.TenKH, DONHANG.TenMay, CTHD.TrinhTrangMay, CTHD.TenDichVu, CTHD.HinhThucSua, CTHD.SoTien " +
                        " FROM CTHD INNER JOIN " +
                        " DONHANG ON CTHD.MaDH = DONHANG.MaDH INNER JOIN " +
                        " KHACHHANG ON DONHANG.MaKH = KHACHHANG.MaKH");

                rptDonHang rpt = new rptDonHang();
                rpt.SetDataSource(dt);
                rptvDonHang.ReportSource = rpt;
            
        }
    }
}
