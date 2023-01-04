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
            LblTest.Text = DateTime.Now.TimeOfDay.ToString();
        }
        
    }
}