using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace KHOALUAN
{
    public partial class HOME : Form
    {
        SqlConnection conn;

        string ID_NV = LOGIN.ID_NHAN_VIEN;

        public HOME()
        {
            InitializeComponent();
            chuyen_dong.Height = BTN_TRANG_CHU.Height;
            chuyen_dong.Top = BTN_TRANG_CHU.Top;
            TRANG_CHU1.BringToFront();
        }

        private void horafecha_Tick_1(object sender, EventArgs e)
        {
            TIME.Text = DateTime.Now.ToLongTimeString();
            DATE.Text = DateTime.Now.ToShortDateString();
        }

        private void BTN_TONG_Click(object sender, EventArgs e)
        {
            QUYEN.BringToFront();
            chuyen_dong.Height = BTN_TONG.Height;
            chuyen_dong.Top = BTN_TONG.Top;
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_TRANG_CHU_click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BTN_TRANG_CHU.Height;
            chuyen_dong.Top = BTN_TRANG_CHU.Top;
            TRANG_CHU1.BringToFront();
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_GOI_MON_Click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BTN_GOI_MON.Height;
            chuyen_dong.Top = BTN_GOI_MON.Top;
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_BAN_Click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BAN.Height;
            chuyen_dong.Top = BAN.Top;
            ban1.BringToFront();
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_THUC_DON_Click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BTN_THUC_DON.Height;
            chuyen_dong.Top = BTN_THUC_DON.Top;
            THUC_DON.BringToFront();
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_NHA_CUNG_CAP_Click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BTN_NHA_CUNG_CAP.Height;
            chuyen_dong.Top = BTN_NHA_CUNG_CAP.Top;
            nhA_CUNG_CAP1.BringToFront();
            TXT1.Text = ((Button)sender).Text;
        }

        private void BTN_KHO_Click(object sender, EventArgs e)
        {
            chuyen_dong.Height = BTN_KHO.Height;
            chuyen_dong.Top = BTN_KHO.Top;
            TXT1.Text = ((Button)sender).Text;
        }

        private void OPEN_IMAGE_Click(object sender, EventArgs e)
        {
            THONG_TIN_NHAN_VIEN ttnv = new THONG_TIN_NHAN_VIEN();
            ttnv.ShowDialog();
        }
        public void THONGTIN()
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            string sqll = "SELECT NHANVIEN.IDNhanVien,HoTenNV,HinhAnh FROM dbo.NHANVIEN, dbo.TAIKHOAN  WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien AND NHANVIEN.IDNhanVien LIKE N'" + ID_NV + "'";
            SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt); // đổ dữ liệu vào kho
            ID_NHAN_VIEN.ValueMember = "IDNhanVien";
            ID_NHAN_VIEN.DataSource = dtt;
            TEN_NHAN_VIEN.DataBindings.Clear();
            TEN_NHAN_VIEN.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "HoTenNV");
            ANH.DataBindings.Clear();
            if (dtt.Rows[0]["HinhAnh"] == "")
            {
                return;
            }
            else
            {
                ANH.Image = Image.FromFile(@"F:\KHOA_LUAN_TOT_NGHIEP\KHOA_LUAN\KHOALUAN\KHOALUAN" + dtt.Rows[0]["HinhAnh"] + "");
            }

            conn.Close();
        }

        public void QUYEN_QUAN_LY()
        {
            conn.Open();
            string sql = "SELECT IDNhanVien,ChucVu FROM dbo.TAIKHOAN WHERE IDNhanVien = N'" + ID_NV + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["ChucVu"].ToString() == "Nhân viên")
                    {
                        BTN_TONG.Visible = false;
                    }
                }
            }
            conn.Close();
        }


        private void HOME_Load(object sender, EventArgs e)
        {
            THONGTIN();
            ID_NHAN_VIEN.Visible = false;
            QUYEN_QUAN_LY();
        }

        private void BTN_CAP_NHAT_MK_Click(object sender, EventArgs e)
        {
            CAP_NHAT_MK mk = new CAP_NHAT_MK();
            mk.ShowDialog();
        }

        private void BTN_DANG_XUAT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LOGIN ss = new LOGIN();
                ss.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
           
        }
    }
}
