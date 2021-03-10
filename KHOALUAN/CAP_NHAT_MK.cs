using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KHOALUAN
{
    public partial class CAP_NHAT_MK : Form
    {
        public CAP_NHAT_MK()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void THONGTIN()
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            string sqll = "SELECT IDNhanVien,TenTaiKhoan,MatKhau FROM dbo.TAIKHOAN WHERE IDNhanVien = N'" + ID + "'";
            SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt); // đổ dữ liệu vào kho
            ID_NHAN_VIEN.ValueMember = "IDNhanVien";
            ID_NHAN_VIEN.DataSource = dtt;
            USENAME.DataBindings.Clear();
            USENAME.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "TenTaiKhoan");
            PASSWORD.DataBindings.Clear();
            PASSWORD.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "MatKhau");
            ID_NHAN_VIEN.Visible = false;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            THONGTIN();
        }
        string ID = LOGIN.ID_NHAN_VIEN;
        public void THONGBAO()
        {
            if (USENAME.Text == "")
            {
                lbl_USERNAME.Text = "Vui lòng nhập!";
                lbl_USERNAME.ForeColor = Color.Red;
            }           
            if (PASSWORD1.Text == "")
            {
                lbl_PASSWORD1.Text = "Vui lòng nhập!";
                lbl_PASSWORD1.ForeColor = Color.Red;
            }
            if (PASSWORD2.Text == "")
            {
                lbl_PASSWORD2.Text = "Vui lòng nhập!";
                lbl_PASSWORD2.ForeColor = Color.Red;
            }
            if (PASSWORD1.Text != PASSWORD2.Text)
            {
                lbl_PASSWORD1.Text = "Mật khẩu sai !";
                lbl_PASSWORD1.ForeColor = Color.Red;
                lbl_PASSWORD2.Text = "Mật khẩu sai !";
                lbl_PASSWORD2.ForeColor = Color.Red;
            }
            else if (PASSWORD.Text == PASSWORD1.Text)
            {
                lbl_PASSWORD.Text = "Mật khẩu bị trùng !";
                lbl_PASSWORD.ForeColor = Color.Red;
                lbl_PASSWORD1.Text = "Mật khẩu bị trùng !";
                lbl_PASSWORD1.ForeColor = Color.Red;
            }
            else if (USENAME.Text != "" && PASSWORD1.Text != "" && PASSWORD2.Text != "")
            {
                conn.Open();
                string sql = "UPDATE  dbo.TAIKHOAN SET TenTaiKhoan = N'" + USENAME.Text + "' , MatKhau = N'" + PASSWORD2.Text + "' WHERE IDNhanVien = '" + ID_NHAN_VIEN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Mật khẩu đã được cập nhật");
                }
                else
                    MessageBox.Show("Cập nhật mật khẩu thất bại !");
                conn.Close();
            }
        }

        private void BTN_CAP_NHAT_MAT_KHAU_Click(object sender, EventArgs e)
        {
            THONGBAO();
           
        }

        private void USENAME_TextChanged(object sender, EventArgs e)
        {
            lbl_USERNAME.Text = "";
        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {
            lbl_PASSWORD.Text = "";
        }

        private void PASSWORD1_TextChanged(object sender, EventArgs e)
        {
            lbl_PASSWORD1.Text = "";
        }

        private void PASSWORD2_TextChanged(object sender, EventArgs e)
        {
            lbl_PASSWORD2.Text = "";
        }
    }
}
