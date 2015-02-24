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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var texto = textBox1.Text;
            MessageBox.Show(texto);
        }

       

        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;

            button.Foreground = new SolidColorBrush(Colors.OrangeRed);
        }

        private void Button_MouseLeave_1(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.Foreground = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_LostMouseCapture_1(object sender, MouseEventArgs e)
        {
        }
    }
}
