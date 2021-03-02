using Application_Green_Quake.EcoActions.Home;
using Application_Green_Quake.EcoActions.Shopping;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void NavigateToAirOutHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirOutHome());

        }

        private async void NavigateToOutsideOnce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutsideOnce());

        }

        private async void NavigateToPlantIntoHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantIntoHome());

        }

        private async void NavigateToNonHarmfulProducts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonHarmfulProducts());

        }

        private async void NavigateToClothNapkins(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothNapkins());

        }

        private async void NavigateToClothTowels(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothTowels());

        }

    }
}