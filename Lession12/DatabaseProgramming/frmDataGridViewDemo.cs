using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProgramming
{
    public partial class frmDataGridViewDemo : Form
    {
        //Khai báo
        SqlDataAdapter adapter = null;
        DataTable table = null;

        public frmDataGridViewDemo()
        {
            InitializeComponent();
        }

        // Phương thức load dữ liệu từ bảng khoa
        public void LoadData()
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLDIEM; Integrated Security=true;";

            try
            {
                // 2. khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                // Mở kết nối
                cnn.Open();
                //Khai báo và khởi tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MaKhoa, TenKhoa, DienThoai from Khoa";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // khởi tạo đối tượng DataAdapter và đối tượng table
                adapter = new SqlDataAdapter(cmd);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                table = new DataTable();

                // Điền dữ liệu vào DataTable
                adapter.Fill(table);
                // Gán nguồn dữ liệu cho datagridview
                dgvKhoa.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDataGridViewDemo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
            MessageBox.Show("cập nhật thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
