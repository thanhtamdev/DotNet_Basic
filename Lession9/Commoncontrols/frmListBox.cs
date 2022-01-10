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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // thêm sinh viên vào list box lớp A
                lstLopA.Items.Add(txtHoten.Text);

                // reset text box sau mỗi lần nhập
                txtHoten.Text = "";
            }
        }

        private void btnASangB_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có chọn sinh viên lớp A không
            if (lstLopA.SelectedItems.Count > 0)
            {
                foreach (object item in lstLopA.SelectedItems)
                {
                    lstLopB.Items.Add(item);    // Thêm vào lớp B
                }

                // Viết code xóa các phần tử đã chuyển từ lớp A qua lớp B
            }
        }

        private void btnASangBAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                lstLopB.Items.Add(lstLopA.Items[i]);
            }

            lstLopA.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xóa tên sinh viên được chọn trong list A
            if (lstLopA.SelectedItems.Count > 0)
            {
                //ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstLopA);
                //selectedItems = lstLopA.SelectedItems;

                //if (lstLopA.SelectedIndex != -1)
                //{
                //    for (int i = selectedItems.Count - 1; i >= 0; i--)
                //        lstLopA.Items.Remove(selectedItems[i]);
                //}
                //else
                //    MessageBox.Show("Vui lòng chọn họ tên sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                for (int i = lstLopA.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int indexDel = lstLopA.SelectedIndices[i];
                    lstLopA.Items.RemoveAt(indexDel);
                }
            }
        }
    }
}
