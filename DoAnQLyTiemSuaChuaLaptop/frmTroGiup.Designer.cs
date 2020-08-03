namespace DoAnQLyTiemSuaChuaLaptop
{
    partial class frmTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroGiup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm Quản Lý Tiệm Sửa Chữa Laptop gồm các chức năng:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(77, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 302);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(663, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 36);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 495);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTroGiup";
            this.Text = "Trợ Giúp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}