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

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registration : Page
    {
        

      //  public static  List<User> user = new List<User>();


        public Registration()
        {
            this.InitializeComponent();

           
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {


            Frame.Navigate(typeof(Login));

        }

        private async void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("");

            if (textBoxUsername.Text == "" &&
                textBoxLastname.Text == "" &&
                textBoxUsername.Text == "" &&
                textBoxPassword.Password == "" &&
                textBoxEmail.Text == "" &&
                textBoxContact.Text == "")
            {

                msg.Content = "Please complete details.";

            }
            else if (textBoxUsername.Text != "" &&
                     textBoxLastname.Text != "" &&
                     textBoxUsername.Text != "" &&
                     textBoxPassword.Password != "" &&
                     textBoxEmail.Text != "" &&
                     textBoxContact.Text != "") {
                App.user.Add(new User
                {
                    FirstName = textBoxFirstname.Text,
                    LastName = textBoxLastname.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Password,
                    Email = textBoxEmail.Text,
                    Contact = textBoxContact.Text,
                });

                msg.Content = "Registraition Successfully";
                Frame.Navigate(typeof(Login));

            }
            else { msg.Content = "Please complete details."; }



            await msg.ShowAsync();
        }

     
    }
}
