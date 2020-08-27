using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace quiz_3_Vaibhav_Parsana
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    
    public sealed partial class MainPage : Page
    {
        public int guessnumber;
        
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            if ((int)btn1.Content == guessnumber)
            {
                

                btn1.Background = new SolidColorBrush(Windows.UI.Colors.Green);
                
                btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                splitView.IsPaneOpen = true;

            } 
            else
            {
                btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                if((int)btn2.Content == guessnumber)
                {
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Green);
                    
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                    
                } else
                {
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Green);
                    
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                }
   
            }
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            if ((int)btn2.Content == guessnumber)
            {
                btn2.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                splitView.IsPaneOpen = true;
            }
            else
            {
                btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                if ((int)btn1.Content == guessnumber)
                {
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                }
                else
                {
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                }

            }
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            if ((int)btn3.Content == guessnumber)
            {
                btn3.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                splitView.IsPaneOpen = true;
            }
            else
            {
                btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                if ((int)btn1.Content == guessnumber)
                {
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                }
                else
                {
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    splitView.IsPaneOpen = true;
                }

            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Random random = new Random();


            int randomnumber1 = random.Next(1, 11);

            int randomNumber2 = random.Next(1, 11);
            while(randomNumber2== randomnumber1)
            {
                randomNumber2 = random.Next(1, 11);
            }

            int randomNumber3 = random.Next(1, 11);
            while (randomNumber3 == randomnumber1 ||  randomNumber3 == randomNumber2)
            {
                randomNumber3 = random.Next(1, 11);
            }


            int[] randomArray = {randomnumber1, randomNumber2, randomNumber3};

            guessnumber = randomArray[random.Next(0, randomArray.Length - 1)];

            int i1 = random.Next(0, randomArray.Length);
            btn1.Content = randomArray[i1];
            

            for (int i = 0; i < 2; i++)
            {
                if (randomArray[i] != randomArray[i1])
                {
                    btn2.Content = randomArray[i];
                    i++;
                    if(randomArray[i] != randomArray[i1])
                    {
                        btn3.Content = randomArray[i];
                       
                    } else
                    {
                        i++;
                        btn3.Content = randomArray[i];
                    
                    }
                }
                 
            }

           

        }


        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
            btn2.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
            btn3.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);

            splitView.IsPaneOpen = false;
            Page_Loaded(sender,e);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
