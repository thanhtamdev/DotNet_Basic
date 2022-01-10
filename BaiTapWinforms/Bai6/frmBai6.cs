using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private void rbVietNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVietNam.Checked)
            {
                picFlags.Image = Image.FromFile("D:\\Learn .NET\\BaiTapWinforms\\Bai6\\img\\vn.png");
            }
        }

        private void rbUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUSA.Checked)
            {
                picFlags.Image = Image.FromFile("D:\\Learn .NET\\BaiTapWinforms\\Bai6\\img\\usa.png");
            }
        }

        private void rbItalia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbItalia.Checked)
            {
                picFlags.Image = Image.FromFile("D:\\Learn .NET\\BaiTapWinforms\\Bai6\\img\\italia.png");
            }
        }

        private void rbPhilipine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPhilipine.Checked)
            {
                picFlags.Image = Image.FromFile("D:\\Learn .NET\\BaiTapWinforms\\Bai6\\img\\philipine.png");
            }
        }
    }
}
