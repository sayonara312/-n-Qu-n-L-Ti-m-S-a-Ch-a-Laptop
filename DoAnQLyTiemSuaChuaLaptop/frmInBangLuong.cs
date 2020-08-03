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
            DataTable dt = new DataTable();
            Connect kn = new Connect();
            dt = kn.laybang("SELECT  NHANVIEN.MaNV, NHANVIEN.TenNV, CHAMCONG.Ngay, CHAMCONG.SoGio, CHAMCONG.SoGio * 50000 AS ThanhTien "+
                            " FROM  NHANVIEN INNER JOIN "+
                            " CHAMCONG ON NHANVIEN.MaNV = CHAMCONG.MaNV");

                rptTinhLuong rpt = new rptTinhLuong();
                rpt.SetDataSource(dt);
                rptvTinhLuong.ReportSource = rpt;
            
        }
    }
}
