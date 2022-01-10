using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTDT.BLL;
using VTDT.UTIL;

namespace VTDT.GUI
{
    public partial class frmDangNhap : Form
    {
        NhanSuBLL bllNhanSu = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ProcessingLogic logic = new ProcessingLogic();

            //if (txtTenTK.Text != "" && txtMatKhau.Text != "")
            //{
            //    bllNhanSu = new NhanSuBLL();

            //    try
            //    {
            //        if (bllNhanSu.Login(txtTenTK.Text, txtMatKhau.Text)
            //        {
            //            this.Hide();
            //        } else
            //        {
            //            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}
