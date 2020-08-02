namespace DoAnQLyTiemSuaChuaLaptop
{
    partial class frmInHDDH
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
            this.rptvDonHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvDonHang
            // 
            this.rptvDonHang.ActiveViewIndex = -1;
            this.rptvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvDonHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvDonHang.Location = new System.Drawing.Point(0, 0);
            this.rptvDonHang.Name = "rptvDonHang";
            this.rptvDonHang.Size = new System.Drawing.Size(800, 450);
            this.rptvDonHang.TabIndex = 0;
            // 
            // frmInHDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvDonHang);
            this.Name = "frmInHDDH";
            this.Text = "frmInHDDH";
            this.Load += new System.EventHandler(this.frmInHDDH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvDonHang;
    }
}