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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lap5b2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class _024 : Page
    {
        public _024()
        {
            this.InitializeComponent();

            MyFram.Navigate(typeof(Financial));
            TittleTextBlock.Text = "Financial";

            BackButton.Visibility = Visibility.Collapsed;
            Financial.IsSelected = true;
        }
        private void HumbergerButton_Click(object sender,RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = MySplitView.IsPaneOpen;

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFram.CanGoBack)
            {
                MyFram.GoBack();
                Financial.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Financial.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFram.Navigate(typeof(Financial));

            }    
            else if(Food.IsSelected){
                BackButton.Visibility = Visibility.Visible;
                MyFram.Navigate(typeof(Food));
                TittleTextBlock.Text = "Food";


            }

        }
    }
}
