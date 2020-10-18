using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();

           
        }

       

        private void GoRegister_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
           Frame.Navigate(typeof(Registration));
        
        }

        private async  void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("", "");

            var userQuery = App.user.Where(u => u.Username.Equals(textBoxUsername.Text) && u.Password.Equals(textBoxPass.Password)).FirstOrDefault();

            if (userQuery == null)
            {
                msg.Content = "Invalid Account";
                msg.Title = "Login Failed";
            }
            else
            {
                msg.Content = String.Format("Welcome {0}",userQuery.Username);
                msg.Title = "Login Successful";
            }
           await msg.ShowAsync();
        }
    }
}
