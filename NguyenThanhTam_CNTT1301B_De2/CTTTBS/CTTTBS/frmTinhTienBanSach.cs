using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTTTBS
{
    public partial class frmTinhTienBanSach : Form
    {
        public frmTinhTienBanSach()
        {
            InitializeComponent();
        }

        List<KhachHang> khachHangs = new List<KhachHang>();

        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int sls = Convert.ToInt32(txtSLS.Text);

                if (String.IsNullOrEmpty(txtTenKH.Text) || sls < 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin bạn vừa nhập.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double thanhTien = Convert.ToInt32(txtSLS.Text) * 20_000;

                    if (chkKHSV.Checked)
                    {
                        thanhTien -= thanhTien * 0.05;
                    }

                    txtThanhTien.Text = thanhTien.ToString();
                    btnTT.Focus();
                }
                
                khachHangs.Insert(0,new KhachHang() { TenKH = txtTenKH.Text, ThanhTien = Convert.ToInt32(txtThanhTien.Text), SinhVien = chkKHSV.Checked });
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtTenKH.Focus();
            txtSLS.Clear();
            chkKHSV.Checked = false;
        }  

        private void btnKT_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongKH.Text = khachHangs.Count.ToString();

            int countSV = 0;
            int tongdt = 0;

            foreach (var item in khachHangs)
            {
                tongdt += item.ThanhTien;

                if (item.SinhVien == true)
                {
                    countSV++;
                }
            }

            txtTongKHSV.Text = countSV.ToString();
            txtTongDoanhThu.Text = tongdt.ToString();
        }
    }
}
