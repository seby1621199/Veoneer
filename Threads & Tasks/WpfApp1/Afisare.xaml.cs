using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Afisare.xaml
    /// </summary>
    public partial class Afisare : Window
    {
        private bool _isActive { get; set; } = false;
        public Afisare()
        {
            InitializeComponent();
        }
        private void NormalExecution()
        {
            textBlock.Text = String.Empty;

            textBlock.Text += "Start Normal\n";
            Thread.Sleep(5000);
            textBlock.Text += "End Normal\n";
        }

        private async Task AsyncExecution()
        {
            if (!_isActive)
            {
                _isActive = true;
                textBlock.Text = String.Empty;

                textBlock.Text += "Start Async \n";
                await Task.Delay(10000);
                textBlock.Text += "End Async\n";
                _isActive = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NormalExecution();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await AsyncExecution();

        }
    }
}
