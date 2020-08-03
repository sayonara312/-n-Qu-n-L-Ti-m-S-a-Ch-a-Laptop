using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLyTiemSuaChuaLaptop
{
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabmain = (TabControl)p.Parent;
            tabmain.TabPages.Remove(p);
        }
    }
}
