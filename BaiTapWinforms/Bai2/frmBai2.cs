using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtNhapNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNhapNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXem_Click(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnThoat_Click(this, new EventArgs());
            }
        }

        List<string> can = new List<string>()
        {
            "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất","Bính", "Đinh", "Mậu","Kỉ"
        };

        List<string> chi = new List<string>()
        {
            "Thân", "Dậu", "Tuất", "Hợi",
            "Tý", "Sửu", "Dần", "Mão",
            "Thìn", "Tỵ", "Ngọ", "Mùi"
        };

        private void btnXem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < can.Count; i++)
            {
                if (Convert.ToInt32(txtNhapNam.Text) % 10 == i)
                {
                    txtKetQua.Text += can[i];
                }
            }

            for (int i = 0; i < chi.Count; i++)
            {
                if (Convert.ToInt32(txtNhapNam.Text) % 12 == i)
                {
                    txtKetQua.Text += " " + chi[i];
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapNam.Clear();
            txtKetQua.Clear();
            txtNhapNam.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
