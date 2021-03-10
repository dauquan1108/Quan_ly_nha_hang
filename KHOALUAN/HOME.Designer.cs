namespace KHOALUAN
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.BTN_KHO = new System.Windows.Forms.Button();
            this.BTN_THUC_DON = new System.Windows.Forms.Button();
            this.chuyen_dong = new System.Windows.Forms.Panel();
            this.BTN_NHA_CUNG_CAP = new System.Windows.Forms.Button();
            this.BAN = new System.Windows.Forms.Button();
            this.BTN_GOI_MON = new System.Windows.Forms.Button();
            this.BTN_TRANG_CHU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_CAP_NHAT_MK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_TONG = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTN_DANG_XUAT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TIME = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID_NHAN_VIEN = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OPEN_IMAGE = new Bunifu.Framework.UI.BunifuImageButton();
            this.ANH = new KHOALUAN.IMG();
            this.TEN_NHAN_VIEN = new System.Windows.Forms.Label();
            this.TXT1 = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.QUYEN = new KHOALUAN.QUAN_LY_NHAN_VIEN();
            this.TAI_KHOAN = new KHOALUAN.NV_TAI_KHOAN();
            this.THUC_DON = new KHOALUAN.QUAN_LY_THUC_DON();
            this.ban1 = new KHOALUAN.QUAN_LY_BAN();
            this.NHAN_VIEN = new KHOALUAN.NV_NHAN_VIEN();
            this.TRANG_CHU1 = new KHOALUAN.QUAN_LY_HOME();
            this.nhA_CUNG_CAP1 = new KHOALUAN.QUAN_LY_NHA_CUNG_CAP();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPEN_IMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANH)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_KHO
            // 
            this.BTN_KHO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_KHO.FlatAppearance.BorderSize = 0;
            this.BTN_KHO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_KHO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_KHO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_KHO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_KHO.Image")));
            this.BTN_KHO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_KHO.Location = new System.Drawing.Point(9, 552);
            this.BTN_KHO.Name = "BTN_KHO";
            this.BTN_KHO.Size = new System.Drawing.Size(282, 65);
            this.BTN_KHO.TabIndex = 30;
            this.BTN_KHO.Tag = "Kho";
            this.BTN_KHO.Text = "Kho";
            this.BTN_KHO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_KHO.UseVisualStyleBackColor = true;
            this.BTN_KHO.Click += new System.EventHandler(this.BTN_KHO_Click);
            // 
            // BTN_THUC_DON
            // 
            this.BTN_THUC_DON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_THUC_DON.FlatAppearance.BorderSize = 0;
            this.BTN_THUC_DON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_THUC_DON.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_THUC_DON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_THUC_DON.Image = ((System.Drawing.Image)(resources.GetObject("BTN_THUC_DON.Image")));
            this.BTN_THUC_DON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_THUC_DON.Location = new System.Drawing.Point(9, 414);
            this.BTN_THUC_DON.Name = "BTN_THUC_DON";
            this.BTN_THUC_DON.Size = new System.Drawing.Size(282, 65);
            this.BTN_THUC_DON.TabIndex = 29;
            this.BTN_THUC_DON.Tag = "Thực đơn";
            this.BTN_THUC_DON.Text = "Thực đơn";
            this.BTN_THUC_DON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_THUC_DON.UseVisualStyleBackColor = true;
            this.BTN_THUC_DON.Click += new System.EventHandler(this.BTN_THUC_DON_Click);
            // 
            // chuyen_dong
            // 
            this.chuyen_dong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.chuyen_dong.Location = new System.Drawing.Point(-1, 205);
            this.chuyen_dong.Name = "chuyen_dong";
            this.chuyen_dong.Size = new System.Drawing.Size(10, 65);
            this.chuyen_dong.TabIndex = 24;
            // 
            // BTN_NHA_CUNG_CAP
            // 
            this.BTN_NHA_CUNG_CAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_NHA_CUNG_CAP.FlatAppearance.BorderSize = 0;
            this.BTN_NHA_CUNG_CAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NHA_CUNG_CAP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NHA_CUNG_CAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_NHA_CUNG_CAP.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NHA_CUNG_CAP.Image")));
            this.BTN_NHA_CUNG_CAP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NHA_CUNG_CAP.Location = new System.Drawing.Point(9, 483);
            this.BTN_NHA_CUNG_CAP.Name = "BTN_NHA_CUNG_CAP";
            this.BTN_NHA_CUNG_CAP.Size = new System.Drawing.Size(282, 65);
            this.BTN_NHA_CUNG_CAP.TabIndex = 27;
            this.BTN_NHA_CUNG_CAP.Tag = "Nhà cung cấp";
            this.BTN_NHA_CUNG_CAP.Text = "Nhà cung cấp";
            this.BTN_NHA_CUNG_CAP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_NHA_CUNG_CAP.UseVisualStyleBackColor = true;
            this.BTN_NHA_CUNG_CAP.Click += new System.EventHandler(this.BTN_NHA_CUNG_CAP_Click);
            // 
            // BAN
            // 
            this.BAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAN.FlatAppearance.BorderSize = 0;
            this.BAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BAN.Image = ((System.Drawing.Image)(resources.GetObject("BAN.Image")));
            this.BAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAN.Location = new System.Drawing.Point(9, 345);
            this.BAN.Name = "BAN";
            this.BAN.Size = new System.Drawing.Size(282, 65);
            this.BAN.TabIndex = 26;
            this.BAN.Tag = "Bàn";
            this.BAN.Text = "Bàn";
            this.BAN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAN.UseVisualStyleBackColor = true;
            this.BAN.Click += new System.EventHandler(this.BTN_BAN_Click);
            // 
            // BTN_GOI_MON
            // 
            this.BTN_GOI_MON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GOI_MON.FlatAppearance.BorderSize = 0;
            this.BTN_GOI_MON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GOI_MON.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GOI_MON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_GOI_MON.Image = ((System.Drawing.Image)(resources.GetObject("BTN_GOI_MON.Image")));
            this.BTN_GOI_MON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_GOI_MON.Location = new System.Drawing.Point(9, 276);
            this.BTN_GOI_MON.Name = "BTN_GOI_MON";
            this.BTN_GOI_MON.Size = new System.Drawing.Size(282, 65);
            this.BTN_GOI_MON.TabIndex = 25;
            this.BTN_GOI_MON.Tag = "Gọi món";
            this.BTN_GOI_MON.Text = "Gọi món";
            this.BTN_GOI_MON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_GOI_MON.UseVisualStyleBackColor = true;
            this.BTN_GOI_MON.Click += new System.EventHandler(this.BTN_GOI_MON_Click);
            // 
            // BTN_TRANG_CHU
            // 
            this.BTN_TRANG_CHU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_TRANG_CHU.FlatAppearance.BorderSize = 0;
            this.BTN_TRANG_CHU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TRANG_CHU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TRANG_CHU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_TRANG_CHU.Image = ((System.Drawing.Image)(resources.GetObject("BTN_TRANG_CHU.Image")));
            this.BTN_TRANG_CHU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_TRANG_CHU.Location = new System.Drawing.Point(8, 207);
            this.BTN_TRANG_CHU.Name = "BTN_TRANG_CHU";
            this.BTN_TRANG_CHU.Size = new System.Drawing.Size(282, 65);
            this.BTN_TRANG_CHU.TabIndex = 22;
            this.BTN_TRANG_CHU.Tag = "Trang chủ";
            this.BTN_TRANG_CHU.Text = "Trang chủ";
            this.BTN_TRANG_CHU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_TRANG_CHU.UseVisualStyleBackColor = true;
            this.BTN_TRANG_CHU.Click += new System.EventHandler(this.BTN_TRANG_CHU_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.BTN_CAP_NHAT_MK);
            this.panel1.Controls.Add(this.BTN_TONG);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BTN_TRANG_CHU);
            this.panel1.Controls.Add(this.BTN_KHO);
            this.panel1.Controls.Add(this.BTN_THUC_DON);
            this.panel1.Controls.Add(this.BTN_GOI_MON);
            this.panel1.Controls.Add(this.chuyen_dong);
            this.panel1.Controls.Add(this.BAN);
            this.panel1.Controls.Add(this.BTN_NHA_CUNG_CAP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 987);
            this.panel1.TabIndex = 33;
            // 
            // BTN_CAP_NHAT_MK
            // 
            this.BTN_CAP_NHAT_MK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_CAP_NHAT_MK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_CAP_NHAT_MK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CAP_NHAT_MK.BorderRadius = 0;
            this.BTN_CAP_NHAT_MK.ButtonText = "             Cập nhật mật khẩu";
            this.BTN_CAP_NHAT_MK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CAP_NHAT_MK.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_CAP_NHAT_MK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_CAP_NHAT_MK.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_CAP_NHAT_MK.Iconimage = global::KHOALUAN.Properties.Resources.IMG_UPLOAD_EDIT_8368521583445966_254a7cea7eb9aed8586fc445faeaa227;
            this.BTN_CAP_NHAT_MK.Iconimage_right = null;
            this.BTN_CAP_NHAT_MK.Iconimage_right_Selected = null;
            this.BTN_CAP_NHAT_MK.Iconimage_Selected = null;
            this.BTN_CAP_NHAT_MK.IconMarginLeft = 0;
            this.BTN_CAP_NHAT_MK.IconMarginRight = 0;
            this.BTN_CAP_NHAT_MK.IconRightVisible = true;
            this.BTN_CAP_NHAT_MK.IconRightZoom = 0D;
            this.BTN_CAP_NHAT_MK.IconVisible = true;
            this.BTN_CAP_NHAT_MK.IconZoom = 73D;
            this.BTN_CAP_NHAT_MK.IsTab = false;
            this.BTN_CAP_NHAT_MK.Location = new System.Drawing.Point(0, 816);
            this.BTN_CAP_NHAT_MK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_CAP_NHAT_MK.Name = "BTN_CAP_NHAT_MK";
            this.BTN_CAP_NHAT_MK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_CAP_NHAT_MK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.BTN_CAP_NHAT_MK.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_CAP_NHAT_MK.selected = false;
            this.BTN_CAP_NHAT_MK.Size = new System.Drawing.Size(292, 63);
            this.BTN_CAP_NHAT_MK.TabIndex = 133;
            this.BTN_CAP_NHAT_MK.Text = "             Cập nhật mật khẩu";
            this.BTN_CAP_NHAT_MK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CAP_NHAT_MK.Textcolor = System.Drawing.Color.RoyalBlue;
            this.BTN_CAP_NHAT_MK.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CAP_NHAT_MK.Click += new System.EventHandler(this.BTN_CAP_NHAT_MK_Click);
            // 
            // BTN_TONG
            // 
            this.BTN_TONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_TONG.FlatAppearance.BorderSize = 0;
            this.BTN_TONG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TONG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_TONG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.BTN_TONG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_TONG.Image")));
            this.BTN_TONG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_TONG.Location = new System.Drawing.Point(9, 621);
            this.BTN_TONG.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_TONG.Name = "BTN_TONG";
            this.BTN_TONG.Size = new System.Drawing.Size(279, 64);
            this.BTN_TONG.TabIndex = 36;
            this.BTN_TONG.Text = "Quản lý nhân viên";
            this.BTN_TONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_TONG.UseVisualStyleBackColor = true;
            this.BTN_TONG.Click += new System.EventHandler(this.BTN_TONG_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BTN_DANG_XUAT);
            this.panel5.Controls.Add(this.TIME);
            this.panel5.Controls.Add(this.DATE);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 879);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 108);
            this.panel5.TabIndex = 35;
            // 
            // BTN_DANG_XUAT
            // 
            this.BTN_DANG_XUAT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_DANG_XUAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_DANG_XUAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_DANG_XUAT.BorderRadius = 0;
            this.BTN_DANG_XUAT.ButtonText = "          Đăng xuất";
            this.BTN_DANG_XUAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DANG_XUAT.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_DANG_XUAT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_DANG_XUAT.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_DANG_XUAT.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_DANG_XUAT.Iconimage")));
            this.BTN_DANG_XUAT.Iconimage_right = null;
            this.BTN_DANG_XUAT.Iconimage_right_Selected = null;
            this.BTN_DANG_XUAT.Iconimage_Selected = null;
            this.BTN_DANG_XUAT.IconMarginLeft = 0;
            this.BTN_DANG_XUAT.IconMarginRight = 0;
            this.BTN_DANG_XUAT.IconRightVisible = true;
            this.BTN_DANG_XUAT.IconRightZoom = 0D;
            this.BTN_DANG_XUAT.IconVisible = true;
            this.BTN_DANG_XUAT.IconZoom = 73D;
            this.BTN_DANG_XUAT.IsTab = false;
            this.BTN_DANG_XUAT.Location = new System.Drawing.Point(0, 45);
            this.BTN_DANG_XUAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_DANG_XUAT.Name = "BTN_DANG_XUAT";
            this.BTN_DANG_XUAT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BTN_DANG_XUAT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.BTN_DANG_XUAT.OnHoverTextColor = System.Drawing.Color.OrangeRed;
            this.BTN_DANG_XUAT.selected = false;
            this.BTN_DANG_XUAT.Size = new System.Drawing.Size(292, 63);
            this.BTN_DANG_XUAT.TabIndex = 133;
            this.BTN_DANG_XUAT.Text = "          Đăng xuất";
            this.BTN_DANG_XUAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DANG_XUAT.Textcolor = System.Drawing.Color.Green;
            this.BTN_DANG_XUAT.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DANG_XUAT.Click += new System.EventHandler(this.BTN_DANG_XUAT_Click);
            // 
            // TIME
            // 
            this.TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TIME.AutoSize = true;
            this.TIME.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIME.ForeColor = System.Drawing.Color.OrangeRed;
            this.TIME.Location = new System.Drawing.Point(34, 10);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(60, 23);
            this.TIME.TabIndex = 2;
            this.TIME.Text = "label1";
            this.TIME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DATE
            // 
            this.DATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE.AutoSize = true;
            this.DATE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.ForeColor = System.Drawing.Color.OrangeRed;
            this.DATE.Location = new System.Drawing.Point(156, 10);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(60, 23);
            this.DATE.TabIndex = 3;
            this.DATE.Text = "label1";
            this.DATE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 204);
            this.panel3.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 1;
            this.bunifuCircleProgressbar1.animationSpeed = 1;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(33, 0);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(202, 202);
            this.bunifuCircleProgressbar1.TabIndex = 41;
            this.bunifuCircleProgressbar1.Value = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.ID_NHAN_VIEN);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.TXT1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(292, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1632, 66);
            this.panel2.TabIndex = 34;
            // 
            // ID_NHAN_VIEN
            // 
            this.ID_NHAN_VIEN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ID_NHAN_VIEN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ID_NHAN_VIEN.Dock = System.Windows.Forms.DockStyle.Right;
            this.ID_NHAN_VIEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ID_NHAN_VIEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_NHAN_VIEN.FormattingEnabled = true;
            this.ID_NHAN_VIEN.Location = new System.Drawing.Point(1172, 0);
            this.ID_NHAN_VIEN.Name = "ID_NHAN_VIEN";
            this.ID_NHAN_VIEN.Size = new System.Drawing.Size(126, 66);
            this.ID_NHAN_VIEN.TabIndex = 266;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OPEN_IMAGE);
            this.panel4.Controls.Add(this.ANH);
            this.panel4.Controls.Add(this.TEN_NHAN_VIEN);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1298, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 66);
            this.panel4.TabIndex = 1;
            // 
            // OPEN_IMAGE
            // 
            this.OPEN_IMAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OPEN_IMAGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OPEN_IMAGE.Image = ((System.Drawing.Image)(resources.GetObject("OPEN_IMAGE.Image")));
            this.OPEN_IMAGE.ImageActive = null;
            this.OPEN_IMAGE.Location = new System.Drawing.Point(292, 20);
            this.OPEN_IMAGE.Name = "OPEN_IMAGE";
            this.OPEN_IMAGE.Size = new System.Drawing.Size(20, 29);
            this.OPEN_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OPEN_IMAGE.TabIndex = 171;
            this.OPEN_IMAGE.TabStop = false;
            this.OPEN_IMAGE.Zoom = 10;
            this.OPEN_IMAGE.Click += new System.EventHandler(this.OPEN_IMAGE_Click);
            // 
            // ANH
            // 
            this.ANH.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANH.Image = global::KHOALUAN.Properties.Resources.IMG_UPLOAD_854372222;
            this.ANH.Location = new System.Drawing.Point(226, 10);
            this.ANH.MaximumSize = new System.Drawing.Size(50, 50);
            this.ANH.MinimumSize = new System.Drawing.Size(50, 50);
            this.ANH.Name = "ANH";
            this.ANH.Size = new System.Drawing.Size(50, 50);
            this.ANH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ANH.TabIndex = 6;
            this.ANH.TabStop = false;
            // 
            // TEN_NHAN_VIEN
            // 
            this.TEN_NHAN_VIEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TEN_NHAN_VIEN.AutoSize = true;
            this.TEN_NHAN_VIEN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TEN_NHAN_VIEN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEN_NHAN_VIEN.ForeColor = System.Drawing.Color.OrangeRed;
            this.TEN_NHAN_VIEN.Location = new System.Drawing.Point(26, 22);
            this.TEN_NHAN_VIEN.Name = "TEN_NHAN_VIEN";
            this.TEN_NHAN_VIEN.Size = new System.Drawing.Size(177, 26);
            this.TEN_NHAN_VIEN.TabIndex = 5;
            this.TEN_NHAN_VIEN.Text = "Đậu Xuân Quân";
            // 
            // TXT1
            // 
            this.TXT1.AutoSize = true;
            this.TXT1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT1.Location = new System.Drawing.Point(6, 20);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(138, 32);
            this.TXT1.TabIndex = 0;
            this.TXT1.Tag = "Trang chủ";
            this.TXT1.Text = "Trang chủ";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick_1);
            // 
            // QUYEN
            // 
            this.QUYEN.AutoScroll = true;
            this.QUYEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QUYEN.Location = new System.Drawing.Point(292, 66);
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.Size = new System.Drawing.Size(1632, 921);
            this.QUYEN.TabIndex = 40;
            // 
            // TAI_KHOAN
            // 
            this.TAI_KHOAN.AutoScroll = true;
            this.TAI_KHOAN.BackColor = System.Drawing.Color.Silver;
            this.TAI_KHOAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAI_KHOAN.Location = new System.Drawing.Point(292, 66);
            this.TAI_KHOAN.Name = "TAI_KHOAN";
            this.TAI_KHOAN.Size = new System.Drawing.Size(1632, 921);
            this.TAI_KHOAN.TabIndex = 39;
            // 
            // THUC_DON
            // 
            this.THUC_DON.AutoScroll = true;
            this.THUC_DON.BackColor = System.Drawing.Color.Silver;
            this.THUC_DON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.THUC_DON.Location = new System.Drawing.Point(292, 66);
            this.THUC_DON.Name = "THUC_DON";
            this.THUC_DON.Size = new System.Drawing.Size(1632, 921);
            this.THUC_DON.TabIndex = 38;
            // 
            // ban1
            // 
            this.ban1.AutoScroll = true;
            this.ban1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ban1.Location = new System.Drawing.Point(292, 66);
            this.ban1.Name = "ban1";
            this.ban1.Size = new System.Drawing.Size(1632, 921);
            this.ban1.TabIndex = 37;
            // 
            // NHAN_VIEN
            // 
            this.NHAN_VIEN.AutoScroll = true;
            this.NHAN_VIEN.BackColor = System.Drawing.Color.Silver;
            this.NHAN_VIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NHAN_VIEN.Location = new System.Drawing.Point(292, 66);
            this.NHAN_VIEN.Name = "NHAN_VIEN";
            this.NHAN_VIEN.Size = new System.Drawing.Size(1632, 921);
            this.NHAN_VIEN.TabIndex = 36;
            // 
            // TRANG_CHU1
            // 
            this.TRANG_CHU1.AutoScroll = true;
            this.TRANG_CHU1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TRANG_CHU1.Location = new System.Drawing.Point(292, 66);
            this.TRANG_CHU1.Name = "TRANG_CHU1";
            this.TRANG_CHU1.Size = new System.Drawing.Size(1632, 921);
            this.TRANG_CHU1.TabIndex = 35;
            // 
            // nhA_CUNG_CAP1
            // 
            this.nhA_CUNG_CAP1.AutoScroll = true;
            this.nhA_CUNG_CAP1.BackColor = System.Drawing.Color.Silver;
            this.nhA_CUNG_CAP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhA_CUNG_CAP1.Location = new System.Drawing.Point(292, 66);
            this.nhA_CUNG_CAP1.Name = "nhA_CUNG_CAP1";
            this.nhA_CUNG_CAP1.Size = new System.Drawing.Size(1632, 921);
            this.nhA_CUNG_CAP1.TabIndex = 41;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 987);
            this.Controls.Add(this.nhA_CUNG_CAP1);
            this.Controls.Add(this.QUYEN);
            this.Controls.Add(this.TAI_KHOAN);
            this.Controls.Add(this.THUC_DON);
            this.Controls.Add(this.ban1);
            this.Controls.Add(this.NHAN_VIEN);
            this.Controls.Add(this.TRANG_CHU1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPEN_IMAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_KHO;
        private System.Windows.Forms.Button BTN_THUC_DON;
        private System.Windows.Forms.Panel chuyen_dong;
        private System.Windows.Forms.Button BTN_NHA_CUNG_CAP;
        private System.Windows.Forms.Button BAN;
        private System.Windows.Forms.Button BTN_GOI_MON;
        private System.Windows.Forms.Button BTN_TRANG_CHU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TXT1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TIME;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label TEN_NHAN_VIEN;
        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.Panel panel5;
        private QUAN_LY_HOME TRANG_CHU1;
        private NV_NHAN_VIEN NHAN_VIEN;
        private QUAN_LY_BAN ban1;
        private QUAN_LY_THUC_DON THUC_DON;
        private System.Windows.Forms.Button BTN_TONG;
        private NV_TAI_KHOAN TAI_KHOAN;
        private QUAN_LY_NHAN_VIEN QUYEN;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QUAN_LY_NHA_CUNG_CAP nhA_CUNG_CAP1;
        private IMG ANH;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_DANG_XUAT;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_CAP_NHAT_MK;
        private Bunifu.Framework.UI.BunifuImageButton OPEN_IMAGE;
        private System.Windows.Forms.ComboBox ID_NHAN_VIEN;
    }
}