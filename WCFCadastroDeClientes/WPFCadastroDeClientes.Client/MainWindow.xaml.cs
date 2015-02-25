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
using WPFCadastroDeClientes.Client.ServiceReference1;

namespace WPFCadastroDeClientes.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private AcessoADados dados;
        public MainWindow()
        {
            InitializeComponent();
            dados = new AcessoADados();
        }


        private void SalvarButton_Click(object sender, RoutedEventArgs e)
        {
            

            var novoCliente = new Cliente
            {
                Nome = NomeTextBox.Text,
                Sobrenome = SobrenomeTextBox.Text
            };
            dados.AdicionarCliente(novoCliente);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProgressBar.Visibility = Visibility.Visible;
            await Task.Run(() =>
            {
                var clientes = dados.ObterClientes();
                Dispatcher.Invoke(() =>
                {
                    ClientesListBox.ItemsSource = clientes;
                    ProgressBar.Visibility = Visibility.Collapsed;
                });
            });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
                if (clienteSelecionado != null)
                {
                    var resultado = MessageBox.Show("Quer apagar mesmo?", "Cuidado", MessageBoxButton.YesNo);
                    
                    
                    if (resultado ==MessageBoxResult.Yes)
                    {
                    dados.ExcluirCliente(clienteSelecionado);
                    }
                }
        }

       

        private void AtualizarButton_Click(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
            clienteSelecionado.Nome = NomeTextBox.Text;
            clienteSelecionado.Sobrenome = SobrenomeTextBox.Text;
            dados.AtualizarCliente(clienteSelecionado);
   

        }

        private void ClientesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
            NomeTextBox.Text = clienteSelecionado.Nome;
            SobrenomeTextBox.Text = clienteSelecionado.Sobrenome;
        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }





    }
}
