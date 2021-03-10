using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KHOALUAN
{
    public partial class THONG_TIN_NHAN_VIEN : Form
    {
        public THONG_TIN_NHAN_VIEN()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string ID_NV = LOGIN.ID_NHAN_VIEN;

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
                        ANH.Image = new Bitmap(ofdOpenFile.FileName);
                        ANH.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    return;
                    // MessageBox.Show("Vui lòng chọn ảnh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void THONGTIN()
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            string sqll = "SELECT NHANVIEN.IDNhanVien,HoTenNV,GioiTinhNV,NgaySinhNV,DienThoaiNV,EmailNV,QueQuanNV,DiaChiNV,HinhAnh " +
                          "FROM dbo.NHANVIEN,dbo.TAIKHOAN WHERE NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien  AND NHANVIEN.IDNhanVien LIKE '"+ ID_NV + "'";
            SqlDataAdapter daa = new SqlDataAdapter(sqll, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt); // đổ dữ liệu vào kho
            ID_NHAN_VIEN.ValueMember = "IDNhanVien";
            ID_NHAN_VIEN.DataSource = dtt;
            HO_TEN.DataBindings.Clear();
            HO_TEN.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "HoTenNV");
            GIOI_TINH.DataBindings.Clear();
            GIOI_TINH.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "GioiTinhNV");
            NGAY_SINH.DataBindings.Clear();
            NGAY_SINH.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "NgaySinhNV");
            DIEN_THOAI.DataBindings.Clear();
            DIEN_THOAI.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "DienThoaiNV");
            EMAIL.DataBindings.Clear();
            EMAIL.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "EmailNV");
            QUE_QUAN.DataBindings.Clear();
            QUE_QUAN.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "QueQuanNV");
            DIA_CHI.DataBindings.Clear();
            DIA_CHI.DataBindings.Add("Text", ID_NHAN_VIEN.DataSource, "DiaChiNV");
            ANH.DataBindings.Clear();
            if (dtt.Rows[0]["HinhAnh"] == "")
            {
                ANH.Image = null;
                return;
            }
            else
            {
                ANH.Image = Image.FromFile(@"F:\KHOA_LUAN_TOT_NGHIEP\KHOA_LUAN\KHOALUAN\KHOALUAN" + dtt.Rows[0]["HinhAnh"] + "");
            }
            conn.Close();
        }

        private void THONG_TIN_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            THONGTIN();
            NGAY_CAP_NHAT.Visible = false;
        }

        private readonly Random random = new Random();

        private void BTN_CAP_NHAT_MAT_KHAU_Click(object sender, EventArgs e)
        {
            if (HO_TEN.Text == "")
            {
                lbl__HO_TEN.Text = "Vui lòng nhập họ tên";
                lbl__HO_TEN.ForeColor = Color.Red;
            }
            if (DIEN_THOAI.Text == "")
            {
                lbl_DIEN_THOAI.Text = "Vui lòng nhập số điện thoại";
                lbl_DIEN_THOAI.ForeColor = Color.Red;
            }
            if (QUE_QUAN.Text == "")
            {
                lbl_QUE_QUAN.Text = "Vui lòng nhập quê quán";
                lbl_QUE_QUAN.ForeColor = Color.Red;
            }
            if (EMAIL.Text == "")
            {
                lbl_EMAIL.Text = "Vui lòng nhập email";
                lbl_EMAIL.ForeColor = Color.Red;
            }
            if (DIA_CHI.Text == "")
            {
                lbl_DIA_CHI.Text = "Vui lòng nhập địa chỉ";
                lbl_DIA_CHI.ForeColor = Color.Red;
            }
            if (GIOI_TINH.Text == "")
            {
                lbl_GIOI_TINH.Text = "Vui lòng chọn giới tính";
                lbl_GIOI_TINH.ForeColor = Color.Red;
            }
            if (ANH.Image == null)
            {
                lbl_ANH.Text = "Vui lòng chọn ảnh";
                lbl_ANH.ForeColor = Color.Red;
            }
            string filename = System.IO.Path.GetFileName(ofdOpenFile.FileName);
            if (HO_TEN.Text != "" && GIOI_TINH.Text != "" && DIEN_THOAI.Text != "" && QUE_QUAN.Text != "" && EMAIL.Text != "" && DIA_CHI.Text != "" && ANH.Image != null)
            {
                string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
                conn = new SqlConnection(conString);
                conn.Open(); //Mở kết nối.
                string randomNumberUpdate = random.Next(100000, 999999).ToString();
                string temp = "";
                if (filename != "ofdOpenFile")
                {
                    if (temp != "") temp = temp + ", ";
                    temp = temp + "HinhAnh=N'\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename + "'";
                }


                string sql = "UPDATE dbo.NHANVIEN SET HoTenNV = N'" + HO_TEN.Text + "' ,GioiTinhNV = N'" + GIOI_TINH.Text + "', NgaySinhNV = '" + NGAY_SINH.Value.ToString() + "'" +
                             ",DienThoaiNV = '" + DIEN_THOAI.Text + "',EmailNV = N'" + EMAIL.Text + "',QueQuanNV = N'" + QUE_QUAN.Text + "',DiaChiNV = N'" + DIA_CHI.Text + "',NgayCapNhatNV = '"+ NGAY_CAP_NHAT.Value.ToString() +"' WHERE IDNhanVien = '" + ID_NHAN_VIEN.Text + "' " +

                             "UPDATE dbo.TAIKHOAN SET " + temp + "  WHERE IDNhanVien = '" + ID_NHAN_VIEN.Text + "'";

                if (filename != "ofdOpenFile")
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(ofdOpenFile.FileName, path + "\\image\\" + "IMG_UPLOAD_EDIT_" + randomNumberUpdate + filename);
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật");
                }
                else
                    MessageBox.Show("Thông tin nhân viên chưa được cập nhật");
                conn.Close();
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

        private void QUE_QUAN_TextChanged(object sender, EventArgs e)
        {
            lbl_QUE_QUAN.Text = "";
        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {
            lbl_EMAIL.Text = "";
        }

        private void DIA_CHI_TextChanged(object sender, EventArgs e)
        {
            lbl_DIA_CHI.Text = "";
        }

        private void GIOI_TINH_TextChanged(object sender, EventArgs e)
        {
            lbl_GIOI_TINH.Text = "";
        }

        private void ANH_SizeModeChanged(object sender, EventArgs e)
        {
            lbl_ANH.Text = "";
        }

        private void DIEN_THOAI_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
