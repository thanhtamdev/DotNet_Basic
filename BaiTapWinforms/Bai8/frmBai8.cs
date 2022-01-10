using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class frmBai8 : Form
    {
        public frmBai8()
        {
            InitializeComponent();
        }

        private bool CheckData(string s)
        {
            char[] arr = s.ToCharArray();
            var isNumeric = double.TryParse(s, out _);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == ',')
                {
                    return false;
                }
            }

            bool ck = (Char.IsNumber(arr[0]) && Char.IsNumber(arr[arr.Length - 1])) ||
                (arr[0] == '-' && Char.IsNumber(arr[arr.Length - 1]));

            if (!ck || !isNumeric)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Sự kiện khi nhấn phím enter
        /// 
        /// Nhấn enter:
        /// -  Nếu dữ liệu nhập vào text box là 1 số thì thêm vào listbox
        /// - Ngược lại, thông báo dữ liệu không hợp lệ
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(txtNhap.Text, out int n))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập lại!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhap.Text = "";

                    return;
                }
                else
                {
                    lstSo.Items.Add(txtNhap.Text);
                    txtNhap.Focus();
                    txtNhap.Text = "";
                }
            }
        }

        /// <summary>
        /// Click button Nhập 
        /// 
        /// Nếu dữ liệu ô textbox là số thì thêm vào listbox
        /// Ngược lại thông báo lỗi
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhap.Text, out int n))
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Text = "";
                return;
            }
            else
            {
                lstSo.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }


        /// <summary>
        /// Click button tính tổng các phần tử
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSumAll_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sum = 0;

                for (int i = 0; i < lstSo.Items.Count; i++)
                {
                    sum += Convert.ToInt32(lstSo.Items[i]);
                }

                MessageBox.Show("Tổng các phần tử có trong danh sách: " + sum, "Result",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Click button Xóa phần tử đầu và cuối danh sách
        /// Xóa phần tử đầu và cuối danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelHeadTail_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count > 1)
            {
                lstSo.Items.RemoveAt(0);
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            }
            else if (lstSo.Items.Count == 1)
            {
                lstSo.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Click button xóa phần tử đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelSelect_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count >= 1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstSo);
                selectedItems = lstSo.SelectedItems;

                if (lstSo.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        lstSo.Items.Remove(selectedItems[i]);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn số cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Click button Tăng mỗi phần tử lên 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < lstSo.Items.Count; i++)
                {
                    lstSo.Items[i] = (Convert.ToInt32(lstSo.Items[i]) + 2).ToString();
                }
            }
        }

        /// <summary>
        /// Click -> thay các phần tử bằng bình phương của nó
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubstitute_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < lstSo.Items.Count; i++)
                {
                    lstSo.Items[i] = (Convert.ToInt32(lstSo.Items[i]) * Convert.ToInt32(lstSo.Items[i])).ToString();
                }
            }
        }

        /// <summary>
        /// Click button -> hiện các số chẵn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> lt = new List<string>();
                string str = null;

                foreach (var item in lstSo.Items)
                {
                    if (Convert.ToInt32(item) % 2.0 == 0)
                    {
                        lt.Add(item.ToString()); //store the items in the list
                        str += item + "\n";    //store the items in the string
                    }
                }

                if (str == null)
                {
                    MessageBox.Show("Không có số chẵn trong danh sách!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Các số chẵn trong List: \n" + str, "Ressult", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// click button -> lọc ra số lẻ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng. Vui lòng nhập dữ liệu cho danh sách!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> lt = new List<string>();
                string str = null;

                foreach (var item in lstSo.Items)
                {
                    if (Convert.ToInt32(item) % 2 != 0)
                    {
                        lt.Add(item.ToString()); //store the items in the list
                        str += item + "\n";    //store the items in the string
                    }
                }

                if (str == null)
                {
                    MessageBox.Show("Không có số lẻ trong danh sách!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Các số lẻ trong List: \n" + str, "Ressult", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// click button -> Xác nhận thoát hay không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTheEnd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
