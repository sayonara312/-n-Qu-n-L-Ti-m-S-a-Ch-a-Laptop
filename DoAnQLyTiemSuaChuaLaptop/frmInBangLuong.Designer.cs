﻿namespace DoAnQLyTiemSuaChuaLaptop
{
    partial class frmInBangLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptTinhLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptTinhLuong
            // 
            this.rptTinhLuong.ActiveViewIndex = -1;
            this.rptTinhLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptTinhLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptTinhLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptTinhLuong.Location = new System.Drawing.Point(0, 0);
            this.rptTinhLuong.Name = "rptTinhLuong";
            this.rptTinhLuong.Size = new System.Drawing.Size(800, 450);
            this.rptTinhLuong.TabIndex = 0;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptTinhLuong);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptTinhLuong;
    }
}