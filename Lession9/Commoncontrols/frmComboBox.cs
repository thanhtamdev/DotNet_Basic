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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        public void FillComboBoxNamSinh()
        {
            for (int i = 1990; i <= 2010; i++)
            {
                cboNamSinh.Items.Add(i);
            }

            cboNamSinh.SelectedIndex = 0;
        }

        List<LopHoc> lopHocs = new List<LopHoc>()
        {
            new LopHoc("L01", "CNTT 13-01"),
            new LopHoc("L02", "CNTT 13-02"),
            new LopHoc("L03", "CNTT 13-03"),
            new LopHoc("C01", "CNTT 12-01"),
            new LopHoc("C02", "CNTT 12-02"),
            new LopHoc("C03", "CNTT 12-03")
        };

        // Phương thức điền dữ liệu vào xombobox
        public void FillComboBoxLopHoc()
        {
            //for (int i = 0; i < lopHocs.Count; i++)
            //{
            //    cboLop.Items.Add(lopHocs[i].TenLop);
            //}

            //cboLop.SelectedIndex = 0;

            // Xác định nguồn cấp dữ liệu cho combobox
            cboLop.DataSource = lopHocs;
            cboLop.ValueMember = "MaLop";   // dữ liệu chạy ngầm bên trong
            cboLop.DisplayMember = "TenLop";    // Dữ liệu hiển thị ra 
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            FillComboBoxNamSinh();
            FillComboBoxLopHoc();
        }
    }
}
