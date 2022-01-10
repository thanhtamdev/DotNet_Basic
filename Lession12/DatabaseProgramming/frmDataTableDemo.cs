using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProgramming
{
    public partial class frmDataTableDemo : Form
    {
        public frmDataTableDemo()
        {
            InitializeComponent();
        }

        private void frmDataTableDemo_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DataColumn dcMaKhoa = new DataColumn("MaKhoa", typeof(string));
            DataColumn dcTenKhoa = new DataColumn("TenKhoa", typeof(string));
            DataColumn dcDienThoai = new DataColumn("DienThoai", typeof(string));

            table.Columns.Add(dcMaKhoa);
            table.Columns.Add(dcTenKhoa);
            table.Columns.Add(dcDienThoai);

            DataRow dr = null;
            dr = table.NewRow();
            dr[0] = "IT1";
            dr[1] = "Công nghệ thông tin";
            dr[2] = "0123456789";
            table.Rows.Add(dr);

            dr = table.NewRow();
            dr[0] = "IT2";
            dr[1] = "An toàn thông tin";
            dr[2] = "12821473298";
            table.Rows.Add(dr);

            // Đọc dữ liệu từ DataTable -> hiển thị lên listView
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(table.Rows[i][0].ToString());
                item.SubItems.Add(table.Rows[i][1].ToString());
                item.SubItems.Add(table.Rows[i][2].ToString());
                lvwKhoa.Items.Add(item);
            }
        }
    }
}
