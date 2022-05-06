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

namespace EncryptDecrypt.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AppFrame_Navigated(object sender, NavigationEventArgs e)
        {
            MainNav.IsBackEnabled = AppFrame.CanGoBack;
        }

        private void MainNav_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            AppFrame.GoBack();
        }

        private void MainNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch(args.InvokedItemContainer.Tag)
            {
                case "TextEncryption":
                    {
                        AppFrame.Navigate(typeof(Pages.TextEncrypt));
                        break;
                    }
                case "FileEncryption":
                    {
                        AppFrame.Navigate(typeof(Pages.FileEncrypt));
                        break;
                    }
                case "FileDecryption":
                    {
                        AppFrame.Navigate(typeof(Pages.FileDecrypt));
                        break;
                    }
            }
        }
    }
}
