namespace KHOALUAN
{
    partial class TAO_MON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAO_MON));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ANH = new System.Windows.Forms.PictureBox();
            this.ID_MON = new System.Windows.Forms.ComboBox();
            this.TEN_MON = new System.Windows.Forms.Label();
            this.GIA_MON = new System.Windows.Forms.Label();
            this.SO_LUONG = new System.Windows.Forms.Label();
            this.DON_VI_TINH = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ANH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình ảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã món:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá:";
            // 
            // ANH
            // 
            this.ANH.Image = ((System.Drawing.Image)(resources.GetObject("ANH.Image")));
            this.ANH.Location = new System.Drawing.Point(104, 8);
            this.ANH.Name = "ANH";
            this.ANH.Size = new System.Drawing.Size(176, 117);
            this.ANH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ANH.TabIndex = 5;
            this.ANH.TabStop = false;
            // 
            // ID_MON
            // 
            this.ID_MON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_MON.FormattingEnabled = true;
            this.ID_MON.Location = new System.Drawing.Point(104, 150);
            this.ID_MON.Name = "ID_MON";
            this.ID_MON.Size = new System.Drawing.Size(128, 24);
            this.ID_MON.TabIndex = 6;
            this.ID_MON.SelectionChangeCommitted += new System.EventHandler(this.ID_MON_SelectionChangeCommitted);
            this.ID_MON.Click += new System.EventHandler(this.ID_MON_Click);
            // 
            // TEN_MON
            // 
            this.TEN_MON.AutoSize = true;
            this.TEN_MON.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEN_MON.ForeColor = System.Drawing.Color.White;
            this.TEN_MON.Location = new System.Drawing.Point(100, 200);
            this.TEN_MON.Name = "TEN_MON";
            this.TEN_MON.Size = new System.Drawing.Size(74, 19);
            this.TEN_MON.TabIndex = 7;
            this.TEN_MON.Text = "Gà nướng";
            // 
            // GIA_MON
            // 
            this.GIA_MON.AutoSize = true;
            this.GIA_MON.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIA_MON.ForeColor = System.Drawing.Color.White;
            this.GIA_MON.Location = new System.Drawing.Point(100, 249);
            this.GIA_MON.Name = "GIA_MON";
            this.GIA_MON.Size = new System.Drawing.Size(58, 19);
            this.GIA_MON.TabIndex = 8;
            this.GIA_MON.Text = "30,000";
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.AutoSize = true;
            this.SO_LUONG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SO_LUONG.ForeColor = System.Drawing.Color.White;
            this.SO_LUONG.Location = new System.Drawing.Point(100, 298);
            this.SO_LUONG.Name = "SO_LUONG";
            this.SO_LUONG.Size = new System.Drawing.Size(27, 19);
            this.SO_LUONG.TabIndex = 9;
            this.SO_LUONG.Text = "30";
            // 
            // DON_VI_TINH
            // 
            this.DON_VI_TINH.AutoSize = true;
            this.DON_VI_TINH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DON_VI_TINH.ForeColor = System.Drawing.Color.White;
            this.DON_VI_TINH.Location = new System.Drawing.Point(173, 249);
            this.DON_VI_TINH.Name = "DON_VI_TINH";
            this.DON_VI_TINH.Size = new System.Drawing.Size(33, 19);
            this.DON_VI_TINH.TabIndex = 10;
            this.DON_VI_TINH.Text = "Đĩa";
            // 
            // btn_thoat
            // 
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(252, 329);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(52, 50);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // TAO_MON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.DON_VI_TINH);
            this.Controls.Add(this.SO_LUONG);
            this.Controls.Add(this.GIA_MON);
            this.Controls.Add(this.TEN_MON);
            this.Controls.Add(this.ID_MON);
            this.Controls.Add(this.ANH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TAO_MON";
            this.Size = new System.Drawing.Size(307, 382);
            ((System.ComponentModel.ISupportInitialize)(this.ANH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ANH;
        private System.Windows.Forms.ComboBox ID_MON;
        private System.Windows.Forms.Label TEN_MON;
        private System.Windows.Forms.Label GIA_MON;
        private System.Windows.Forms.Label SO_LUONG;
        private System.Windows.Forms.Label DON_VI_TINH;
        private System.Windows.Forms.Button btn_thoat;
    }
}
