using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddControlUsingCode
{
    public partial class frmXemNamTheoCanChi : Form
    {
        public frmXemNamTheoCanChi()
        {
            InitializeComponent();
        }

        private void frmXemNamTheoCanChi_Load(object sender, EventArgs e)
        {
            Label labelXemNam = new Label();
            labelXemNam.Text = "XEM NĂM THEO CAN CHI";
            labelXemNam.AutoSize = true;
            labelXemNam.ForeColor = Color.Chocolate;
            labelXemNam.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            labelXemNam.Location = new Point(200, 50);

            Controls.Add(labelXemNam);
        }
    }
}
