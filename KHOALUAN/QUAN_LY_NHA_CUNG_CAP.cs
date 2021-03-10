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
using System.Text.RegularExpressions;

namespace KHOALUAN
{
    public partial class QUAN_LY_NHA_CUNG_CAP : UserControl
    {
        public QUAN_LY_NHA_CUNG_CAP()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        public void LAMMOI()
        {
            ID_NHA_CUNG_CAP.Text = "";
            TEN_NHA_CUNG_CAP.Text = "";
            DIEN_THOAI.Text = "";
            EMAIL.Text = "";
            DIA_CHI.Text = "";
            THONG_BAO.Text = "";
            THONG_BAO1.Text = "";
            THONG_BAO2.Text = "";
            THONG_BAO3.Text = "";
            BTN_THEM.Enabled = true;
            BTN_XOA.Enabled = false;
            BTN_LUU.Enabled = false;
        }

        public void Loat()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open();
                String sql = "SELECT * FROM dbo.NHACUNGCAP";
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

        public void THONGBAO()
        {
            if (TEN_NHA_CUNG_CAP.Text == "")
            {
                THONG_BAO.Text = "Vui lòng nhập !";
                THONG_BAO.ForeColor = Color.Red;
            }
            if (DIEN_THOAI.Text == "")
            {
                THONG_BAO1.Text = "Vui lòng nhập !";
                THONG_BAO1.ForeColor = Color.Red;
            }
            if (EMAIL.Text == "")
            {
                THONG_BAO2.Text = "Vui lòng nhập !";
                THONG_BAO2.ForeColor = Color.Red;
            }
            if (DIA_CHI.Text == "")
            {
                THONG_BAO3.Text = "Vui lòng nhập !";
                THONG_BAO3.ForeColor = Color.Red;
            }
        }

        private readonly Random random = new Random();

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            BTN_LUU.Enabled = false;
            BTN_XOA.Enabled = false;
            try
            {
                if (ID_NHA_CUNG_CAP.Text == "")
                {
                    ID_NHA_CUNG_CAP.Text = "NCC" + random.Next(100000, 999999).ToString();
                }
                THONGBAO();
                if (TEN_NHA_CUNG_CAP.Text != "" && DIEN_THOAI.Text != "" && EMAIL.Text != "" && DIA_CHI.Text != "")
                {
                    conn.Open();
                    string sql = "SELECT * FROM dbo.NHACUNGCAP WHERE IDNhaCungCap = '" + ID_NHA_CUNG_CAP.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //valid = false;
                        String message = "ID nhà cung cấp " + ID_NHA_CUNG_CAP.Text + " đã tồn tại !";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                    }
                    //if(!string.IsNullOrEmpty(DIEN_THOAI.Text))
                    //{
                    //    sql = "SELECT * FROM dbo.NHACUNGCAP WHERE DienThoai = '" + DIEN_THOAI.Text + "'";
                    //    da = new SqlDataAdapter(sql, conn);
                    //    dt = new DataTable();
                    //    da.Fill(dt);
                    //    if (dt.Rows.Count > 0)
                    //    {
                    //        //valid = false;
                    //        String message = "Số điện thoại " + DIEN_THOAI.Text + " đã tồn tại !";
                    //        string title = "Thông báo";
                    //        MessageBox.Show(message, title);
                    //    }
                    //}
                    //if(valid)
                    else
                    {
                        string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                        conn = new SqlConnection(conString);
                        conn.Open();
                        String sql1 = "INSERT INTO dbo.NHACUNGCAP (IDNhaCungCap,TenNhaCungCap,DienThoaiNCC,EmailNCC,DiaChiNCC,NgayTaoNCC) VALUES ('" + ID_NHA_CUNG_CAP.Text + "',N'" + TEN_NHA_CUNG_CAP.Text + "','" + DIEN_THOAI.Text + "','" + EMAIL.Text + "',N'" + DIA_CHI.Text + "','" + NGAY_TAO.Value.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(sql1, conn);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công nhà cung cấp");
                            Loat();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhà cung cấp thất bại");
                        }
                        conn.Close();
                        LAMMOI();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void NHA_CUNG_CAP_Load(object sender, EventArgs e)
        {
            BTN_XOA.Enabled = false;
            BTN_LUU.Enabled = false;
            ID_NHA_CUNG_CAP.Enabled = false;
            NGAY_TAO.Enabled = false;
            NGAY_CAP_NHAT.Enabled = false;
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open();
                string sql = "SELECT * FROM dbo.NHACUNGCAP";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTN_THEM.Enabled = false;
            BTN_LUU.Enabled = true;
            BTN_XOA.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                ID_NHA_CUNG_CAP.Text = row.Cells[0].Value.ToString();
                TEN_NHA_CUNG_CAP.Text = row.Cells[1].Value.ToString();
                DIEN_THOAI.Text = row.Cells[2].Value.ToString();
                EMAIL.Text = row.Cells[3].Value.ToString();
                DIA_CHI.Text = row.Cells[4].Value.ToString();
            }
        }

        private void BTN_XOA_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            if (ID_NHA_CUNG_CAP.Text == "")
            {
                MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !!!");
                return;
            }
            string ConString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(ConString);
            conn.Open();
            String sql = "DELETE  FROM dbo.NHACUNGCAP WHERE IDNhaCungCap = '" + ID_NHA_CUNG_CAP.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Nếu xóa dữ liệu ở bảng này có thể ảnh hướng đến các bạn khác bạn có chắc muốn xóa ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                Loat();
            conn.Close();
            LAMMOI();
        }

       

        private void BTN_LUU_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            try
            {
                THONGBAO();
                if (TEN_NHA_CUNG_CAP.Text != "" && DIEN_THOAI.Text != "" && EMAIL.Text != "" && DIA_CHI.Text != "")
                {
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open();
                    string sql = "UPDATE dbo.NHACUNGCAP SET TenNhaCungCap =N'"
                                 + TEN_NHA_CUNG_CAP.Text + "',DienThoaiNCC = '"
                                 + DIEN_THOAI.Text + "',EmailNCC ='"
                                 + EMAIL.Text + "',DiaChiNCC= N'"
                                 + DIA_CHI.Text + "',NgayCapNhatNCC='"
                                 + NGAY_CAP_NHAT.Value.ToString() + "'   WHERE   IDNhaCungCap = '"
                                 + ID_NHA_CUNG_CAP.Text + "' ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công nhà cung cấp");
                        Loat();
                    }
                    else
                        MessageBox.Show("Sửa nhà cung cấp thất bại");
                    conn.Close();
                    LAMMOI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lối kết nối:" + ex.Message);
            }
        }

         private void DIEN_THOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TIM_KIEM_OnValueChanged(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open(); //Mở kết nối.
            string sql = "SELECT * FROM NHACUNGCAP WHERE IDNhaCungCap like N'%" + TIM_KIEM.Text + "%' OR TenNhaCungCap like N'%" + TIM_KIEM.Text + "%' OR DienThoaiNCC LIKE " +
                         "'%" + TIM_KIEM.Text + "%' OR EmailNCC LIKE N'%" + TIM_KIEM.Text + "%' OR DiaChiNCC LIKE " +
                         "N'%" + TIM_KIEM.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
            DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
            da.Fill(dt); // đổ dữ liệu vào kho
            dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview      
            conn.Close();
        }

        private void TEN_NHA_CUNG_CAP_TextChanged(object sender, EventArgs e)
        {
            THONG_BAO.Text = "";
        }

        private void DIEN_THOAI_TextChanged(object sender, EventArgs e)
        {
            THONG_BAO1.Text = "";
        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {
            THONG_BAO2.Text = "";
        }

        private void DIA_CHI_TextChanged(object sender, EventArgs e)
        {
            THONG_BAO3.Text = "";
        }

        private void NHA_CUNG_CAP_Click(object sender, EventArgs e)
        {
            LAMMOI();
        }

        private void EMAIL_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(EMAIL.Text, pattern))
            {
                THONG_BAO2.Text = "";
            }
            else
            {
                THONG_BAO2.Text = "Email nhập sai mời nhập lại !";
                THONG_BAO2.ForeColor = Color.Red;
                return;
            }
        }
    }
}
