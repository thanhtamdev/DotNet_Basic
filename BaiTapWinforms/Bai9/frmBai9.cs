using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        List<Lop> lopHocs = new List<Lop>()
        {
            new Lop("LA", "Lớp A"),
            new Lop("LB", "Lớp B")
        };

        public void FillComboboxClass()
        {
            // Xác định nguồn cấp dữ liệu cho combobox
            cboClass.DataSource = lopHocs;
            cboClass.ValueMember = "MaLop";   // dữ liệu chạy ngầm bên trong
            cboClass.DisplayMember = "TenLop";    // Dữ liệu hiển thị ra 
        }
        private void frmBai9_Load(object sender, EventArgs e)
        {
            FillComboboxClass();
        }

        /// <summary>
        /// Nhấn enter:
        ///     - Nếu tên sinh viên là rỗng thì báo lỗi
        ///     - Ngược lại: add tên sinh viên vào danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFulName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFulName.Text == "")
                {
                    MessageBox.Show("Tên không được để trống. Vui lòng nhập lại!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFulName.Focus();
                }
                else
                {
                    if (cboClass.SelectedValue.ToString() == "LB")
                    {
                        lstClassB.Items.Add(txtFulName.Text);
                        txtFulName.Clear();
                        txtFulName.Focus();
                    }

                    lstClassA.Items.Add(txtFulName.Text);
                    txtFulName.Clear();
                    txtFulName.Focus();
                }
            }
        }

        // click button cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFulName.Text == "")
            {
                MessageBox.Show("Tên không được để trống. Vui lòng nhập lại!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFulName.Focus();
            }
            else
            {
                if (cboClass.SelectedValue.ToString() == "LB")
                {
                    lstClassB.Items.Add(txtFulName.Text);
                    txtFulName.Clear();
                    txtFulName.Focus();
                }

                lstClassA.Items.Add(txtFulName.Text);
                txtFulName.Clear();
                txtFulName.Focus();
            }
        }

        // chuyển các phần tử được chọn trong danh sách lớp A sang lớp B
        private void btnMoveAToB_Click(object sender, EventArgs e)
        {
            if (lstClassA.Items.Count >= 1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstClassA);
                selectedItems = lstClassA.SelectedItems;

                if (lstClassA.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        lstClassB.Items.Add(selectedItems[i]);
                        lstClassA.Items.Remove(selectedItems[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tên sinh viên cần chuyển!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chuyển tất cả các sinh viên trong danh sách lớp A sang lớp B
        private void btnMoveAtoBAll_Click(object sender, EventArgs e)
        {
            if (lstClassA.Items.Count == 0)
            {
                MessageBox.Show("Danh sách trống. Không thể thực hiện thao tác!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < lstClassA.Items.Count; i++)
                {
                    lstClassB.Items.Add(lstClassA.Items[i]);
                }

                lstClassA.Items.Clear();
            }
        }

        // di chuyển các phần tử được chọn từ lớp B qua lớp A
        private void btnMoveBToA_Click(object sender, EventArgs e)
        {
            if (lstClassB.Items.Count >= 1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstClassB);
                selectedItems = lstClassB.SelectedItems;

                if (lstClassB.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        lstClassA.Items.Add(selectedItems[i]);
                        lstClassB.Items.Remove(selectedItems[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tên sinh viên cần chuyển!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng. Không thể thực hiện thao tác!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chuyển tất cả các phần tử có trong B sang A
        private void btnMoveBToAAll_Click(object sender, EventArgs e)
        {
            if (lstClassB.Items.Count == 0)
            {
                MessageBox.Show("Danh sách trống. Không thể thực hiện thao tác!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < lstClassB.Items.Count; i++)
                {
                    lstClassA.Items.Add(lstClassB.Items[i]);
                }

                lstClassB.Items.Clear();
            }
        }

        // xóa các giá trị được chọn trong list A
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstClassA.Items.Count >= 1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstClassA);
                selectedItems = lstClassA.SelectedItems;

                if (lstClassA.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        lstClassA.Items.Remove(selectedItems[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tên sinh viên cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTheEnd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result ==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
