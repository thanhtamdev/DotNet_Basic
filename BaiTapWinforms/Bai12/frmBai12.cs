using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class frmBai12 : Form
    {
        public frmBai12()
        {
            InitializeComponent();
        }

        List<Region> regions = new List<Region>()
        {
            new Region("Khu vực 1", 50),
            new Region("Khu vực 2", 100),
            new Region("Khu vực 3", 150)
        };

        public void FillComboboxClass()
        {
            // Xác định nguồn cấp dữ liệu cho combobox
            cboRegion.DataSource = regions;
            cboRegion.ValueMember = "Quota";   // dữ liệu chạy ngầm bên trong
            cboRegion.DisplayMember = "RegionName";    // Dữ liệu hiển thị ra 
        }

        private void frmBai12_Load(object sender, EventArgs e)
        {
            FillComboboxClass();
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuota.Text = cboRegion.SelectedValue.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) ||
                !int.TryParse(txtOldNum.Text, out int n) ||
                !int.TryParse(txtNewNum.Text, out int m) ||
                (n > m) || n < 0 || m < 0)
            {
                MessageBox.Show("Không thể thực hiện thao tác. Vui lòng kiểm tra lại dữ liệu vừa nhập!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtConsume.Text = (m - n).ToString();
                int dinhMuc = Convert.ToInt32(txtQuota.Text);

                if (m - n <= dinhMuc)
                {
                    txtIntoMoney.Text = ((m - n) * 500).ToString();
                }
                else
                {
                    txtIntoMoney.Text = ((m - n) * 1000).ToString();
                }

                txtSum.Text = (Convert.ToInt32(txtSum.Text) + Convert.ToInt32(txtIntoMoney.Text)).ToString();

                ListViewItem listViewItem = new ListViewItem(txtName.Text);

                listViewItem.SubItems.Add(cboRegion.Text);
                listViewItem.SubItems.Add(txtQuota.Text);
                listViewItem.SubItems.Add(txtConsume.Text);
                listViewItem.SubItems.Add(txtIntoMoney.Text);
                lvwInfo.Items.Add(listViewItem);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuota.Clear();
            txtOldNum.Clear();
            txtNewNum.Clear();
            txtConsume.Clear();
            txtIntoMoney.Clear();
            cboRegion.SelectedIndex = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvwInfo.Items.Count == 0)
            {
                MessageBox.Show("Không thể thực hiện thao tác khi danh sách rỗng!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvwInfo.SelectedItems.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (ListViewItem ListItem in lvwInfo.Items)
                {
                    if (ListItem.Selected)
                    {
                        txtSum.Text = (Convert.ToInt32(txtSum.Text) - Convert.ToInt32(ListItem.SubItems[4].Text)).ToString();
                        lvwInfo.Items.Remove(ListItem);
                    }
                }
            }
        }

        private void frmBai12_KeyDown(object sender, KeyEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(e.KeyCode == Keys.Escape && result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
