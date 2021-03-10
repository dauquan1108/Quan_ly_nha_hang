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
    public partial class NV_TAI_KHOAN : UserControl
    {
        public NV_TAI_KHOAN()
        {
            InitializeComponent();
            chucvu = QUAN_LY.Text;
        }

        SqlConnection conn;

        public void LAMMOI()
        {
            ID_TAI_KHOAN.Text = "";
            TEN_TAI_KHOAN.Text = "";
            TRANG_THAI.Text = "";
            ANH.Image = null;
            THONG_BAO.Text = "";
            THONG_BAO1.Text = "";
            THONG_BAO2.Text = "";
            THONG_BAO3.Text = "";
            BTN_THEM.Enabled = true;
            MAT_KHAU.Enabled = true;
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
        }
        public void LOAT()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.
                string sql = "SELECT IDTaiKhoan,HoTenNV,ChucVu,TenTaiKhoan,GioiTinhNV,NgaySinhNV,DienThoaiNV,QueQuanNV,HinhAnh,TrangThai  " +
                             "FROM dbo.NHANVIEN,dbo.TAIKHOAN WHERE NHANVIEN.IDNhanVien= TAIKHOAN.IDNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns["HinhAnh"].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        String chucvu = string.Empty;

        public void THONGTIN()
        {
            try
            {
                if (DesignMode) return;
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.           
                string sql = "SELECT IDTaiKhoan,HoTenNV,ChucVu,TenTaiKhoan,GioiTinhNV,NgaySinhNV,DienThoaiNV,QueQuanNV,HinhAnh,TrangThai  " +
                             "FROM dbo.NHANVIEN,dbo.TAIKHOAN WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien";
                SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
                DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
                da.Fill(dt); // đổ dữ liệu vào kho
                dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview  
                dataGridView2.Columns["HinhAnh"].Visible = false;
                conn.Close();
                conn.Open();
                string sqll = "SELECT IDNhanVien,HoTenNV FROM  dbo.NHANVIEN";
                SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
                DataTable dtt = new DataTable();
                daa.Fill(dtt); // đổ dữ liệu vào kho
                ID_NHAN_VIEN.ValueMember = "IDNhanVien";
                ID_NHAN_VIEN.DisplayMember = "HoTenNV";
                ID_NHAN_VIEN.DataSource = dtt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }
        private void TAI_KHOAN_Load(object sender, EventArgs e)
        {
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
            THONGTIN();
        }

        private void TAI_KHOAN_Click(object sender, EventArgs e)
        {
            LAMMOI();
        }

        private readonly Random random = new Random();

        public void THONGBAO()
        {
            if (ID_NHAN_VIEN.Text == "")
            {
                THONG_BAO.Text = "Vui lòng nhập !";
                THONG_BAO.ForeColor = Color.Red;
            }
            if (TEN_TAI_KHOAN.Text == "")
            {
                THONG_BAO1.Text = "Vui lòng nhập !";
                THONG_BAO1.ForeColor = Color.Red;
            }
            if (MAT_KHAU.Text == "")
            {
                THONG_BAO2.Text = "Vui lòng nhập !";
                THONG_BAO2.ForeColor = Color.Red;
            }
            if (ANH.Image == null)
            {
                THONG_BAO3.Text = "Vui lòng chọn ảnh !";
                THONG_BAO3.ForeColor = Color.Red;
            }
        }

        private void OPEN_IMAGE_Click_1(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            ofdOpenFile.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            ofdOpenFile.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            ofdOpenFile.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            ofdOpenFile.FilterIndex = 1;
            try
            {
                if (ofdOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (ofdOpenFile.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(ofdOpenFile.FileName);
                        // label1.Text = path;
                        ANH.Image = new Bitmap(ofdOpenFile.FileName);
                        ANH.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_THEM_Click_1(object sender, EventArgs e)
        {
            BTN_SUA.Enabled = false;
            BTN_XOA.Enabled = false;
            try
            {
                if (ID_TAI_KHOAN.Text == "")
                {
                    ID_TAI_KHOAN.Text = "TK" + random.Next(100000, 999999).ToString();
                }
                string filename = System.IO.Path.GetFileName(ofdOpenFile.FileName);
                THONGBAO();
                if (ID_NHAN_VIEN.Text != "" && TEN_TAI_KHOAN.Text != "" && MAT_KHAU.Text != "" && ANH.Image != null)
                {
                    //conn.Open();
                    //string sql = "select * from dbo.TAIKHOAN where IDTaiKhoan = '" + ID_TAI_KHOAN.Text + "'";
                    //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //if (dt.Rows.Count > 0)
                    //{
                    //    string message = " ID tài khoản " + ID_TAI_KHOAN.Text + " đã tồn tại !";
                    //    string title = "Thông Báo";
                    //    MessageBox.Show(message, title);
                    //}
                    //else
                    //{
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string randomNumber = random.Next(100000, 999999).ToString();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.TAIKHOAN ( IDTaiKhoan ,IDNhanVien ,ChucVu ,TenTaiKhoan ,MatKhau ,HinhAnh ,TrangThai )" +
                        " VALUES('" + ID_TAI_KHOAN.Text + "'," +
                        " '" + ID_NHAN_VIEN.SelectedValue + "'," +
                        " N'" + chucvu + "', N'" + TEN_TAI_KHOAN.Text + "'," +
                        " N'" + MAT_KHAU.Text + "',N'\\image\\" + "IMG_UPLOAD_" + randomNumber + filename + "', " +
                        "N'" + TRANG_THAI.Text + "')", conn);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(ofdOpenFile.FileName, path + "\\image\\" + "IMG_UPLOAD_" + randomNumber + filename);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm thành công tài khoản");
                    LOAT();
                    LAMMOI();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài khoản thất bại !");
            }
        }

        private void BTN_SUA_Click_1(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            try
            {
                string filename = System.IO.Path.GetFileName(ofdOpenFile.FileName);
                THONGBAO();
                if (ID_NHAN_VIEN.Text != "" && TEN_TAI_KHOAN.Text != "" && MAT_KHAU.Text != "" && ANH.Image != null)
                {
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string randomNumberUpdate = random.Next(100000, 999999).ToString();
                    string temp = "";
                    if (ID_NHAN_VIEN.Text != "") temp = temp + "IDNhanVien='" + ID_NHAN_VIEN.SelectedValue + "'";
                    if (filename != "ofdOpenFile")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "HinhAnh=N'\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename + "'";
                    }
                    if (TEN_TAI_KHOAN.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "TenTaiKhoan=N'" + TEN_TAI_KHOAN.Text + "'";
                    }
                    if (MAT_KHAU.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "MatKhau=N'" + MAT_KHAU.Text + "'";
                    }
                    if (QUAN_LY.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "ChucVu=N'" + chucvu.ToString() + "'";
                    }
                    else if (NHAN_VIEN.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "ChucVu=N'" + chucvu.ToString() + "'";
                    }
                    if (TRANG_THAI.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "TrangThai=N'" + TRANG_THAI.Text + "'";
                    }
                    string sql = "UPDATE dbo.TAIKHOAN SET " + temp + " WHERE IDTaiKhoan='" + ID_TAI_KHOAN.Text + "' ";
                    if (filename != "ofdOpenFile")
                    {
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(ofdOpenFile.FileName, path + "\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename);
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công tài khoản");
                        LOAT();
                        LAMMOI();
                    }
                    else
                        MessageBox.Show("Sửa tài khoản thất bại !");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void BTN_XOA_Click_1(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            if (ID_TAI_KHOAN.Text == "")
            {
                MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !!!");
                return;
            }
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            string sql = "DELETE FROM dbo.QUYENTAIKHOAN WHERE IDTaiKhoan='" + ID_TAI_KHOAN.Text + "' DELETE FROM dbo.TAIKHOAN WHERE IDTaiKhoan='" + ID_TAI_KHOAN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Nếu xóa dữ liệu ở bảng này có thể ảnh hưởng đến các bảng khác bạn có chắc muốn xóa ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                LOAT();
            LAMMOI();
            conn.Close();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            BTN_THEM.Enabled = false;
            BTN_SUA.Enabled = true;
            BTN_XOA.Enabled = true;
            MAT_KHAU.Enabled = false;
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                ID_TAI_KHOAN.Text = row.Cells[0].Value.ToString();
                ID_NHAN_VIEN.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == QUAN_LY.Text)
                {
                    QUAN_LY.Checked = true;
                }
                else if (row.Cells[2].Value.ToString() == NHAN_VIEN.Text)
                {
                    NHAN_VIEN.Checked = true;
                }
                TEN_TAI_KHOAN.Text = row.Cells[3].Value.ToString();
                TRANG_THAI.Text = row.Cells[9].Value.ToString();
                if (row.Cells[8].Value.ToString() == "")
                {
                    ANH.Image = null;
                    return;
                }
                else
                {
                    ANH.Image = Image.FromFile(@"F:\KHOA_LUAN_TOT_NGHIEP\KHOA_LUAN\KHOALUAN\KHOALUAN" + row.Cells[8].Value.ToString() + "");
                }
            }
        }



        private void QUAN_LY_CheckedChanged_1(object sender, EventArgs e)
        {
            chucvu = QUAN_LY.Text;
        }

        private void NHAN_VIEN_CheckedChanged_1(object sender, EventArgs e)
        {
            chucvu = NHAN_VIEN.Text;
        }

        private void ID_NHAN_VIEN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            THONG_BAO.Text = "";
        }

        private void TEN_TAI_KHOAN_TextChanged_1(object sender, EventArgs e)
        {
            THONG_BAO1.Text = "";
        }

        private void ANH_SizeModeChanged_1(object sender, EventArgs e)
        {
            THONG_BAO3.Text = "";
        }

        private void MAT_KHAU_TextChanged_1(object sender, EventArgs e)
        {
            THONG_BAO2.Text = "";
        }

        private void ID_NHAN_VIEN_DropDown_1(object sender, EventArgs e)
        {
            conn.Open();
            string sqll = "SELECT IDNhanVien,HoTenNV FROM  dbo.NHANVIEN";
            SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt); // đổ dữ liệu vào kho
            ID_NHAN_VIEN.ValueMember = "IDNhanVien";
            ID_NHAN_VIEN.DisplayMember = "HoTenNV";
            ID_NHAN_VIEN.DataSource = dtt;
            conn.Close();
        }
    }
}

