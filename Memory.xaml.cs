using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KalkWithOptions
{
    /// <summary>
    /// Interaction logic for Memory.xaml
    /// </summary>
    public partial class Memory : Window
    {
        public Memory()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        /* private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //first btn
            if (e.Key == Key.D1) {
                TextBlock textBlock = txt1;
                switch (textBlock.Text)
                {
                    case "jedan":
                        test = "1";
                        break;
                    case "dva":
                        test = "2";
                        break;
                    case "tri":
                        test = "3";
                        break;
                    case "četiri":
                        test = "4";
                        break;
                    case "pet":
                        test = "5";
                        break;
                    case "šest":
                        test = "6";
                        break;
                    case "sedam":
                        test = "7";
                        break;
                    case "osam":
                        test = "8";
                        break;
                    case "devet":
                        test = "9";
                        break;

                }
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Hidden;
                    lastTextBlockClicked = textBlock;
                    switch (lastTextBlockClicked.Text)
                    {
                        case "jedan":
                            lastTest = "1";
                            break;
                        case "dva":
                            lastTest = "2";
                            break;
                        case "tri":
                            lastTest = "3";
                            break;
                        case "četiri":
                            lastTest = "4";
                            break;
                        case "pet":
                            lastTest = "5";
                            break;
                        case "šest":
                            lastTest = "6";
                            break;
                        case "sedam":
                            lastTest = "7";
                            break;
                        case "osam":
                            lastTest = "8";
                            break;
                        case "devet":
                            lastTest = "9";
                            break;
                    }
                    findMatch = true;
                }
                else if (test == lastTest)
                {
                    textBlock.Visibility = Visibility.Hidden;
                    findMatch = true;

                }
                else
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;
                }
            }

            if (e.Key == Key.D2)
            {
                TextBlock textBlock = txt2;
                switch (textBlock.Text)
                {
                    case "jedan":
                        test = "1";
                        break;
                    case "dva":
                        test = "2";
                        break;
                    case "tri":
                        test = "3";
                        break;
                    case "četiri":
                        test = "4";
                        break;
                    case "pet":
                        test = "5";
                        break;
                    case "šest":
                        test = "6";
                        break;
                    case "sedam":
                        test = "7";
                        break;
                    case "osam":
                        test = "8";
                        break;
                    case "devet":
                        test = "9";
                        break;

                }
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Hidden;
                    lastTextBlockClicked = textBlock;
                    switch (lastTextBlockClicked.Text)
                    {
                        case "jedan":
                            lastTest = "1";
                            break;
                        case "dva":
                            lastTest = "2";
                            break;
                        case "tri":
                            lastTest = "3";
                            break;
                        case "četiri":
                            lastTest = "4";
                            break;
                        case "pet":
                            lastTest = "5";
                            break;
                        case "šest":
                            lastTest = "6";
                            break;
                        case "sedam":
                            lastTest = "7";
                            break;
                        case "osam":
                            lastTest = "8";
                            break;
                        case "devet":
                            lastTest = "9";
                            break;

                    }
                    findMatch = true;
                }
                else if (test == lastTest)
                {
                    textBlock.Visibility = Visibility.Hidden;
                    findMatch = true;

                }
                else
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;
                }
            }
        


            if (e.Key == Key.D3)
                {
                    TextBlock textBlock = txt3;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }

                if (e.Key == Key.D4)
                {
                    TextBlock textBlock = txt4;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
                if (e.Key == Key.D5)
                {
                    TextBlock textBlock = txt5;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
                if (e.Key == Key.D6)
                {
                    TextBlock textBlock = txt6;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
                if (e.Key == Key.D7)
                {
                    TextBlock textBlock = txt7;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
                if (e.Key == Key.D8)
                {
                    TextBlock textBlock = txt1;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
                if (e.Key == Key.D9)
                {
                    TextBlock textBlock = txt1;
                    switch (textBlock.Text)
                    {
                        case "jedan":
                            test = "1";
                            break;
                        case "dva":
                            test = "2";
                            break;
                        case "tri":
                            test = "3";
                            break;
                        case "četiri":
                            test = "4";
                            break;
                        case "pet":
                            test = "5";
                            break;
                        case "šest":
                            test = "6";
                            break;
                        case "sedam":
                            test = "7";
                            break;
                        case "osam":
                            test = "8";
                            break;
                        case "devet":
                            test = "9";
                            break;

                    }
                    if (findMatch == false)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        lastTextBlockClicked = textBlock;
                        switch (lastTextBlockClicked.Text)
                        {
                            case "jedan":
                                lastTest = "1";
                                break;
                            case "dva":
                                lastTest = "2";
                                break;
                            case "tri":
                                lastTest = "3";
                                break;
                            case "četiri":
                                lastTest = "4";
                                break;
                            case "pet":
                                lastTest = "5";
                                break;
                            case "šest":
                                lastTest = "6";
                                break;
                            case "sedam":
                                lastTest = "7";
                                break;
                            case "osam":
                                lastTest = "8";
                                break;
                            case "devet":
                                lastTest = "9";
                                break;
                        }
                        findMatch = true;
                    }
                    else if (test == lastTest)
                    {
                        textBlock.Visibility = Visibility.Hidden;
                        findMatch = true;

                    }
                    else
                    {
                        textBlock.Visibility = Visibility.Visible;
                        findMatch = false;
                    }
                }
            }
        */
     

        private void SetUpGame()
        {
            List<string> numbers = new List<string>
            {
                "jedan", "jedan",
                "dva", "dva",
                "tri", "tri",
                "četiri", "četiri",
                "pet", "pet",
                "šest", "šest",
            };

            Random random = new Random();

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(numbers.Count);
                string nextNumber = numbers[index];
                textBlock.Text = nextNumber;
                numbers.RemoveAt(index);
                textBlock.Visibility = Visibility.Hidden;
            }
        }

        TextBlock lastTextBlockClicked;
        bool findMatch = false;


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //first btn
           if (e.Key == Key.D1)
           {
                if (findMatch == false)
                {
                    txt1.Visibility = Visibility.Visible;
                    lastTextBlockClicked = txt1;
                    findMatch = true;
                }
                else if (txt1.Text == lastTextBlockClicked.Text)
                {
                    txt1.Visibility = Visibility.Visible;
                    findMatch = false;
                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                } 
            } 

            if (e.Key == Key.D2)
            { 

                if (findMatch == false)
                {
                    txt2.Visibility = Visibility.Visible;
                    lastTextBlockClicked = txt2;
                    findMatch = true;
                }
                else if (txt2.Text == lastTextBlockClicked.Text)
                {
                    txt2.Visibility = Visibility.Visible;
                    findMatch = false;
                }
                else
                {
                    txt2.Visibility = Visibility.Visible;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D3)
            {
                if (findMatch == false)
                {
                    txt3.Visibility = Visibility.Visible;
                    lastTextBlockClicked = txt3;
                    findMatch = true;
                }
                else if (txt3.Text == lastTextBlockClicked.Text)
                {
                    txt3.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D4)
            {
                TextBlock textBlock = txt4;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D5)
            {
                TextBlock textBlock = txt5;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D6)
            {
                TextBlock textBlock = txt6;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D7)
            {
                TextBlock textBlock = txt7;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D8)
            {
                TextBlock textBlock = txt8;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }
            if (e.Key == Key.D9)
            {
                TextBlock textBlock = txt9;
                if (findMatch == false)
                {
                    textBlock.Visibility = Visibility.Visible;
                    lastTextBlockClicked = textBlock;
                    findMatch = true;
                }
                else if (textBlock.Text == lastTextBlockClicked.Text)
                {
                    textBlock.Visibility = Visibility.Visible;
                    findMatch = false;

                }
                else
                {
                    lastTextBlockClicked.Visibility = Visibility.Hidden;
                    findMatch = false;
                }
            }

        }


        private void txt1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.A)
            {
                txt1.Text = "uspio";
            }
        }

        private void Image_KeyDown(object sender, KeyEventArgs e)
        {
            prva.Visibility = Visibility.Visible;
        }



        /* private void txt1_KeyDown(object sender, KeyEventArgs e)
         {
             if(e.Key == Key.D1) {
                 TextBlock textBlock = sender as TextBlock;
                 switch (textBlock.Text)
                 {
                     case "jedan":
                         test = "1";
                         break;
                     case "dva":
                         test = "2";
                         break;
                     case "tri":
                         test = "3";
                         break;
                     case "četiri":
                         test = "4";
                         break;
                     case "pet":
                         test = "5";
                         break;
                     case "šest":
                         test = "6";
                         break;
                     case "sedam":
                         test = "7";
                         break;
                     case "osam":
                         test = "8";
                         break;
                     case "devet":
                         test = "9";
                         break;

                 }
                 if (findMatch == false)
                 {
                     textBlock.Visibility = Visibility.Hidden;
                     lastTextBlockClicked = textBlock;
                     switch (lastTextBlockClicked.Text)
                     {
                         case "jedan":
                             lastTest = "1";
                             break;
                         case "dva":
                             lastTest = "2";
                             break;
                         case "tri":
                             lastTest = "3";
                             break;
                         case "četiri":
                             lastTest = "4";
                             break;
                         case "pet":
                             lastTest = "5";
                             break;
                         case "šest":
                             lastTest = "6";
                             break;
                         case "sedam":
                             lastTest = "7";
                             break;
                         case "osam":
                             lastTest = "8";
                             break;
                         case "devet":
                             lastTest = "9";
                             break;
                     }
                     findMatch = true;
                 }
                 else if (test == lastTest)
                 {
                     textBlock.Visibility = Visibility.Hidden;
                     findMatch = true;

                 }
                 else
                 {
                     textBlock.Visibility = Visibility.Visible;
                     findMatch = false;
                 }
             }
         } */

    }

    }
