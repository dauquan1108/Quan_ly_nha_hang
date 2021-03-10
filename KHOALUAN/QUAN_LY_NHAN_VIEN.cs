using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHOALUAN
{
    public partial class QUAN_LY_NHAN_VIEN : UserControl
    {
        public QUAN_LY_NHAN_VIEN()
        {
            InitializeComponent();
            NHAN_VIEN.BringToFront();
        } 
        
        private void BTN_NHAN_VIEN_Click(object sender, EventArgs e)
        {
            NHAN_VIEN.BringToFront();
        }

        private void TAI_KHOAN_Click_1(object sender, EventArgs e)
        {
            TAI_KHOAN1.BringToFront();
        }

        private void QUYEN_TAI_KHOAN_Click_1(object sender, EventArgs e)
        {
            QUYEN_TAI_KHOAN1.BringToFront();
        }
    }
}
