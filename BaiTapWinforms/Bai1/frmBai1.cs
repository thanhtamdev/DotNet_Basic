using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoA.Text);
            double b = Convert.ToDouble(txtSoB.Text);
            double res = a + b;

            txtKetQua.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoA.Text);
            double b = Convert.ToDouble(txtSoB.Text);
            double res = a - b;

            txtKetQua.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoA.Text);
            double b = Convert.ToDouble(txtSoB.Text);
            double res = a * b;

            txtKetQua.Text = res.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoA.Text);
            double b = Convert.ToDouble(txtSoB.Text);

            if (b != 0)
            {
                double res = a / b;

                txtKetQua.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số b khác 0!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
