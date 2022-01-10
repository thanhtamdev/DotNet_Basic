using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commoncontrols
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            prbTinhTong.Value = 0;
            prbTinhTong.Maximum = 100;
            prbTinhTong.Minimum = 0;
            prbTinhTong.Step = 10;

            int sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum += i;
                Thread.Sleep(1000);
                prbTinhTong.PerformStep();
            }
        }
    }
}
