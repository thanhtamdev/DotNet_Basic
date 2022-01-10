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
    public partial class frmCapCQBHList : Form
    {
        CapCQBHBLL bllCapCQBH = null;
        public frmCapCQBHList()
        {
            InitializeComponent();
        }

        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Common.flag = 0;
            frmCapCQBH frm = new frmCapCQBH();
            frm.Text = "Thêm mới cấp CQBH";
            // Đăng kí theo dõi sự kiện
            frm.Button_Clicked += (x, y) => LoadData();
            
            frm.ShowDialog();
        }

        // Phuong thuc lodad du lieu tu database
        public void LoadData()
        {
            bllCapCQBH = new CapCQBHBLL();
            List<CapCQBH> list = new List<CapCQBH>();
            

            try
            {
                list = bllCapCQBH.GetALL();
                dgvCapCQBH.DataSource = list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmCapCQBHList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CapCQBH capCQBH = new CapCQBH();
            capCQBH.MaCapCQBH = dgvCapCQBH.CurrentRow.Cells[0].Value.ToString();
            bllCapCQBH = new CapCQBHBLL();

            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bllCapCQBH.Delete(capCQBH))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.flag = 1;
            string maCapCQBH = dgvCapCQBH.CurrentRow.Cells[0].Value.ToString();
            string tenCapCQBH = dgvCapCQBH.CurrentRow.Cells[1].Value.ToString();
            string ghiChu = dgvCapCQBH.CurrentRow.Cells[2].Value.ToString();

            frmCapCQBH frm = new frmCapCQBH();
            frm.Sender(maCapCQBH, tenCapCQBH, ghiChu);
            frm.Button_Clicked += (x, y) => LoadData();
            frm.ShowDialog();
        }
    }
}
