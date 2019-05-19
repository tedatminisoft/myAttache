using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myAttache.Portable.Views;

namespace myAttache.Portable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void login_Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void alerts_Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AlertPage());
        }

        private void clients_Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ClientPage());
        }

        private void stats_Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StatsPage());
        }
        private void settings_Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }





    }
}
