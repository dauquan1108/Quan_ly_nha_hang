namespace KHOALUAN
{
    partial class QUAN_LY_QUYEN_VA_TAI_KHOAN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.quyeN__TAI__KHOAN1 = new KHOALUAN.NV_QUYEN_TAI_KHOAN();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nV_TEN_QUYEN1 = new KHOALUAN.NV_TEN_QUYEN();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.quyeN__TAI__KHOAN1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 842);
            this.panel1.TabIndex = 0;
            // 
            // quyeN__TAI__KHOAN1
            // 
            this.quyeN__TAI__KHOAN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.quyeN__TAI__KHOAN1.Location = new System.Drawing.Point(4, -2);
            this.quyeN__TAI__KHOAN1.Name = "quyeN__TAI__KHOAN1";
            this.quyeN__TAI__KHOAN1.Size = new System.Drawing.Size(900, 870);
            this.quyeN__TAI__KHOAN1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.nV_TEN_QUYEN1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(904, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 842);
            this.panel2.TabIndex = 1;
            // 
            // nV_TEN_QUYEN1
            // 
            this.nV_TEN_QUYEN1.AutoScroll = true;
            this.nV_TEN_QUYEN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.nV_TEN_QUYEN1.Location = new System.Drawing.Point(123, -2);
            this.nV_TEN_QUYEN1.Name = "nV_TEN_QUYEN1";
            this.nV_TEN_QUYEN1.Size = new System.Drawing.Size(724, 870);
            this.nV_TEN_QUYEN1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 868);
            this.panel3.TabIndex = 1;
            // 
            // QUAN_LY_QUYEN_VA_TAI_KHOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QUAN_LY_QUYEN_VA_TAI_KHOAN";
            this.Size = new System.Drawing.Size(1610, 842);
            this.Load += new System.EventHandler(this.QUYEN_TAI_KHOAN_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private NV_QUYEN_TAI_KHOAN quyeN__TAI__KHOAN1;
        private NV_TEN_QUYEN nV_TEN_QUYEN1;
        private System.Windows.Forms.Panel panel3;
    }
}
