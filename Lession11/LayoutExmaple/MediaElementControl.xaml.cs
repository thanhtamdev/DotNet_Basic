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
    /// Interaction logic for MediaElementControl.xaml
    /// </summary>
    public partial class MediaElementControl : Window
    {
        public MediaElementControl()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            audioMusic.Play();
        }
    }
}
