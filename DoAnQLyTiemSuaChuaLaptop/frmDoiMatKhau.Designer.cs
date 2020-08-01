namespace DoAnQLyTiemSuaChuaLaptop
{
    partial class frmDoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.tbMKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNLKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // tbMKM
            // 
            this.tbMKM.Location = new System.Drawing.Point(126, 75);
            this.tbMKM.Name = "tbMKM";
            this.tbMKM.PasswordChar = '*';
            this.tbMKM.Size = new System.Drawing.Size(133, 20);
            this.tbMKM.TabIndex = 4;
            this.tbMKM.TextChanged += new System.EventHandler(this.tbMKM_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập MK Mới";
            // 
            // tbNLKM
            // 
            this.tbNLKM.Location = new System.Drawing.Point(126, 101);
            this.tbNLKM.Name = "tbNLKM";
            this.tbNLKM.PasswordChar = '*';
            this.tbNLKM.Size = new System.Drawing.Size(133, 20);
            this.tbNLKM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập Lại MK Mới";
            // 
            // btnDMK
            // 
            this.btnDMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDMK.ImageOptions.Image")));
            this.btnDMK.Location = new System.Drawing.Point(43, 139);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(112, 35);
            this.btnDMK.TabIndex = 7;
            this.btnDMK.Text = "Đổi Mật Khẩu";
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(173, 139);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.tbNLKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNLKM;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnDMK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}