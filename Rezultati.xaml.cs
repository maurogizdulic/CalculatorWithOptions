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
using System.Windows.Shapes;

namespace KalkWithOptions
{
    /// <summary>
    /// Interaction logic for Rezultati.xaml
    /// </summary>
    public partial class Rezultati : Window
    {

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public Rezultati()
        {
            InitializeComponent();
            txtAnswer.Focus();
            SetUpGame();
        }

        private void BtnExit(object sender, RoutedEventArgs e)
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


        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.X) // If Enter is pressed do math
            {

                e.Handled = true;
                try
                {
                    int userEntered = Convert.ToInt32(txtAnswer.Text);

                    if (userEntered == total)
                    {
                        incorrectlbl.Content = String.Empty;
                        correctlbl.Content = "Bravo! Točan rezultat!";
                        score += 1;
                        scorelbl.Content = "Bodovi: " + score;
                        txtAnswer.Text = String.Empty;
                        SetUpGame();
                    }
                    else
                    {
                        correctlbl.Content = String.Empty;
                        incorrectlbl.Content = "Pokušaj ponovno!";
                        txtAnswer.Clear();
                    }
                }
                catch
                {
                    txtAnswer.Clear();
                }
            }

            if (e.Key == Key.Back || e.Key == Key.W)
            {
                e.Handled = true;
                try
                {
                    string s = txtAnswer.Text;
                    if (txtAnswer.Text.Length != 0)
                    {
                        txtAnswer.Text = s.Substring(0, s.Length - 1);
                    }
                    txtAnswer.Text = s.Substring(0, s.Length - 1);
                    txtAnswer.Select(txtAnswer.Text.Length, 0);
                }
                catch
                {
                    txtAnswer.Clear();
                }
            }
        
        
    }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = String.Empty;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    Symb.Content = "+";
                    break;

                case "Subtract":
                    total = numA - numB;
                    Symb.Content = "-";
                    break;

                case "Multiply":
                    total = numA * numB;
                    Symb.Content = "x";
                    break;
            }

            Num1.Content = numA.ToString();
            Num2.Content = numB.ToString();
        }

       /* private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.X)
            {
                txtAnswer.Text = String.Empty;
            }
        }

        private void txtAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "x"))
            {
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        } */
    }
}
