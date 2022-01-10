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
    public partial class frmTreView : Form
    {
        public frmTreView()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text != "")
            {
                TreeNode node = new TreeNode();
                node.Text = txtTenKhoa.Text;
                treKhoa.Nodes[0].Nodes.Add(node);
            }
        }
    }
}
