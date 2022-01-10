using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class frmBai11 : Form
    {
        public frmBai11()
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
        private void frmBai11_Load(object sender, EventArgs e)
        {
            FillComboboxClass();

            cmnuList.Items.Add("Small");
            cmnuList.Items.Add("List");
            cmnuList.Items.Add("Title");

            this.cmnuList.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMenuItem1.Image = System.Drawing.Image.FromFile(@"D:\Learn .NET\BaiTapWinforms\Bai11\img\close.png");
            this.toolStripMenuItem2.Image = System.Drawing.Image.FromFile(@"D:\Learn .NET\BaiTapWinforms\Bai11\img\snowflake.png");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            dtpBirth.Value = DateTime.Today;
            txtID.Focus();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtFullName.Text)
                && !String.IsNullOrEmpty(txtAddress.Text))
            {
                ListViewItem listViewItem = new ListViewItem(txtID.Text);
                listViewItem.SubItems.Add(txtFullName.Text);
                listViewItem.SubItems.Add(txtAddress.Text);
                listViewItem.SubItems.Add(dtpBirth.Value.ToString());
                listViewItem.SubItems.Add(cboClass.Text);
                lvwStudent.Items.Add(listViewItem);
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvwStudent.Items.Count == 0)
            {
                MessageBox.Show("Không thể thực hiện thao tác khi danh sách rỗng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvwStudent.SelectedItems.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (ListViewItem ListItem in lvwStudent.Items)
                {
                    if (ListItem.Selected)
                    {
                        lvwStudent.Items.Remove(ListItem);
                    }
                }
            }
        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem ListItem in lvwStudent.Items)
            {
                if (ListItem.Selected)
                {
                    txtID.Text = ListItem.SubItems[0].Text;
                    txtFullName.Text = ListItem.SubItems[1].Text;
                    txtAddress.Text = ListItem.SubItems[2].Text;
                    dtpBirth.Value = DateTime.Parse(ListItem.SubItems[3].Text);
                    cboClass.Text = ListItem.SubItems[4].Text;
                }
            }
        }

        private void lvwStudent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmnuList.Show(this, Cursor.Position);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
