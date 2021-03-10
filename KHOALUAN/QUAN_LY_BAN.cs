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
    public partial class QUAN_LY_BAN : UserControl
    {
        SqlConnection conn;

        public QUAN_LY_BAN()
        {
            InitializeComponent();
        }
        public void Ban()
        {
            string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open(); //Mở kết nối.           
            string sql = "SELECT * FROM dbo.BAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow r = dt.Rows[i];
                Button btn = new Button();
                btn.ImageList = imageList1;
                btn.Location = new System.Drawing.Point(520, 270);
                btn.Name = " " + r["IDBan"];
                btn.Size = new System.Drawing.Size(142, 100);
                btn.TabIndex = 2;
                btn.Text = r["TenKhuVuc"] + ": " + r["TenBan"];
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.UseVisualStyleBackColor = true;
                btn.ImageKey = "1";
                btn.Visible = true;
                btn.Click += new System.EventHandler(this.banClick);
                //flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(btn);
            }
            conn.Close();
        }

        private void banClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ImageKey = "2";
            ID_BAN.Text = btn.Name;
            TEN_KHU_VUC.Text = btn.Text;
            //MessageBox.Show(btn.Name);
        }

        private void QUAN_LY_BAN_Load(object sender, EventArgs e)
        {
            Ban();
        }

        private void BTN_CO_KHACH_Click(object sender, EventArgs e)
        {
            //string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            //conn = new SqlConnection(conString);
            //conn.Open(); //Mở kết nối.           
            //string sql = "SELECT * FROM dbo.BAN WHERE TrangThai = N'Bàn có khách'";
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow r = dt.Rows[i];
            //    Button btn = new Button();
            //    btn.ImageList = imageList1;
            //    btn.Location = new System.Drawing.Point(520, 270);
            //    btn.Name = " " + r["IDBan"];
            //    btn.Size = new System.Drawing.Size(142, 100);
            //    btn.TabIndex = 2;
            //    btn.Text = r["TenKhuVuc"] + ": " + r["TenBan"];
            //    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //    btn.UseVisualStyleBackColor = true;
            //    btn.ImageKey = "1";
            //    btn.Visible = true;
            //    btn.Click += new System.EventHandler(this.banClick);
            //    flowLayoutPanel1.Controls.Clear();
            //    flowLayoutPanel1.Controls.Add(btn);
            //}
            //conn.Close();
        }

        private void BTN_TRONG_Click(object sender, EventArgs e)
        {
            //string conString = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            //conn = new SqlConnection(conString);
            //conn.Open(); //Mở kết nối.           
            //string sql = "SELECT * FROM dbo.BAN WHERE TrangThai = N'Bàn trống'";
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow r = dt.Rows[i];
            //    Button btn = new Button();
            //    btn.ImageList = imageList1;
            //    btn.Location = new System.Drawing.Point(520, 270);
            //    btn.Name = " " + r["IDBan"];
            //    btn.Size = new System.Drawing.Size(142, 100);
            //    btn.TabIndex = 2;
            //    btn.Text = r["TenKhuVuc"] + ": " + r["TenBan"];
            //    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //    btn.UseVisualStyleBackColor = true;
            //    btn.ImageKey = "1";
            //    btn.Visible = true;
            //    btn.Click += new System.EventHandler(this.banClick);
            //    flowLayoutPanel1.Controls.Clear();
            //    flowLayoutPanel1.Controls.Add(btn);
            //}
            //conn.Close();
        }
    }
}
