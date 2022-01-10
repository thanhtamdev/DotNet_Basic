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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        // Phương thức điền dữ liệu vào combobox
        public void FillCboKhoa()
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLDIEM; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MaKhoa, TenKhoa from khoa";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                DataSet ds = new DataSet();
                // Khai báo và khởi tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // đẩy dlieu và dataset
                adapter.Fill(ds);

                // lấy dữ liệu từ dataset
                cboKhoa.DataSource = ds.Tables[0];
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "MaKhoa";

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            FillCboKhoa();
        }
    }
}
