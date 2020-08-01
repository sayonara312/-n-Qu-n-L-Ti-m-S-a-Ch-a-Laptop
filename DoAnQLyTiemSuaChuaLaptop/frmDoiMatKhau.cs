using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLyTiemSuaChuaLaptop.Modules;
namespace DoAnQLyTiemSuaChuaLaptop
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabmain = (TabControl)p.Parent;
            tabmain.TabPages.Remove(p);
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbMKM, "");
            errorProvider1.SetError(tbNLKM, "");
            if (tbMKM.Text.Length < 8 || !tbMKM.Text.Any(char.IsDigit) || !tbMKM.Text.Any(char.IsLower) || !tbMKM.Text.Any(char.IsUpper) )
            {
                errorProvider1.SetError(tbMKM, "Mật khẩu mới tối thiểu 8 ký tự, gồm chữ số, in hoa và in thường.");
                return;
            }
            if(tbMKM.Text!=tbNLKM.Text)
            {
                errorProvider1.SetError(tbNLKM, "Mật khẩu nhập lại không đúng .");
                return;
            }
            frmMain f = (frmMain)this.Parent;
            int count=XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password ='"+ tbMKM.Text+"' where maNV ='"+ f.maNV+"'");
            if (count > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!!!");

            }
            else MessageBox.Show("Mật khẩu không hợp lệ!!!");
        }

        private void tbMKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
