using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KHOALUAN
{
    public partial class NV_QUYEN_TAI_KHOAN : UserControl
    {
        public NV_QUYEN_TAI_KHOAN()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        public void LAMMOI()
        {
            ID_QUYEN_TAI_KHOAN.Text = "";
            ID_QUYEN.Text = "";
            ID_QUYEN_TAI_KHOAN.Text = "";
            BTN_THEM.Enabled = true;
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
        }
        public void LOAT()
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open(); //Mở kết nối.
            string sql = "SELECT ID,TAIKHOAN.IDTaiKhoan,QUYEN.IDQuyen,HoTenNV,TenQuyen " +
                         "FROM dbo.QUYENTAIKHOAN, dbo.QUYEN, dbo.NHANVIEN,dbo.TAIKHOAN " +
                         "WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien AND TAIKHOAN.IDTaiKhoan = QUYENTAIKHOAN.IDTaiKhoan AND QUYEN.IDQuyen = QUYENTAIKHOAN.IDQuyen";
            SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
            DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
            da.Fill(dt); // đổ dữ liệu vào kho
            dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview      
            conn.Close();
        }


        private void QUYEN__TAI__KHOAN_Load(object sender, EventArgs e)
        {
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
            try
            {
                if (DesignMode) return;
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.
                string sql = "SELECT ID,TAIKHOAN.IDTaiKhoan,QUYEN.IDQuyen,HoTenNV,TenQuyen " +
                             "FROM dbo.QUYENTAIKHOAN, dbo.QUYEN, dbo.NHANVIEN,dbo.TAIKHOAN " +
                             "WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien AND TAIKHOAN.IDTaiKhoan = QUYENTAIKHOAN.IDTaiKhoan AND QUYEN.IDQuyen = QUYENTAIKHOAN.IDQuyen";
                SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
                DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
                da.Fill(dt); // đổ dữ liệu vào kho
                dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview    
                conn.Close();
                conn.Open();
                string sqll = "SELECT * FROM dbo.QUYEN";
                SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
                DataTable dtt = new DataTable();
                daa.Fill(dtt); // đổ dữ liệu vào kho
                ID_QUYEN.ValueMember = "IDQuyen";
                ID_QUYEN.DisplayMember = "TenQuyen";
                ID_QUYEN.DataSource = dtt;
                conn.Close();
                conn.Open();
                string sqlll = "SELECT IDTaiKhoan,HoTenNV FROM dbo.NHANVIEN, dbo.TAIKHOAN WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien";
                SqlDataAdapter daaa = new SqlDataAdapter(sqlll, conn);
                DataTable dttt = new DataTable();
                daaa.Fill(dttt);
                ID_TAI_KHOAN.ValueMember = "IDTaiKhoan";
                ID_TAI_KHOAN.DisplayMember = "HoTenNV";
                ID_TAI_KHOAN.DataSource = dttt;
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_THEM.Enabled = false;
            BTN_SUA.Enabled = true;
            BTN_XOA.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                ID_QUYEN_TAI_KHOAN.Text = row.Cells[0].Value.ToString();
                ID_QUYEN.Text = row.Cells[4].Value.ToString();
                ID_TAI_KHOAN.Text = row.Cells[3].Value.ToString();
            }
        }

        private readonly Random random = new Random();

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
            try
            {
                if (ID_QUYEN_TAI_KHOAN.Text == "")
                {
                    ID_QUYEN_TAI_KHOAN.Text = "Q_" + random.Next(100000, 999999).ToString();
                }
                conn.Open();
                string sql = "select * from dbo.NHANVIEN where IDNhanVien = '" + ID_QUYEN_TAI_KHOAN.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string message = "ID " + ID_QUYEN_TAI_KHOAN.Text + " đã tồn tại !";
                    string title = "Thông Báo";
                    MessageBox.Show(message, title);
                }
                if (ID_QUYEN.Text != "" && ID_TAI_KHOAN.Text != "")
                {
                    string sq = " INSERT INTO dbo.QUYENTAIKHOAN ( ID, IDQuyen, IDTaiKhoan )" +
                                   " VALUES ( '" + ID_QUYEN_TAI_KHOAN.Text + "','" + ID_QUYEN.SelectedValue + "','" + ID_TAI_KHOAN.SelectedValue + "')";
                    SqlCommand cmdd = new SqlCommand(sq, conn);
                    int k = (int)cmdd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("Thêm thành quyền tài khoản");
                        LOAT();
                        LAMMOI();
                    }
                    else
                    {
                        MessageBox.Show("Thêm quyền tài khoản thất bại !");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void BTN_SUA_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            try
            {
                if (ID_QUYEN_TAI_KHOAN.Text == "")
                {
                    MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !");
                    return;
                }
                if (ID_QUYEN_TAI_KHOAN.Text != "")
                {
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string sql = " UPDATE dbo.QUYENTAIKHOAN" +
                    " SET IDQuyen='" + ID_QUYEN.SelectedValue + "'," +
                    "IDTaiKhoan='" + ID_TAI_KHOAN.SelectedValue + "' " +
                    "WHERE ID='" + ID_QUYEN_TAI_KHOAN.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công quyền tài khoản");
                        LOAT();
                        LAMMOI();
                    }
                    else
                        MessageBox.Show("Sửa quyền tài khoản thất bại !");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void BTN_XOA_Click(object sender, EventArgs e)
        {
            BTN_XOA.Enabled = false;
            if (ID_QUYEN_TAI_KHOAN.Text == "")
            {
                MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !");
                return;
            }
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            // string sql = "DELETE  FROM dbo.NHANVIEN WHERE IDNhanVien='" + ID_NHAN_VIEN.Text + "'";
            string sql = "DELETE FROM dbo.QUYENTAIKHOAN WHERE ID='" + ID_QUYEN_TAI_KHOAN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Nếu xóa dữ liệu ở bảng này có thể ảnh hướng đến các bạn khác bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                LOAT();
            LAMMOI();
            conn.Close();
        }

        private void QUYEN__TAI__KHOAN_Click(object sender, EventArgs e)
        {
            LAMMOI();
        }

        private void ID_QUYEN_DropDown(object sender, EventArgs e)
        {
            conn.Open();
            string sqll = "SELECT * FROM dbo.QUYEN";
            SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt); // đổ dữ liệu vào kho
            ID_QUYEN.ValueMember = "IDQuyen";
            ID_QUYEN.DisplayMember = "TenQuyen";
            ID_QUYEN.DataSource = dtt;
            conn.Close();
        }

        private void ID_TAI_KHOAN_DropDown(object sender, EventArgs e)
        {
            conn.Open();
            string sqlll = "SELECT IDTaiKhoan,HoTenNV FROM dbo.NHANVIEN, dbo.TAIKHOAN WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien";
            SqlDataAdapter daaa = new SqlDataAdapter(sqlll, conn);
            DataTable dttt = new DataTable();
            daaa.Fill(dttt);
            ID_TAI_KHOAN.ValueMember = "IDTaiKhoan";
            ID_TAI_KHOAN.DisplayMember = "HoTenNV";
            ID_TAI_KHOAN.DataSource = dttt;
            conn.Close();
        }
    }
}
