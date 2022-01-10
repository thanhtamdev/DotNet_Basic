using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private bool CheckData(string s)
        {
            char[] arr = s.ToCharArray();
            var isNumeric = double.TryParse(s, out _);

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] == ',')
                {
                    return false;
                }
            }

            bool ck = (Char.IsNumber(arr[0]) && Char.IsNumber(arr[arr.Length - 1])) || 
                (arr[0] == '-' && Char.IsNumber(arr[arr.Length - 1]));

            if (!ck || !isNumeric)
            {
                return false;
            }
            return true;
        }

        private void txtHeSoA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeSoA.Text) || !CheckData(txtHeSoA.Text))
            {
                e.Cancel = true;
                txtHeSoA.Focus();
                errorProviderA.SetError(txtHeSoA, "Dữ liệu bạn vừa nhập không hợp lệ!");
                btnGiai.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProviderA.SetError(txtHeSoA, "");

                if (!string.IsNullOrWhiteSpace(txtHeSoB.Text) && CheckData(txtHeSoB.Text))
                {
                    btnGiai.Enabled = true;
                    btnGiai.Focus();
                }
            }
        }

        private void txtHeSoB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeSoB.Text) || !CheckData(txtHeSoB.Text))
            {
                e.Cancel = true;
                txtHeSoB.Focus();
                errorProviderA.SetError(txtHeSoB, "Dữ liệu bạn vừa nhập không hợp lệ!");
                btnGiai.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProviderA.SetError(txtHeSoB, "");

                if (!string.IsNullOrWhiteSpace(txtHeSoA.Text) || CheckData(txtHeSoA.Text))
                {
                    btnGiai.Enabled = true;
                    btnGiai.Focus();
                }
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtHeSoA.Text);
            double b = Convert.ToDouble(txtHeSoB.Text);

            if (a != 0)
            {
                txtKetQua.Text = ((-b) / a).ToString();
            }
            else if (b == 0)
            {
                txtKetQua.Text = "Phương trình có vô số nghiệm.";
            }
            else
            {
                txtKetQua.Text = "Phương trình vô nghiệm.";
            }

            btnXoa.Enabled = true;
            btnGiai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHeSoA.Clear();
            txtHeSoB.Clear();
            txtKetQua.Clear();
            txtHeSoA.Focus();
        }

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
