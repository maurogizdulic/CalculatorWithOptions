using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
            equationTextBox.Focus();
        }
        // Activate on key press
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.X) // If Enter is pressed do math
            {
                e.Handled = true;

                if (equationTextBox.Text.Contains('='))
                {
                    equationTextBox.Text = String.Empty;
                }
                else
                {

                    // Looking for operation divison and adding (double) so the final result looks like a decimal number (avoiding int result)
                    String result = equationTextBox.Text;
                    StringBuilder sb = new StringBuilder(result);
                    sb.Replace("/", "/(double)");

                    try
                    {
                        // Executing math operations and showing the result
                        var equation = CSharpScript.EvaluateAsync<double>(sb.ToString()).Result;
                        equationTextBox.Text += "=" + equation;
                        sb.Clear();
                        equationTextBox.Select(equationTextBox.Text.Length, 0); // Select cursor at the end of equation
                    }
                    catch
                    {
                        // Showing message if the input is wrong
                        MessageBox.Show("Krivo ste unijeli operatore!", "Pogreška pri unosu");
                    }
                }
            }

            if (e.Key == Key.Back || e.Key == Key.W)
            {
                e.Handled = true;

                if (equationTextBox.Text.Contains('='))
                {
                    int index = equationTextBox.Text.IndexOf('=');
                    equationTextBox.Text = equationTextBox.Text.Remove(index);
                    equationTextBox.Select(equationTextBox.Text.Length, 0);
                }
                else
                {
                    try
                    {
                        string s = equationTextBox.Text;
                        if(equationTextBox.Text.Length != 0)
                        {
                            equationTextBox.Text = s.Substring(0, s.Length - 1);
                        }
                        equationTextBox.Select(equationTextBox.Text.Length, 0);
                    }
                    catch
                    {
                        MessageBox.Show("Sve je obrisano! ", "Prazna lista");
                    }
                }
            }

        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
