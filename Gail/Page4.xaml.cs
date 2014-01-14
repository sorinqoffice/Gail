using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Gail
{
    public partial class Page4 : PhoneApplicationPage
    {
        public static string varHyperplacia = "Hyperplacia";
        public static string varBiopsy = "Biopsy";
        public Page4()
        {
            InitializeComponent();
            this.Loaded +=new RoutedEventHandler(Page4_Loaded);
        }

        private void Page4_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = varBiopsy;
            if ((varBiopsy == "Unknown") || (varBiopsy=="No"))
            {
                textBox1.IsEnabled = false;
                slider1.IsEnabled = false;
            }

            else 
            {
                textBox1.IsEnabled = true;
                slider1.IsEnabled = true;
            }

            textBlock3.Text = varHyperplacia;
        }

       

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page5.xaml", UriKind.Relative));
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int x = Convert.ToInt32(slider1.Value);
            textBox1.Text = x.ToString();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int y = Convert.ToInt32(slider2.Value);
            textBox2.Text = y.ToString();
        }

        private void textBlock3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}