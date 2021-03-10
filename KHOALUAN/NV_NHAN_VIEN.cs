using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace KHOALUAN
{
    public partial class NV_NHAN_VIEN : UserControl
    {

        public NV_NHAN_VIEN()
        {
            InitializeComponent();
            gioitinh = NAM.Text;
        }

        SqlConnection conn;

        public void LAMMOI()
        {
            ID_NHAN_VIEN.Text = "";
            HO_TEN.Text = "";
            DIEN_THOAI.Text = "";
            EMAIL.Text = "";
            QUE_QUAN.Text = "";
            DIA_CHI.Text = "";
            lbl__HO_TEN.Text = "";
            lbl_DIEN_THOAI.Text = "";
            lbl_EMAIL.Text = "";
            lbl_DIA_CHI.Text = "";
            lbl_QUE_QUAN.Text = "";
            BTN_THEM.Enabled = true;
            BTN_XOA.Enabled = false;
            BTN_LUU.Enabled = false;
        }

        public void THONGBAO()
        {
            if (HO_TEN.Text == "")
            {
                lbl__HO_TEN.ForeColor = Color.Red;
                lbl__HO_TEN.Text = "Vui lòng nhập !";
            }
            if (DIEN_THOAI.Text == "")
            {
                lbl_DIEN_THOAI.ForeColor = Color.Red;
                lbl_DIEN_THOAI.Text = "Vui lòng nhập !";
            }
            if (EMAIL.Text == "")
            {
                lbl_EMAIL.ForeColor = Color.Red;
                lbl_EMAIL.Text = "Vui lòng nhập !";
            }
            if (DIA_CHI.Text == "")
            {
                lbl_DIA_CHI.ForeColor = Color.Red;
                lbl_DIA_CHI.Text = "Vui lòng nhập !";
            }
            if (QUE_QUAN.Text == "")
            {
                lbl_QUE_QUAN.ForeColor = Color.Red;
                lbl_QUE_QUAN.Text = "Vui lòng nhập !";
            }
        }

        private readonly Random random = new Random();

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            BTN_LUU.Enabled = false;
            BTN_XOA.Enabled = false;
            try
            {
                THONGBAO();
                if (ID_NHAN_VIEN.Text == "")
                {
                    ID_NHAN_VIEN.Text = "NV" + random.Next(100000, 999999).ToString();
                }
                if (HO_TEN.Text != "" && DIEN_THOAI.Text != "" && EMAIL.Text != "" && DIA_CHI.Text != "")
                {
                    conn.Open();
                    string sql = "select * from dbo.NHANVIEN where IDNhanVien = '" + ID_NHAN_VIEN.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string message = "ID nhân viên " + ID_NHAN_VIEN.Text + " đã tồn tại !";
                        string title = "Thông Báo";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        // Mở kết nối.
                        string sq = "INSERT INTO NHANVIEN (IDNhanVien, HoTenNV, GioiTinhNV, NgaySinhNV, DienThoaiNV, EmailNV, QueQuanNV, DiaChiNV, NgayTaoNV) VALUES('" + ID_NHAN_VIEN.Text + "',N'" + HO_TEN.Text + "',N'" + gioitinh + "','" + NGAY_SINH.Value.ToString() + "','" + DIEN_THOAI.Text + "', N'" + EMAIL.Text + "', N'" + QUE_QUAN.Text + "', N'" + DIA_CHI.Text + "', '" + NGAY_TAO.Value.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(sq, conn);
                        int k = (int)cmd.ExecuteNonQuery();
                        if (k > 0)
                        {
                            LAMMOI();
                            MessageBox.Show("Thêm thành công nhân viên");
                            LOAT();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại !");
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }
        public void LOAT()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.
                string sql = "SELECT * FROM dbo.NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        public void LOAD()
        {
            try
            {
                if (DesignMode) return;
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.
                string sql = "SELECT * FROM dbo.NHANVIEN";
                SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
                DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
                da.Fill(dt); // đổ dữ liệu vào kho
                dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview      
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void LOAD_NHANVIEN(object sender, EventArgs e)
        {
            BTN_XOA.Enabled = false;
            BTN_LUU.Enabled = false;
            LOAD();
        }

        private void BTN_LUU_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            try
            {
                THONGBAO();
                if (HO_TEN.Text != "" && DIEN_THOAI.Text != "" && EMAIL.Text != "" && DIA_CHI.Text != "")
                {
                    lbl__HO_TEN.Text = "";
                    lbl_DIEN_THOAI.Text = "";
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string sql = "UPDATE dbo.NHANVIEN SET HoTenNV=N'" + HO_TEN.Text + "'," +
                                 "" + " GioiTinhNV=N'" + gioitinh.ToString() + "'," +
                                 "" + "NgaySinhNV=N'" + NGAY_SINH.Value.ToString() + "', " +
                                 "" + "DienThoaiNV=N'" + DIEN_THOAI.Text + "'," +
                                 " EmailNV=N'" + EMAIL.Text + "', " +
                                 "" + "QueQuanNV=N'" + QUE_QUAN.Text + "'," +
                                 "DiaChiNV=N'" + DIA_CHI.Text + "'," +
                                 "" + "NgayCapNhatNV='" + NGAY_CAP_NHAT.Value.ToString() + "'" +
                                 "" + " WHERE IDNhanVien='" + ID_NHAN_VIEN.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công nhân viên");
                        LOAT();
                        LAMMOI();
                    }
                    else
                        MessageBox.Show("Sửa nhân viên thất bại !");
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
            BTN_THEM.Enabled = false;
            if (ID_NHAN_VIEN.Text == "")
            {
                MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !");
                return;
            }
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            // string sql = "DELETE  FROM dbo.NHANVIEN WHERE IDNhanVien='" + ID_NHAN_VIEN.Text + "'";
            string sql = "DELETE FROM dbo.TAIKHOAN WHERE IDNhanVien='" + ID_NHAN_VIEN.Text + "' DELETE FROM dbo.NHANVIEN WHERE IDNhanVien='" + ID_NHAN_VIEN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Nếu xóa dữ liệu ở bảng này có thể ảnh hướng đến các bạn khác bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                LOAT();
            LAMMOI();
            conn.Close();
        }

        string gioitinh = string.Empty;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_THEM.Enabled = false;
            BTN_LUU.Enabled = true;
            BTN_XOA.Enabled = true;
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                ID_NHAN_VIEN.Text = row.Cells[0].Value.ToString();
                HO_TEN.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == NU.Text)
                {
                    NU.Checked = true;
                }
                else if (row.Cells[2].Value.ToString() == NAM.Text)
                {
                    NAM.Checked = true;
                }
                NGAY_SINH.Text = row.Cells[3].Value.ToString();
                DIEN_THOAI.Text = row.Cells[4].Value.ToString();
                EMAIL.Text = row.Cells[5].Value.ToString();
                QUE_QUAN.Text = row.Cells[6].Value.ToString();
                DIA_CHI.Text = row.Cells[7].Value.ToString();
            }
        }

        private void TIM_KIEM_OnValueChanged_1(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open(); //Mở kết nối.
            string sql = "SELECT * FROM NHANVIEN WHERE HoTenNV like N'%" + TIM_KIEM.Text + "%' OR GioiTinhNV LIKE " +
                         "N'%" + TIM_KIEM.Text + "%' OR DienThoaiNV LIKE '%" + TIM_KIEM.Text + "%' OR EmailNV LIKE " +
                         "N'%" + TIM_KIEM.Text + "%' OR QueQuanNV LIKE N'%" + TIM_KIEM.Text + "%' OR DiaChiNV LIKE N'%" + TIM_KIEM.Text + "%' ";
            SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
            DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
            da.Fill(dt); // đổ dữ liệu vào kho
            dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview      
            conn.Close();
        }

        private void NAM_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = NAM.Text;
        }

        private void NU_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = NU.Text;
        }

        private void DIEN_THOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HO_TEN_TextChanged(object sender, EventArgs e)
        {
            lbl__HO_TEN.Text = "";
        }

        private void DIEN_THOAI_TextChanged(object sender, EventArgs e)
        {
            lbl_DIEN_THOAI.Text = "";
        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {
            lbl_EMAIL.Text = "";
        }

        private void DIA_CHI_TextChanged(object sender, EventArgs e)
        {
            lbl_DIA_CHI.Text = "";
        }

        private void NHAN_VIEN_Click(object sender, EventArgs e)
        {
            LAMMOI();
        }

        private void EMAIL_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(EMAIL.Text, pattern))
            {
                lbl_EMAIL.Text = "";
            }
            else
            {
                lbl_EMAIL.Text = "Email nhập sai mời nhập lại !";
                lbl_EMAIL.ForeColor = Color.Red;
                return;
            }
        }

        private void QUE_QUAN_TextChanged(object sender, EventArgs e)
        {
            lbl_QUE_QUAN.Text = "";
        }
    }
}
