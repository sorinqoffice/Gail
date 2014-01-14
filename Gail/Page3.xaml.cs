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
    public partial class Page3 : PhoneApplicationPage
    {
        public static string varRace = "Choose race";
        public Page3()
        {
            InitializeComponent();
            this.Loaded +=new RoutedEventHandler(Page3_Loaded);
        }

        private void Page3_Loaded ( object sender, RoutedEventArgs e )
        {
           textBlock1.Text = varRace;
        }


        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_3(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }
      

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        

    }
}