using Application_Green_Quake.EcoActions.Water;
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
    public partial class WaterPage : ContentPage
    {
        public WaterPage()
        {
            InitializeComponent();
        }

        private async void NavigateToBrushingPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrushingTeeth());
        }

        private async void NavigateToTimedShowerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimedShower());
        }

        private async void NavigateToShoweredInsteadOfBath(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowerInstead());
        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }

        private async void NavigateToReusableWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReusableWater());
        }

        private async void NavigateToTimedShowerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimedShower());
        }

        private async void NavigateToShoweredInsteadOfBath(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowerInstead());
        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }
    }
}