using System;
using System.Collections.Generic;

using Xamarin.Forms;

using myAttache.Portable.Services;

namespace myAttache.Portable.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(activationCodeEntry.Text))
            {
                activationCodeEntry.Text = "ACtivateme";
                userNameEntry.Text = "MasterUser";
                passwordEntry.Text = "HGRBypass_10";

            }
            IsBusy = true;
            var userService = new UserService();
            var activeUser = userService.Login(activationCodeEntry.Text, userNameEntry.Text, passwordEntry.Text);

            if (activeUser != null)
                await Navigation.PopAsync();
               // App.Current.MainPage = new MainPage();
            else
                await App.Current.MainPage.DisplayAlert("Login", "Error Logging In", "OK");
        }
    }
}

