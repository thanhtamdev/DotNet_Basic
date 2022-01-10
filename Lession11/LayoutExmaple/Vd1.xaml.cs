using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LayoutExmaple
{
    /// <summary>
    /// Interaction logic for Vd1.xaml
    /// </summary>
    public partial class Vd1 : Window
    {
        public Vd1()
        {
            InitializeComponent();
            //btnLapPhuong.Click += TinhLapPhuong;    // Đăng kí sự kiện khi nhấn button tính lập phương

            // sử dụng phương thức nặc danh để sử lí sự kiện
            //btnLapPhuong.Click += delegate (object sender, RoutedEventArgs e)
            //{
            //    if (txtNumber.Text == "" || !Char.IsDigit(txtNumber.Text, 0))
            //    {
            //        MessageBox.Show("Phải nhập số.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //    else
            //    {
            //        double n = Convert.ToDouble(txtNumber.Text);

            //        txtResult.Text = (n * n * n).ToString();
            //    }
            //};

            // sử dụng biểu thức lambda
            btnLapPhuong.Click += (sender, e) =>
            {
                if (txtNumber.Text == "" || !Char.IsDigit(txtNumber.Text, 0))
                {
                    MessageBox.Show("Phải nhập số.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    double n = Convert.ToDouble(txtNumber.Text);

                    txtResult.Text = (n * n * n).ToString();
                }
            };
        }

        private void btnBinhPhuong_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "" || !Char.IsDigit(txtNumber.Text, 0))
            {
                MessageBox.Show("Phải nhập số.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                double n = Convert.ToDouble(txtNumber.Text);

                txtResult.Text = (n * n).ToString();
            }
        }

        //public void TinhLapPhuong(object sender, RoutedEventArgs e)
        //{
        //    if (txtNumber.Text == "" || !Char.IsDigit(txtNumber.Text, 0))
        //    {
        //        MessageBox.Show("Phải nhập số.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    else
        //    {
        //        double n = Convert.ToDouble(txtNumber.Text);

        //        txtResult.Text = (n * n * n).ToString();
        //    }
        //}
    }
}
