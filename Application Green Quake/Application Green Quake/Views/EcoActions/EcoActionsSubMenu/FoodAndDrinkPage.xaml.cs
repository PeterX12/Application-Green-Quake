/*! \class The FoodAndDrinkPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the FoodAndDrinkPage View Class. This page displays and allows the navigation to each of the actions in the FoodAndDrink category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.FoodAndDrink;
using Application_Green_Quake.Views.EcoActions.Water;
using System;
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
        /** This function navigates to BuyOrganicFood.
        */
        private async void NavigateToBuyOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyOrganicFood());
        }
        /** This function navigates to WaterOverFizzy.
        */
        private async void NavigateToWaterOverFizzy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterOverFizzy());
        }
        /** This function navigates to EatAllYouMake.
        */
        private async void NavigateToEatAllYouMake(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EatAllYouMake());
        }
        /** This function navigates to SaveLeftOvers.
        */
        private async void NavigateToSaveLeftovers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaveLeftOvers());
        }
        /** This function navigates to NoMeat.
        */
        private async void NavigateToNoMeat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoMeat());
        }
        /** This function navigates to ReCoffeeMug.
        */
        private async void NavigateToReCoffeMug(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReCoffeeMug());
        }
        /** This function navigates to FoodDelivered.
        */
        private async void NavigateToFoodDelivered(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodDelivered());
        }
        /** This function navigates to OwnCoffee.
        */
        private async void NavigateToOwnCoffee(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OwnCoffee());
        }
        /** This function navigates to SteelStraw.
        */
        private async void NavigateToSteelStraw(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SteelStraw());
        }
        /** This function navigates to ReusableWater.
        */
        private async void NavigateToReusableWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReusableWater());
        }
        /** This function is called before the page is displayed and it created an object ans uses it's SetLvl method to set the players level in the app
         * and display it in the navigation bar.
        */
        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}