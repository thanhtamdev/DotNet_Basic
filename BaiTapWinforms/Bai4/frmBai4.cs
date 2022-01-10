using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        // Tính tiền
        // Nếu tên khách hàng bị trống -> thông báo tên khách hàng bị trống
        // Ngược lại -> tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tongTien = 0;

                if (chkLayCao.Checked)
                {
                    tongTien += 100_000;
                }

                if (chkTayRang.Checked)
                {
                    tongTien += 1_200_000;
                }

                if (chkChupRang.Checked)
                {
                    tongTien += 200_000;
                }

                tongTien += Convert.ToInt32(numTramRang.Value) * 80_000;

                txtTongTien.Text = tongTien.ToString();
            }
        }

        // click vào button thoát xác nhận xem người dùng có muốn thoát không?
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
