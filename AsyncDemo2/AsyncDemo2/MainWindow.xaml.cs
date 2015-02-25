using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace AsyncDemo2
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

        private async void Button_Click_1(object sender, RoutedEventArgs e) // maior parte das vezes nao seja void, mas isso é um evento
        {
            destino.Text = await BaixarSiteAsync();

        }

        private async Task<string> BaixarSiteAsync()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("http://www.pazzoto.com");

            return result;
        }
    }
}
