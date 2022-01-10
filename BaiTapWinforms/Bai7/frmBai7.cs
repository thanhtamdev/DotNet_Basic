using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class frmBai7 : Form
    {
        public frmBai7()
        {
            InitializeComponent();
        }

        /// <summary>
        /// xử lí sự kiện khi nhấn phím enter
        /// Kiểm tra dữ liệu textbox có hợp lệ không?
        /// - Nếu dữ liệu hợp lệ:
        ///     -> thêm dữ liệu vào combobox
        ///     -> đặt trỏ chuột vào textbox và xóa dữ liệu đã nhập trước đó
        /// - Nếu dữ liệu không hợp lệ
        ///     -> hiện popup thông báo dữ liệu không hợp lệ
        ///     -> đặt trỏ chuột vào textbox và xóa dữ liệu đã nhập trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(txtNhapSo.Text, out int n))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhapSo.Text = "";
                    return;
                }
                else
                {
                    cboSo.Items.Add(txtNhapSo.Text);
                    txtNhapSo.Text = "";
                }
            }
        }

        /// <summary>
        /// Xử lí sự kiện khi nhấn chọn button cập nhật
        /// 
        /// Kiểm tra dữ liệu textbox có hợp lệ không?
        /// - Nếu dữ liệu hợp lệ:
        ///     -> thêm dữ liệu vào combobox
        ///     -> đặt trỏ chuột vào textbox và xóa dữ liệu đã nhập trước đó
        /// - Nếu dữ liệu không hợp lệ
        ///     -> hiện popup thông báo dữ liệu không hợp lệ
        ///     -> đặt trỏ chuột vào textbox và xóa dữ liệu đã nhập trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSo.Text, out int n))
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.Text = "";
                return;
            }
            else
            {
                cboSo.Items.Add(txtNhapSo.Text);
                txtNhapSo.Clear();
            }
        }

        /// <summary>
        /// Kiểm tra 1 số có là số nguyên tố hay không
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool KtraSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Sự kiện chọn 1 số trong combobox và hiển thị các ước lên listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUoc.Items.Clear();

            int n = Convert.ToInt32(cboSo.SelectedItem);

            for (int i = 0; i < cboSo.Items.Count; i++)
            {
                if (i == cboSo.SelectedIndex)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (n % j == 0)
                        {
                            lstUoc.Items.Add(j);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sự kiện click button tính tổng các ước
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < lstUoc.Items.Count; i++)
            {
                sum += Convert.ToInt32(lstUoc.Items[i]);
            }

            MessageBox.Show("Tổng các ước của " + cboSo.SelectedItem + " là: " + sum,
                "Result", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Sự kiện click button đếm số lượng ước số chẵn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSLUocChan_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < lstUoc.Items.Count; i++)
            {
                if (Convert.ToInt32(lstUoc.Items[i]) % 2 == 0)
                {
                    count++;
                }
            }

            MessageBox.Show("Số lượng ước chẵn của " + cboSo.SelectedItem + " là: " + count,
                "Result", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Sự kiện click button đếm số lượng ước số nguyên tố
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSLUocSNT_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < lstUoc.Items.Count; i++)
            {
                if (KtraSNT(Convert.ToInt32(lstUoc.Items[i])))
                {
                    count++;
                }
            }

            MessageBox.Show("Số lượng ước nguyên tố của " + cboSo.SelectedItem + " là: " + count,
                "Result", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Sự kiện click button thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
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
