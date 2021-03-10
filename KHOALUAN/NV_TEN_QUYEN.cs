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
    public partial class NV_TEN_QUYEN : UserControl
    {

        SqlConnection conn;

        public NV_TEN_QUYEN()
        {
            InitializeComponent();
        }

        private void NV_TEN_QUYEN_Load(object sender, EventArgs e)
        {
            String ketnoi = ConfigurationManager.ConnectionStrings["KETNOI"].ConnectionString.ToString();
            conn = new SqlConnection(ketnoi);
            conn.Open();
            String sql = "SELECT * FROM dbo.QUYEN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
    }
}
