using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogsControl
{
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn font
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = font.Font;
            }


        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                txtContent.ForeColor = color.Color;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại lưu tập tin
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // 2. Thiết lập luồng ghi file
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName, true, Encoding.UTF8);

                try
                {
                    // 3. Ghi file

                    streamWriter.Write(txtContent.Text);

                    MessageBox.Show("Lưu file thành công!","Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Đóng luồng ghi
                    streamWriter.Close();
                }

            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // Khai báo hộp thoại để mở tập tin
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files |.* | Text files | *.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Thiết lập luồng đọc
                StreamReader streamReader = new StreamReader(openFile.FileName);

                try
                {
                    // Đọc file
                    txtContent.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Đóng luồng đọc
                    streamReader.Close();
                }
            }
        }
    }
}
