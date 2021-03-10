namespace KHOALUAN
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID__QUYEN__TAI__KHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID__QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID__TAI__KHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NHAN_VIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_QUYEN_TAI_KHOAN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_THEM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_XOA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_SUA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ID_TAI_KHOAN = new System.Windows.Forms.ComboBox();
            this.ID_QUYEN = new System.Windows.Forms.ComboBox();
            this.THONG_BAO1 = new System.Windows.Forms.Label();
            this.THONG_BAO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID__QUYEN__TAI__KHOAN,
            this.ID__QUYEN,
            this.TEN_QUYEN,
            this.ID__TAI__KHOAN,
            this.TEN_NHAN_VIEN});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(60, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(842, 263);
            this.dataGridView2.TabIndex = 185;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ID__QUYEN__TAI__KHOAN
            // 
            this.ID__QUYEN__TAI__KHOAN.DataPropertyName = "ID";
            this.ID__QUYEN__TAI__KHOAN.HeaderText = "ID quyền tài khoản";
            this.ID__QUYEN__TAI__KHOAN.MinimumWidth = 6;
            this.ID__QUYEN__TAI__KHOAN.Name = "ID__QUYEN__TAI__KHOAN";
            this.ID__QUYEN__TAI__KHOAN.ReadOnly = true;
            this.ID__QUYEN__TAI__KHOAN.Width = 125;
            // 
            // ID__QUYEN
            // 
            this.ID__QUYEN.DataPropertyName = "IDQuyen";
            this.ID__QUYEN.HeaderText = "ID quyền";
            this.ID__QUYEN.MinimumWidth = 6;
            this.ID__QUYEN.Name = "ID__QUYEN";
            this.ID__QUYEN.ReadOnly = true;
            this.ID__QUYEN.Width = 90;
            // 
            // TEN_QUYEN
            // 
            this.TEN_QUYEN.DataPropertyName = "TenQuyen";
            this.TEN_QUYEN.HeaderText = "Tên quyền";
            this.TEN_QUYEN.MinimumWidth = 6;
            this.TEN_QUYEN.Name = "TEN_QUYEN";
            this.TEN_QUYEN.ReadOnly = true;
            this.TEN_QUYEN.Width = 95;
            // 
            // ID__TAI__KHOAN
            // 
            this.ID__TAI__KHOAN.DataPropertyName = "IDTaiKhoan";
            this.ID__TAI__KHOAN.HeaderText = "ID tài khoản";
            this.ID__TAI__KHOAN.MinimumWidth = 6;
            this.ID__TAI__KHOAN.Name = "ID__TAI__KHOAN";
            this.ID__TAI__KHOAN.ReadOnly = true;
            this.ID__TAI__KHOAN.Width = 130;
            // 
            // TEN_NHAN_VIEN
            // 
            this.TEN_NHAN_VIEN.DataPropertyName = "HoTenNV";
            this.TEN_NHAN_VIEN.HeaderText = "Tên nhân viên";
            this.TEN_NHAN_VIEN.MinimumWidth = 6;
            this.TEN_NHAN_VIEN.Name = "TEN_NHAN_VIEN";
            this.TEN_NHAN_VIEN.ReadOnly = true;
            this.TEN_NHAN_VIEN.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 189;
            this.label3.Text = "ID tài khoản";
            // 
            // ID_QUYEN_TAI_KHOAN
            // 
            this.ID_QUYEN_TAI_KHOAN.Enabled = false;
            this.ID_QUYEN_TAI_KHOAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_QUYEN_TAI_KHOAN.Location = new System.Drawing.Point(96, 41);
            this.ID_QUYEN_TAI_KHOAN.Multiline = true;
            this.ID_QUYEN_TAI_KHOAN.Name = "ID_QUYEN_TAI_KHOAN";
            this.ID_QUYEN_TAI_KHOAN.Size = new System.Drawing.Size(104, 29);
            this.ID_QUYEN_TAI_KHOAN.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 186;
            this.label5.Text = "ID ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(210, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 187;
            this.label4.Text = "ID quyền";
            // 
            // BTN_THEM
            // 
            this.BTN_THEM.Activecolor = System.Drawing.SystemColors.Control;
            this.BTN_THEM.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_THEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_THEM.BorderRadius = 0;
            this.BTN_THEM.ButtonText = "           Thêm";
            this.BTN_THEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_THEM.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_THEM.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_THEM.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_THEM.Iconimage")));
            this.BTN_THEM.Iconimage_right = null;
            this.BTN_THEM.Iconimage_right_Selected = null;
            this.BTN_THEM.Iconimage_Selected = null;
            this.BTN_THEM.IconMarginLeft = 0;
            this.BTN_THEM.IconMarginRight = 0;
            this.BTN_THEM.IconRightVisible = true;
            this.BTN_THEM.IconRightZoom = 0D;
            this.BTN_THEM.IconVisible = true;
            this.BTN_THEM.IconZoom = 70D;
            this.BTN_THEM.IsTab = false;
            this.BTN_THEM.Location = new System.Drawing.Point(60, 85);
            this.BTN_THEM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_THEM.Name = "BTN_THEM";
            this.BTN_THEM.Normalcolor = System.Drawing.SystemColors.Control;
            this.BTN_THEM.OnHovercolor = System.Drawing.SystemColors.Control;
            this.BTN_THEM.OnHoverTextColor = System.Drawing.Color.OrangeRed;
            this.BTN_THEM.selected = false;
            this.BTN_THEM.Size = new System.Drawing.Size(242, 63);
            this.BTN_THEM.TabIndex = 194;
            this.BTN_THEM.Text = "           Thêm";
            this.BTN_THEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_THEM.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_THEM.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_THEM.Click += new System.EventHandler(this.BTN_THEM_Click);
            // 
            // BTN_XOA
            // 
            this.BTN_XOA.Activecolor = System.Drawing.SystemColors.Control;
            this.BTN_XOA.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_XOA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_XOA.BorderRadius = 0;
            this.BTN_XOA.ButtonText = "           Xóa";
            this.BTN_XOA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_XOA.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_XOA.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_XOA.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_XOA.Iconimage")));
            this.BTN_XOA.Iconimage_right = null;
            this.BTN_XOA.Iconimage_right_Selected = null;
            this.BTN_XOA.Iconimage_Selected = null;
            this.BTN_XOA.IconMarginLeft = 0;
            this.BTN_XOA.IconMarginRight = 0;
            this.BTN_XOA.IconRightVisible = true;
            this.BTN_XOA.IconRightZoom = 0D;
            this.BTN_XOA.IconVisible = true;
            this.BTN_XOA.IconZoom = 70D;
            this.BTN_XOA.IsTab = false;
            this.BTN_XOA.Location = new System.Drawing.Point(660, 85);
            this.BTN_XOA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_XOA.Name = "BTN_XOA";
            this.BTN_XOA.Normalcolor = System.Drawing.SystemColors.Control;
            this.BTN_XOA.OnHovercolor = System.Drawing.SystemColors.Control;
            this.BTN_XOA.OnHoverTextColor = System.Drawing.Color.OrangeRed;
            this.BTN_XOA.selected = false;
            this.BTN_XOA.Size = new System.Drawing.Size(242, 63);
            this.BTN_XOA.TabIndex = 193;
            this.BTN_XOA.Text = "           Xóa";
            this.BTN_XOA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_XOA.Textcolor = System.Drawing.Color.Red;
            this.BTN_XOA.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_XOA.Click += new System.EventHandler(this.BTN_XOA_Click);
            // 
            // BTN_SUA
            // 
            this.BTN_SUA.Activecolor = System.Drawing.SystemColors.Control;
            this.BTN_SUA.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_SUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SUA.BorderRadius = 0;
            this.BTN_SUA.ButtonText = "           Sửa";
            this.BTN_SUA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SUA.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_SUA.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_SUA.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_SUA.Iconimage")));
            this.BTN_SUA.Iconimage_right = null;
            this.BTN_SUA.Iconimage_right_Selected = null;
            this.BTN_SUA.Iconimage_Selected = null;
            this.BTN_SUA.IconMarginLeft = 0;
            this.BTN_SUA.IconMarginRight = 0;
            this.BTN_SUA.IconRightVisible = true;
            this.BTN_SUA.IconRightZoom = 0D;
            this.BTN_SUA.IconVisible = true;
            this.BTN_SUA.IconZoom = 65D;
            this.BTN_SUA.IsTab = false;
            this.BTN_SUA.Location = new System.Drawing.Point(354, 85);
            this.BTN_SUA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_SUA.Name = "BTN_SUA";
            this.BTN_SUA.Normalcolor = System.Drawing.SystemColors.Control;
            this.BTN_SUA.OnHovercolor = System.Drawing.SystemColors.Control;
            this.BTN_SUA.OnHoverTextColor = System.Drawing.Color.OrangeRed;
            this.BTN_SUA.selected = false;
            this.BTN_SUA.Size = new System.Drawing.Size(242, 63);
            this.BTN_SUA.TabIndex = 192;
            this.BTN_SUA.Text = "           Sửa";
            this.BTN_SUA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SUA.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_SUA.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SUA.Click += new System.EventHandler(this.BTN_SUA_Click);
            // 
            // ID_TAI_KHOAN
            // 
            this.ID_TAI_KHOAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_TAI_KHOAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TAI_KHOAN.FormattingEnabled = true;
            this.ID_TAI_KHOAN.Location = new System.Drawing.Point(695, 40);
            this.ID_TAI_KHOAN.Name = "ID_TAI_KHOAN";
            this.ID_TAI_KHOAN.Size = new System.Drawing.Size(218, 30);
            this.ID_TAI_KHOAN.TabIndex = 198;
            this.ID_TAI_KHOAN.DropDown += new System.EventHandler(this.ID_TAI_KHOAN_DropDown);
            this.ID_TAI_KHOAN.SelectedIndexChanged += new System.EventHandler(this.ID_TAI_KHOAN_SelectedIndexChanged);
            this.ID_TAI_KHOAN.Click += new System.EventHandler(this.ID_TAI_KHOAN_Click);
            this.ID_TAI_KHOAN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ID_TAI_KHOAN_MouseClick);
            this.ID_TAI_KHOAN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ID_TAI_KHOAN_MouseDoubleClick);
            this.ID_TAI_KHOAN.MouseCaptureChanged += new System.EventHandler(this.ID_TAI_KHOAN_MouseCaptureChanged);
            // 
            // ID_QUYEN
            // 
            this.ID_QUYEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_QUYEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_QUYEN.FormattingEnabled = true;
            this.ID_QUYEN.Location = new System.Drawing.Point(323, 40);
            this.ID_QUYEN.Name = "ID_QUYEN";
            this.ID_QUYEN.Size = new System.Drawing.Size(218, 30);
            this.ID_QUYEN.TabIndex = 197;
            this.ID_QUYEN.DropDown += new System.EventHandler(this.ID_QUYEN_DropDown);
            this.ID_QUYEN.SelectedIndexChanged += new System.EventHandler(this.ID_QUYEN_SelectedIndexChanged);
            this.ID_QUYEN.Click += new System.EventHandler(this.ID_QUYEN_Click);
            // 
            // THONG_BAO1
            // 
            this.THONG_BAO1.AutoSize = true;
            this.THONG_BAO1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THONG_BAO1.Location = new System.Drawing.Point(699, 16);
            this.THONG_BAO1.Name = "THONG_BAO1";
            this.THONG_BAO1.Size = new System.Drawing.Size(0, 19);
            this.THONG_BAO1.TabIndex = 239;
            // 
            // THONG_BAO
            // 
            this.THONG_BAO.AutoSize = true;
            this.THONG_BAO.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THONG_BAO.Location = new System.Drawing.Point(327, 17);
            this.THONG_BAO.Name = "THONG_BAO";
            this.THONG_BAO.Size = new System.Drawing.Size(0, 19);
            this.THONG_BAO.TabIndex = 240;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.THONG_BAO);
            this.Controls.Add(this.THONG_BAO1);
            this.Controls.Add(this.ID_TAI_KHOAN);
            this.Controls.Add(this.ID_QUYEN);
            this.Controls.Add(this.BTN_THEM);
            this.Controls.Add(this.BTN_XOA);
            this.Controls.Add(this.BTN_SUA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID_QUYEN_TAI_KHOAN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_QUYEN_TAI_KHOAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_THEM;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_XOA;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_SUA;
        private System.Windows.Forms.ComboBox ID_TAI_KHOAN;
        private System.Windows.Forms.ComboBox ID_QUYEN;
        private System.Windows.Forms.Label THONG_BAO1;
        private System.Windows.Forms.Label THONG_BAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID__QUYEN__TAI__KHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID__QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID__TAI__KHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NHAN_VIEN;
    }
}