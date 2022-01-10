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

namespace BT12
{
    public partial class frmNhanVien : Form
    {

        public frmNhanVien()
        {
            InitializeComponent();

        }

        // Phương thức điền dữ liệu vào combobox
        public void FillCboBangCap()
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLThuvien; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MaBangCap, TenBangCap from BANGCAP";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                DataSet ds = new DataSet();
                // Khai báo và khởi tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // đẩy dlieu và dataset
                adapter.Fill(ds);

                // lấy dữ liệu từ dataset
                cboBangCap.DataSource = ds.Tables[0];
                cboBangCap.DisplayMember = "TenBangCap";
                cboBangCap.ValueMember = "MaBangCap";

                //7. Đóng kết nối
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDataNhanVien()
        {
            lvwNhanVien.Items.Clear();

            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLThuvien; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select nv.MaNhanVien, nv.HoTenNhanVien, nv.Ngaysinh, nv.DiaChi," +
                    "nv.DienThoai, bc.TenBangCap from dbo.NHANVIEN as nv, dbo.BANGCAP as bc where nv.MaBangCap=bc.MaBangCap";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // 5. Thực thi câu lệnh Sql
                SqlDataReader reader = null;
                reader = cmd.ExecuteReader();

                // 6. Xử lí kết quả trả về
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetSqlDateTime(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    lvwNhanVien.Items.Add(item);
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            FillCboBangCap();
            LoadDataNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            cboBangCap.Text = "";
            txtHoTen.Focus();
            LoadDataNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lvwNhanVien.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Text = lvwNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lvwNhanVien.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lvwNhanVien.SelectedItems[0].SubItems[4].Text;
                cboBangCap.Text = lvwNhanVien.SelectedItems[0].SubItems[5].Text;

                btnSua.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            cboBangCap.Text = cboBangCap.GetItemText(cboBangCap.SelectedItem);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLThuvien; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();

                if (lvwNhanVien.Items.Count == 0)
                {
                    MessageBox.Show("Không thể thực hiện thao tác khi danh sách rỗng!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lvwNhanVien.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (ListViewItem item in lvwNhanVien.Items)
                    {
                        if (item.Selected)
                        {
                            cmd.CommandText = "delete from NHANVIEN where MaNhanVien=" + item.SubItems[0].Text;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = cnn;
                        }
                    }
                }


                //cmd.CommandText = "delete from NHANVIEN where MaNhanVien=" + ;

                LoadDataNhanVien();

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhanVien();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLThuvien; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                foreach (ListViewItem item in lvwNhanVien.Items)
                {
                    if (item.Selected)
                    {
                        cmd.CommandText = "update dbo.NHANVIEN set HoTenNhanVien=N'" + txtHoTen.Text + "', NgaySinh='" +
                    Convert.ToDateTime(dtpNgaySinh.Text) + "', DiaChi=N'" + txtDiaChi.Text + "', DienThoai='" +
                    txtDienThoai.Text + "', MaBangCap='" + cboBangCap.SelectedValue + "'" + "where MaNhanVien=" + item.SubItems[0].Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cnn;
                    }
                }

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhanVien();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=QLThuvien; Integrated Security=true;";

            try
            {
                //2. Khai báo và khởi tạo đối tượng SqlConnection
                SqlConnection cnn = new SqlConnection(strCnn);

                //3. Mở kết nối
                cnn.Open();

                // 4. Khởi tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into NHANVIEN values(N'" + txtHoTen.Text + "', '" +
                    Convert.ToDateTime(dtpNgaySinh.Text) + "', N'" + txtDiaChi.Text + "', '" +
                    txtDienThoai.Text + "', '" + cboBangCap.SelectedValue + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                // 5. Thực thi câu lệnh Sql
                int records = cmd.ExecuteNonQuery();

                // 6. Xử lí kết quả trả về
                if (records > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhanVien();
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
