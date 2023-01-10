using MyAppLoginBus.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAppLoginBus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void SwitchToLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        public async void SwitchToBus(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BusNav());
        }
    }
}
