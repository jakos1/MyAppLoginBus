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
                new Buses {StartStop = 1, Stop2 = 3, Stop3 = 5, Stop4 = 7, EndStop = 10},
                new Buses {StartStop = 2, Stop2 = 4, Stop3 = 5, Stop4 = 6, EndStop = 8},
                new Buses {StartStop = 4, Stop2 = 2, Stop3 = 6, Stop4 = 7, EndStop = 9},
                new Buses {StartStop = 7, Stop2 = 2, Stop3 = 4, Stop4 = 6, EndStop = 10},
            };
        }
        public void BusSelectedProcedure(object sender, EventArgs e)
        {
            
        }
    }
}