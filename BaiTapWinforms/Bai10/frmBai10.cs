using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class frmBai10 : Form
    {
        public frmBai10()
        {
            InitializeComponent();
        }

        List<Lop> lopHocs = new List<Lop>()
        {
            new Lop("IT1", "Công nghệ thông tin"),
            new Lop("IT2", "An toàn thông tin"),
            new Lop("IT3", "Kỹ thuật điện tử - viễn thông")
        };

        List<SchoolYear> years = new List<SchoolYear>()
        {
            new SchoolYear(2021),
            new SchoolYear(2020),
            new SchoolYear(2019),
            new SchoolYear(2018),
            new SchoolYear(2017),
            new SchoolYear(2016)
        };

        public void FillComboboxClass()
        {
            // Xác định nguồn cấp dữ liệu cho combobox
            cboClass.DataSource = lopHocs;
            cboClass.ValueMember = "TenLop";   // dữ liệu chạy ngầm bên trong
            cboClass.DisplayMember = "MaLop";    // Dữ liệu hiển thị ra 
            cboYear.DataSource = years;
            cboYear.ValueMember = "Year";
            cboYear.DisplayMember = "Year";
        }

        private void frmBai10_Load(object sender, EventArgs e)
        {
            FillComboboxClass();
        }

        string schoolYear = "";
        private void rdoIV_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                schoolYear = radio.Text;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtID.Text)
                || chklstSubject.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu đăng kí!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string registerSubject = "";
                int i = 0;

                foreach (var item in chklstSubject.CheckedItems)
                {
                    i++;
                    registerSubject += " " + i + ". " + (item.ToString()) + "\n";
                }

                MessageBox.Show(" Sinh viên: " + txtFullName.Text +
                "\n Lớp: " + cboClass.Text
                + "\n Niên khóa: " + cboYear.Text +
                "\n Đã đăng kí học kì " + schoolYear
                + " các học phần: \n" + registerSubject,
                "Thông tin đăng kí học phần", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtID.Clear();
            cboClass.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            rdoI.Checked = true;
            rdoII.Checked = false;
            rdoIII.Checked = false;
            rdoIV.Checked = false;

            while (chklstSubject.CheckedIndices.Count > 0)
            {
                chklstSubject.SetItemChecked(chklstSubject.CheckedIndices[0], false);
            }
        }
    }
}
