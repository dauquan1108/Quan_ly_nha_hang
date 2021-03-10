using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace KHOALUAN
{
    public partial class TAO_MON : UserControl
    {
        public TAO_MON()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void ID_MON_Click(object sender, EventArgs e)
        {
            String ketnoi = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(ketnoi);
            conn.Open();
            string sql = "SELECT IDMon FROM dbo.DANHSACHMON";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu vào kho 

            ID_MON.DisplayMember = "IDMon";
            ID_MON.DataSource = dt;
            //TEN_MON.DataBindings.Clear();
            //TEN_MON.DataBindings.Add("Text", ID_MON.DataSource, "TenMon");
            
            conn.Close();

        }

        private void ID_MON_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //TEN_MON.DataSource = dt;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {   

            
        }
    }
}
