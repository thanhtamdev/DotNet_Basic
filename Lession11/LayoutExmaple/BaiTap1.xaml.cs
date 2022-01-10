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
    /// Interaction logic for BaiTap1.xaml
    /// </summary>
    public partial class BaiTap1 : Window
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if(txtFullName.Text != "")
            {
                MessageBox.Show("Xin chào " + txtFullName.Text, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
