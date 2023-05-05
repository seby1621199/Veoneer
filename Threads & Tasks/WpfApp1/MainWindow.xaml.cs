using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Afisare a = new Afisare();
        public MainWindow()
        {
            InitializeComponent();
            a.textBlock.Text = String.Empty;
            a.Show();
            info.Text = "Afisarea este facuta intr-o fereastra noua deoarece WPF nu are o consola implicita si pentru a afisa in ea trebuie creata una.";
        }

        private void NormalExecution()
        {
            a.textBlock.Text = String.Empty;

            a.textBlock.Text += "Start Normal\n";
            Thread.Sleep(5000);
            a.textBlock.Text += "End Normal\n";
        }

        private async Task AsyncExecution()
        {
            a.textBlock.Text = String.Empty;

            a.textBlock.Text += "Start Async \n";
            await Task.Delay(10000);
            a.textBlock.Text += "End Async\n";
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
