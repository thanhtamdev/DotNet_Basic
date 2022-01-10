using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddControlUsingCode
{
    public partial class frmDemoEvent : Form
    {
        public frmDemoEvent()
        {
            InitializeComponent();
        }

        public void XoaTextBoxTong(object sender, EventArgs e)
        {
            txtTongSach.Text = "";
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;


            if (txtKienHang.Text != "")
            {
                a = Convert.ToInt32(txtKienHang.Text);
            }

            if (txtSachMoiKien.Text != "")
            {
                b = Convert.ToInt32(txtSachMoiKien.Text);
            }

            int tong = a * b;
            txtTongSach.Text = tong.ToString();
        }
    }
}
