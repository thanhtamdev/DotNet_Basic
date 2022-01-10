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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            //string strcnn = "Server=THINKPAD; Database=QLDIEM; User";// chứng thực theo tk server
            string strCnn = "Server=THINKPAD; Database=QLDIEM; Integrated Security=true;";

            try
            {
                // 2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // Kiểm tra kết nối thành công hay chưa
                //if (cnn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối thành công.");
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi kết nối.");
                //}

                // 4. Khai báo và khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Khoa values('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "', '" + txtDienThoai.Text + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức load dữ liệu từ bảng khoa
        public void LoadData()
        {
            lvwKhoa.Items.Clear();
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLDIEM; Integrated Security=true;";
            
            try
            {
                // 2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // Kiểm tra kết nối thành công hay chưa
                //if (cnn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối thành công.");
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi kết nối.");
                //}

                // 4. Khai báo và khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MaKhoa, TenKhoa, DienThoai from Khoa";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // 5. Thực thi câu lệnh Sql
                SqlDataReader reader = null;
                reader = cmd.ExecuteReader();

                // 6. Xử lí kết quả trả về
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    lvwKhoa.Items.Add(item);
                }

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lvwKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwKhoa.SelectedItems.Count > 0)
            {
                txtMaKhoa.Text = lvwKhoa.SelectedItems[0].SubItems[0].Text;
                txtTenKhoa.Text = lvwKhoa.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lvwKhoa.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLDIEM; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng Connection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khai báo và khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_UpdateKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                // Truyen tham so
                SqlParameter para = null;

                // @MaKhoa
                para = new SqlParameter();
                para.ParameterName = "@MaKhoa";
                para.Value = txtMaKhoa.Text;
                para.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(para);

                // @TenKhoa
                para = new SqlParameter();
                para.ParameterName = "@TenKhoa";
                para.Value = txtTenKhoa.Text;
                para.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(para);

                //@DienThoai
                para = new SqlParameter();
                para.ParameterName = "@DienThoai";
                para.Value = txtDienThoai.Text;
                para.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(para);

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
