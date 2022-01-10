using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commoncontrols
{
    public partial class frmDeltalPayment : Form
    {
        public frmDeltalPayment()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Code xử lí sự kiện
            this.Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            if (chkLayCaoRang.Checked)
            {
                tongTien += 100000;
            }

            if (chkTayTrangRang.Checked)
            {
                tongTien += 1200000;
            }

            if (chkChupHinhRang.Checked)
            {
                tongTien += 200000;
            }

            tongTien += Convert.ToInt32(numTramRang.Value) * 80000;

            txtTongTien.Text = tongTien.ToString();
        }
    }
}
