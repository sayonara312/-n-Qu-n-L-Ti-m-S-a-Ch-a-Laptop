﻿using System;
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
    public partial class frmLienHe : Form
    {
        public frmLienHe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabmain = (TabControl)p.Parent;
            tabmain.TabPages.Remove(p);
        }
    }
}
