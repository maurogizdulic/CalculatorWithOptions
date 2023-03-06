using Microsoft.CodeAnalysis.CSharp.Scripting;
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

namespace KalkWithOptions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var firstEquation = CSharpScript.EvaluateAsync("1+1").Result;
        }

        private void BtnKalkulator(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Kalkulator win = new Kalkulator();
            win.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           System.Windows.Application.Current.Shutdown();
        }

        private void Game1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Rezultati win = new Rezultati();
            win.Show();
        }

        private void Game3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Operatori win = new Operatori();
            win.Show();
        }

        private void ExitBtn(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
