using Commoncontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuAndToolBar
{
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmListView frm = new frmListView();
            frm.Show();
            //frm.ShowDialog();
        }
    }
}
