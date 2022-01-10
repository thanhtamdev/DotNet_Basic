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

namespace NguyenThanhTam
{
    public partial class frmThongTinSach : Form
    {
        public frmThongTinSach()
        {
            InitializeComponent();
            FillCboLoaiSach();
            LoadDataSach();
        }

        // Phương thức điền dữ liệu vào combobox
        public void FillCboLoaiSach()
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLSach; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select CategoryID, CategoryName from Category";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                DataSet ds = new DataSet();
                // Khai báo và khởi tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // đẩy dlieu và dataset
                adapter.Fill(ds);

                // lấy dữ liệu từ dataset
                cboLoaiSach.DataSource = ds.Tables[0];
                cboLoaiSach.DisplayMember = "CategoryName";
                cboLoaiSach.ValueMember = "CategoryID";

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            FillCboLoaiSach();
        }

        public void LoadDataSach()
        {
            lvwTTSach.Items.Clear();

            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLSach; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select pr.ProductCode, pr.Description, pr.UnitPrice, pr.OnHandQuantity from dbo.Products as pr";
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
                    item.SubItems.Add(reader.GetInt32(2).ToString());
                    item.SubItems.Add(reader.GetInt32(3).ToString());
                    lvwTTSach.Items.Add(item);
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cboLoaiSach.Focus();
            txtMaSach.Text = "";
            txtTieuDe.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLSach; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Products values('" + txtMaSach.Text + "', N'" +
                    txtTieuDe.Text + "', '" + Convert.ToInt32(txtGia.Text) + "', '" +
                    Convert.ToInt32(txtSoLuong.Text) + "', '" + cboLoaiSach.SelectedValue + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataSach();
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
