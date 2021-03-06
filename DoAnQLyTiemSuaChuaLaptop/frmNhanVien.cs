﻿using System;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        DataTable  tblNHANVIEN;
        SqlDataAdapter daNV;

        private void dgvNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dgvNhanVien.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
        
        BindingManagerBase bindNV;
        bool capnhat;
        private void loadDSNV()
        {
            tbMaNV.DataBindings.Add("text", tblNHANVIEN, "MaNV", true);
            tbSDT.DataBindings.Add("text", tblNHANVIEN, "SoDT", true);
            tbTenNV.DataBindings.Add("text", tblNHANVIEN, "TenNV", true);
            tbDiaChi.DataBindings.Add("text", tblNHANVIEN, "DiaChi", true);
            tbEmail.DataBindings.Add("text", tblNHANVIEN, "Email", true);
            raNam.DataBindings.Add("Checked", tblNHANVIEN, "GioiTinh", true);
            

            bindNV = this.BindingContext[tblNHANVIEN];

        }
        
        private void loadNV()
        {
            bindNV = this.BindingContext[tblNHANVIEN];
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = tblNHANVIEN;
        }
        private void enablebutton()
        {
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = capnhat;
            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
            dgvNhanVien.Enabled = capnhat;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            tblNHANVIEN = new DataTable();
            
            daNV = new SqlDataAdapter("Select * from NHANVIEN", XLBANG.cnnStr);
            try
            {
                daNV.Fill(tblNHANVIEN);
                
                SqlCommandBuilder cmdNV = new SqlCommandBuilder(daNV);
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadNV();
            loadDSNV();
            capnhat = false;
            enablebutton();

            
        }

        private void raNam_CheckedChanged(object sender, EventArgs e)
        {
            raNu.Checked = !raNam.Checked;
        }

        private void btnThemNV(object sender, EventArgs e)
        {
            bindNV.AddNew();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bindNV.EndCurrentEdit();
                daNV.Update(tblNHANVIEN);
                tblNHANVIEN.AcceptChanges();
                MessageBox.Show("Lưu thành công!!!");
                capnhat = false;
                enablebutton();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bindNV.CancelCurrentEdit();
            tblNHANVIEN.RejectChanges();
            capnhat = false;
            enablebutton();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = bindNV.Position;
            if (index >= 0)
                bindNV.RemoveAt(index);

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enablebutton();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblNHANVIEN.Select("MaNV ='" + tbTim.Text + "'")[0];
                bindNV.Position =tblNHANVIEN.Rows.IndexOf(r);
                

            }
            catch(Exception)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void tbTim_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tbTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(sender, e);
        }

        private void raNam_CheckedChanged_1(object sender, EventArgs e)
        {
            raNu.Checked = !raNam.Checked;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bindNV.AddNew();
            capnhat = true;
            enablebutton();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabmain = (TabControl)p.Parent;
            tabmain.TabPages.Remove(p);
        }
    }
}
