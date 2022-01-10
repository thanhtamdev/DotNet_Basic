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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
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
            cboLopHoc.DataSource = lopHocs;
            cboLopHoc.ValueMember = "MaLop";   // dữ liệu chạy ngầm bên trong
            cboLopHoc.DisplayMember = "TenLop";    // Dữ liệu hiển thị ra 
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            FillComboBoxLopHoc();
        }

        public void RefreshData()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaSV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHoTen.Text != "")
            {
                ListViewItem item = new ListViewItem(txtMaSV.Text);
                item.SubItems.Add(txtHoTen.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(dtpNgaySinh.Value.ToString());
                item.SubItems.Add(cboLopHoc.Text);
                lvwSinhVien.Items.Add(item);

                RefreshData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwSinhVien.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = lvwSinhVien.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        int index = lvwSinhVien.SelectedIndices[i];
                        lvwSinhVien.Items.RemoveAt(index);
                    }
                }
            }
        }
    }
}
