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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage4 : Page
    {
        public BlankPage4()
        {
            this.InitializeComponent();
        }

        private void Goback1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage2));
        }

        private void TextBlock_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage5));

        }

        private void TextBlock_DoubleTapped_1(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage8));
        }

        private void TextBlock_DoubleTapped_2(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage7));
        }

        private void TextBlock_DoubleTapped_3(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage9));
        }

        private void TextBlock_DoubleTapped_4(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage42));
        }

        private void TextBlock_DoubleTapped_5(object sender, DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage43));
        }
    }
}
