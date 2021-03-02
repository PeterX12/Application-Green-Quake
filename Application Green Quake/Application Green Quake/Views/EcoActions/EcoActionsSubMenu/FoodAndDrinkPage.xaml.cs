using Application_Green_Quake.Views.EcoActions.FoodAndDrink;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodAndDrinkPage : ContentPage
    {
        int addPoints = 3;
        public FoodAndDrinkPage()
        {
            InitializeComponent();
        }

        private async void NavigateToBuyOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyOrganicFood());
        }

        private async void NavigateToWaterOverOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterOverFizzy());
        }
        
        private async void NavigateToEatAllYouMake(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EatAllYouMake());
        }

        private async void NavigateToSaveLeftovers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaveLeftOvers());
        }

        private async void NavigateToNoMeat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoMeat());
        }
        private async void NavigateToReCoffeMug(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReCoffeMug());
        }

        private async void NavigateToFoodDelivered(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodDelivered());
        }

        private async void NavigateToOwnCoffee(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OwnCoffee());
        }

        private async void NavigateToSteelStraw(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SteelStraw());
        }
    }
}