using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefillStationMenu : ContentPage
    {
        public RefillStationMenu()
        {
            InitializeComponent();
        }

        private async void NavigateToNearMe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NearMe());
        }

        private async void NavigateToPinOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PinOne());
        }
    }
}