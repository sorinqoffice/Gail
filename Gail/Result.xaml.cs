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
    public partial class Result : PhoneApplicationPage
    {
        public Result()
        {
            InitializeComponent();
            this.Loaded +=new RoutedEventHandler(Result_Loaded);
        }

        private void Result_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}