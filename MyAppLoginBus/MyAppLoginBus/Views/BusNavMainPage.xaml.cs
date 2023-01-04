using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAppLoginBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusNavMainPage : ContentPage
    {
        public BusNavMainPage()
        {
            InitializeComponent();
        }
        public async void NavToBusses(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BusNav());
        }
        public async void NavToStops(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StopNav());
        }
        
    }
}