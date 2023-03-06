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
    /// Interaction logic for Operatori.xaml
    /// </summary>
    public partial class Operatori : Window
    {

        int numA;
        int numB;
        int total;

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };

        string secretAnswer;
        string userChoice;
        public Operatori()
        {
            InitializeComponent();
            SetUpGame();
        }
        private void SetUpGame()
        {

            numA = rnd.Next(10, 20);
            numB = rnd.Next(0, 9);

            secretAnswer = Maths[rnd.Next(0, Maths.Length)];

            switch (secretAnswer)
            {
                case "Add":
                    total = numA + numB;
                    break;

                case "Subtract":
                    total = numA - numB;
                    break;

                case "Multiply":
                    total = numA * numB;
                    break;
            }

            Num1.Content = numA.ToString();
            Num2.Content = numB.ToString();
            Rez.Content = total.ToString();
            Symb.Content = "?";
            answerlbl.Content = "";
        }
        private void CheckAnswer()
        {

            if (userChoice == secretAnswer)
            {
                answerlbl.Content = "Bravo!";
                answerlbl.Foreground = System.Windows.Media.Brushes.Green;
            }
            else
            {
                answerlbl.Content = "Netočno, pokušaj ponovo!";
                answerlbl.Foreground = System.Windows.Media.Brushes.Red;
                Symb.Content = "?";
            }


        }


        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
             if(e.Key== Key.X) 
             {
                SetUpGame();
             }
             if (e.Key == Key.Add)
             {
                 userChoice = "Add";
                 Symb.Content = "+";
                 CheckAnswer();
             }
             if (e.Key == Key.Subtract)
             {
                 userChoice = "Subtract";
                 Symb.Content = "-";
                 CheckAnswer();
             }
             if (e.Key == Key.Multiply)
             {
                 userChoice = "Multiply";
                 Symb.Content = "x";
                 CheckAnswer();
             } 
        }
    }

}