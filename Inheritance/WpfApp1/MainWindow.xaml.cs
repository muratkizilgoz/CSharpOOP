using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var btn = sender as Button;
            //if (Button!=null)
            //{
            //    MessageBox.Show(btn.ActualWidth.ToString(CultureInfo.InvariantCulture));
            //}
            if (sender is Button btn)
            {
                MessageBox.Show(btn.ActualWidth.ToString(CultureInfo.InvariantCulture));
            }
            MessageBox.Show("Helü wörld");
        }
    }
}
