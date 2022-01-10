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
using VTDT.DTO;
using VTDT.UTIL;

namespace VTDT.GUI
{
    public partial class frmCapCQBH : Form
    {
        public Action<string, string, string> Sender;

        CapCQBHBLL bllCapCQBH = null;

        public frmCapCQBH()
        {
            InitializeComponent();

            Sender = GetInfo;
        }

        // Khai báo event
        public event EventHandler Button_Clicked;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCapCQBH.Text != null && txtTenCapCQBH.Text != null)
            {
                CapCQBH capCQBH = new CapCQBH();
                capCQBH.MaCapCQBH = txtMaCapCQBH.Text;
                capCQBH.TenCapCQBH = txtTenCapCQBH.Text;
                capCQBH.GhiChu = txtGhiChu.Text;

                bllCapCQBH = new CapCQBHBLL();

                try
                {
                    if (Common.flag == 0)
                    {
                        if (bllCapCQBH.Insert(capCQBH))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (Common.flag == 1)
                    {

                    }
                    {
                        if (bllCapCQBH.Update(capCQBH))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Khi có sự kiện xảy ra
                if (Button_Clicked != null)
                {
                    // Phá sinh sự kiện
                    Button_Clicked(sender, e);
                }
            }
        }

        public void GetInfo(string maCapCQBH, string tenCapCQBH, string ghiChu)
        {
            txtMaCapCQBH.Text = maCapCQBH;
            txtTenCapCQBH.Text = tenCapCQBH;
            txtGhiChu.Text = ghiChu;
        }
    }
}
