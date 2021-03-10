using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace KHOALUAN
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CB_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Password.Checked)
            {
                PASSWORD.UseSystemPasswordChar = true;
            }
            else
            {
                PASSWORD.UseSystemPasswordChar = false;
            }
        }
      
        private string getID()
        {
            string ID = "";
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open();
                string sql = "SELECT IDNhanVien,TenTaiKhoan,MatKhau FROM dbo.TAIKHOAN  WHERE TenTaiKhoan = N'" + USENAME.Text + "' AND MatKhau = N'" + PASSWORD.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ID = dr["IDNhanVien"].ToString();                        
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }           
            return ID;

        }

        public static string ID_NHAN_VIEN = "";

        private void BTN_LOGIN_Click_1(object sender, EventArgs e)
        {           
            if (USENAME.Text == "")
            {
                lbl_USENAME.Text = "Vui lòng nhập !";
                lbl_USENAME.ForeColor = Color.Red;
            }
            if (PASSWORD.Text == "")
            {
                lbl_PASWORD.Text = "Vui lòng nhập !";
                lbl_PASWORD.ForeColor = Color.Red;
            }
            if (USENAME.Text != "" && PASSWORD.Text != "")
            {
                ID_NHAN_VIEN = getID();
                if(ID_NHAN_VIEN != "")
                {
                    HOME chu = new HOME();
                    chu.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại vui lòng kiểm tra tên đăng nhập hoặc mặt khẩu!");
                }
            }
        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {
            lbl_PASWORD.Text = "";
        }

        private void USENAME_TextChanged(object sender, EventArgs e)
        {
            lbl_USENAME.Text = "";
        }

        private void panel1_Enter(object sender, EventArgs e)
        {

        }
    }
}
