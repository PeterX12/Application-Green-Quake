using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.FoodAndDrink;
using Application_Green_Quake.Views.EcoActions.Water;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodAndDrinkPage : ContentPage
    {
        public FoodAndDrinkPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToBuyOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyOrganicFood());
        }

        private async void NavigateToWaterOverFizzy(object sender, EventArgs e)
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
            await Navigation.PushAsync(new ReCoffeeMug());
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

        private async void NavigateToReusableWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReusableWater());
        }

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}