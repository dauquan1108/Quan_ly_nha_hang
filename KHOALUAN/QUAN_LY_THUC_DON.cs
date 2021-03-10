using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace KHOALUAN
{
    public partial class QUAN_LY_THUC_DON : UserControl
    {
        public QUAN_LY_THUC_DON()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void OPEN_IMAGE_Click(object sender, EventArgs e)
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

        public void LAMMOI()
        {
            ID_MON.Text = "";
            TEN_MON.Text = "";
            SO_LUONG.Text = "";
            DON_VI_TINH.Text = "";
            ANH.Image = null;
            GIA_MON.Text = "";
            lbl_TEN_MON.Text = "";
            lbl_SO_LUONG.Text = "";
            lbl_DON_VI_TINH.Text = "";
            lbl_HINH_ANH.Text = "";
            lbl_GIA.Text = "";
            lbl_TRANG_THAI.Text = "";
            BTN_THEM.Enabled = true;
            BTN__SUA.Enabled = false;
            BTN__XOA.Enabled = false;
        }

        public void LOAT()
        {
            try
            {
                String conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open();
                string sql = "SELECT * FROM dbo.DANHSACHMON";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns["HinhAnh"].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void THUC_DON_Load(object sender, EventArgs e)
        {
            BTN__SUA.Enabled = false;
            BTN__XOA.Enabled = false;
            LOAT();
        }



        private readonly Random random = new Random();

        private void TIM_KIEM_OnValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM dbo.DANHSACHMON WHERE IDMon LIKE '%" + TIM_KIEM.Text + "%' OR TenMon LIKE N'%" + TIM_KIEM.Text + "%' OR SoLuong LIKE '%" + TIM_KIEM.Text + "%' OR DonViTinh LIKE N'%" + TIM_KIEM.Text + "%' OR Gia LIKE '%" + TIM_KIEM.Text + "%' OR TrangThai LIKE N'%" + TIM_KIEM.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);// thực hiện câu lệnh truy vấn này đến sql
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
            DataTable dt = new DataTable(); // tạo ra 1 kho dữ liệu ảo
            da.Fill(dt); // đổ dữ liệu vào kho
            dataGridView2.DataSource = dt;//đổ dữ liệu vào datagridview 
            conn.Close();
        }

        private void SO_LUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void GIA_MON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void GIA_MON_TextChanged(object sender, EventArgs e)
        {
            lbl_GIA.Text = "";
        }

        private void THUC_DON_Click(object sender, EventArgs e)
        {
            LAMMOI();
        }

        private void TEN_MON_TextChanged(object sender, EventArgs e)
        {
            lbl_TEN_MON.Text = "";
        }

        private void SO_LUONG_TextChanged(object sender, EventArgs e)
        {
            lbl_SO_LUONG.Text = "";
        }

        private void DON_VI_TINH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_DON_VI_TINH.Text = "";
        }

        private void ANH_SizeModeChanged(object sender, EventArgs e)
        {
            lbl_HINH_ANH.Text = "";
        }

        public void THONGBAO()
        {
            if (TEN_MON.Text == "")
            {
                lbl_TEN_MON.Text = "Vui lòng nhập !";
                lbl_TEN_MON.ForeColor = Color.Red;
            }
            if (SO_LUONG.Text == "")
            {
                lbl_SO_LUONG.Text = "Vui lòng nhập !";
                lbl_SO_LUONG.ForeColor = Color.Red;
            }
            if (DON_VI_TINH.Text == "")
            {
                lbl_DON_VI_TINH.Text = "Vui lòng nhập !";
                lbl_DON_VI_TINH.ForeColor = Color.Red;
            }
            if (ANH.Image == null)
            {
                lbl_HINH_ANH.Text = "Vui lòng chọn ảnh !";
                lbl_HINH_ANH.ForeColor = Color.Red;
            }
            if (GIA_MON.Text == "")
            {
                lbl_GIA.Text = "Vui lòng nhập !";
                lbl_GIA.ForeColor = Color.Red;
            }
            if (TRANG_THAI.Text == "")
            {
                lbl_TRANG_THAI.Text = "Vui lòng chọn !";
                lbl_TRANG_THAI.ForeColor = Color.Red;
            }
        }

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            BTN__SUA.Enabled = false;
            BTN__XOA.Enabled = false;
            try
            {
                if (ID_MON.Text == "")
                {
                    ID_MON.Text = "M" + random.Next(100000, 999999).ToString();
                }
                string filename = System.IO.Path.GetFileName(ofdOpenFile.FileName);
                THONGBAO();
                if (TEN_MON.Text != "" && SO_LUONG.Text != "" && DON_VI_TINH.Text != "" && ANH.Image != null && GIA_MON.Text != "")
                {
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string randomNumber = random.Next(100000, 999999).ToString();
                    SqlCommand cmd = new SqlCommand("insert into DANHSACHMON (IDMon,TenMon,SoLuong,DonViTinh,HinhAnh,Gia,TrangThai)" +
                                                    "values('" + ID_MON.Text + "', N'" + TEN_MON.Text + "','" + SO_LUONG.Text + "'" +
                                                    ",N'" + DON_VI_TINH.Text + "',N'\\image\\" + "IMG_UPLOAD_" + randomNumber + filename + "', '" + GIA_MON.Text + "',N'" + TRANG_THAI.Text + "')", conn);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(ofdOpenFile.FileName, path + "\\image\\" + "IMG_UPLOAD_" + randomNumber + filename);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm món thành công.");
                    LOAT();
                    LAMMOI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm món thất bại");
            }
        }

        private void BTN__LUU_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            try
            {
                string filename = System.IO.Path.GetFileName(ofdOpenFile.FileName);
                THONGBAO();
                if (TEN_MON.Text != "" && SO_LUONG.Text != "" && DON_VI_TINH.Text != "" && ANH.Image != null && GIA_MON.Text != "")
                {
                    string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                    conn = new SqlConnection(conString);
                    conn.Open(); //Mở kết nối.
                    string randomNumberUpdate = random.Next(100000, 999999).ToString();
                    string temp = "";
                    if (TEN_MON.Text != "") temp = temp + "TenMon=N'" + TEN_MON.Text + "'";
                    if (filename != "ofdOpenFile")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "HinhAnh=N'\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename + "'";
                    }
                    if (SO_LUONG.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "SoLuong=N'" + SO_LUONG.Text + "'";
                    }
                    if (DON_VI_TINH.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "DonViTinh=N'" + DON_VI_TINH.Text + "'";
                    }
                    if (GIA_MON.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "Gia=N'" + GIA_MON.Text + "'";
                    }
                    if (TRANG_THAI.Text != "")
                    {
                        if (temp != "") temp = temp + ", ";
                        temp = temp + "TrangThai=N'" + TRANG_THAI.Text + "'";
                    }
                    string sql = "UPDATE dbo.DANHSACHMON SET " + temp + " WHERE IDMon='" + ID_MON.Text + "' ";
                    if (filename != "ofdOpenFile")
                    {
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(ofdOpenFile.FileName, path + "\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename);
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa món thành công");
                        LOAT();
                        LAMMOI();
                    }
                    else
                        MessageBox.Show("Sửa món thất bại !");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void BTN__XOA_Click(object sender, EventArgs e)
        {
            BTN_THEM.Enabled = false;
            if (ID_MON.Text == "")
            {
                MessageBox.Show("Không có dữ liệu được chọn mời chọn lại !!!");
                return;
            }

            conn.Open();
            string sql = "DELETE  FROM dbo.DANHSACHMON WHERE IDMon='" + ID_MON.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Nếu xóa dữ liệu ở bảng này có thể ảnh hướng đến các bạn khác bạn có chắc muốn xóa ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                LOAT();
            LAMMOI();
            conn.Close();
        }

        private void TRANG_THAI_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_TRANG_THAI.Text = "";
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BTN_THEM.Enabled = false;
            BTN__SUA.Enabled = true;
            BTN__XOA.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                ID_MON.Text = row.Cells[0].Value.ToString();
                TEN_MON.Text = row.Cells[1].Value.ToString();
                SO_LUONG.Text = row.Cells[2].Value.ToString();
                DON_VI_TINH.Text = row.Cells[3].Value.ToString();
                GIA_MON.Text = row.Cells[5].Value.ToString();
                TRANG_THAI.Text = row.Cells[6].Value.ToString();
                if (row.Cells[4].Value.ToString() == "")
                {
                    ANH.Image = null;
                    return;
                }
                else
                {
                    ANH.Image = Image.FromFile(@"F:\KHOA_LUAN_TOT_NGHIEP\KHOA_LUAN\KHOALUAN\KHOALUAN" + row.Cells[4].Value.ToString() + "");
                }
            }
        }
    }
}
