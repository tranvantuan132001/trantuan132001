using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Display.Core;
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

namespace Coffe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CaffePage : Page
    {
        public CaffePage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            //var selected = new(MenuFlyoutItem)sender;
            //_roast
        }
        private void Sweetener_Click(object sender,RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweetener = selected.Text;
            DisplayResult();

        }
        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
           _cream = selected.Text;
            DisplayResult();

        }
        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            DisplayResult();

        }
        private void displayResult()
        {
            if(_roast == "none" || string.IsNullOrEmpty(_roast))
            {
                ResultTextBlock.Text = "None";
                return;

            }
            ResultTextBlock.Text = _roast;
            if (_cream != "None" && !string.IsNullOrEmpty(_cream))
                ResultTextBlock.Text += "+" + _Cream;

            if (_sweetener != "None" && !string.IsNullOrEmpty(_sweetener))
                ResultTextBlock.Text += "+" + _sweetener;
        }

    }
}
