namespace DoAnQLyTiemSuaChuaLaptop
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
            this.rptvTinhLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvTinhLuong
            // 
            this.rptvTinhLuong.ActiveViewIndex = -1;
            this.rptvTinhLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvTinhLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvTinhLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvTinhLuong.Location = new System.Drawing.Point(0, 0);
            this.rptvTinhLuong.Name = "rptvTinhLuong";
            this.rptvTinhLuong.Size = new System.Drawing.Size(800, 450);
            this.rptvTinhLuong.TabIndex = 0;
            // 
            // frmInBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvTinhLuong);
            this.Name = "frmInBangLuong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmInBangLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvTinhLuong;
    }
}