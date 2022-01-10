using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void rbTimeNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimeNewRoman.Checked)
            {
                txtVB.Font = new Font("Times New Roman", 12);
            }
        }

        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArial.Checked)
            {
                txtVB.Font = new Font("Arial", 12);
            }
        }

        private void rbTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTahoma.Checked)
            {
                txtVB.Font = new Font("Tahoma", 12);
            }
        }

        private void rbCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCourierNew.Checked)
            {
                txtVB.Font = new Font("Courier New", 12);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
