using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAppLoginBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusPage : ContentPage
    {
        public BusPage()
        {
            InitializeComponent();
            TimeSpan current = DateTime.Now.TimeOfDay;
            int x = 60 - Convert.ToInt32(current.Minutes.ToString());
            Lbl_Start.Text = Convert.ToString(x) + " minutes";
            x += 10;
            if (x > 60)
                {
                    x = x % 10;
                }
            Lbl_Stop1.Text = Convert.ToString(x) + " minutes";
            x += 10;
            if (x > 60)
                {
                    x = x % 10;
                }
            Lbl_Stop2.Text = Convert.ToString(x) + " minutes";
            x += 10;
            if (x > 60)
                {
                    x = x % 10;
                }
            Lbl_Stop3.Text = Convert.ToString(x) + " minutes";
            x += 10;
            if (x > 60)
                {
                    x = x % 10;
                }
            Lbl_End.Text = Convert.ToString(x) + " minutes";
        }
    }
}