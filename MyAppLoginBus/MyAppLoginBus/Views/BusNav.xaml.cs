using MyAppLoginBus.Data;
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
    public partial class BusNav : ContentPage
    {
        public BusNav()
        {
            InitializeComponent();
            List<Buses> BusList = new List<Buses>
            {
                new Buses {NameNumber = "Bus 1", StartStop = 1, Stop1 = 3, Stop2 = 5, Stop3 = 7, EndStop = 10},
                new Buses {NameNumber = "Bus 2",StartStop = 2, Stop1 = 4, Stop2 = 5, Stop3 = 6, EndStop = 8},
                new Buses {NameNumber = "Bus 3",StartStop = 4, Stop1 = 2, Stop2 = 6, Stop3 = 7, EndStop = 9},
                new Buses {NameNumber = "Bus 4",StartStop = 7, Stop1 = 2, Stop2 = 4, Stop3 = 6, EndStop = 10},
            };
            MyListView.ItemsSource = BusList;
        }
        async void MyListView_ItemsSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var bus = e.SelectedItem as Buses;
            var BusPage = new BusPage();
            BusPage.BindingContext = bus;
            
            await Navigation.PushAsync(BusPage);
        }
    }
}