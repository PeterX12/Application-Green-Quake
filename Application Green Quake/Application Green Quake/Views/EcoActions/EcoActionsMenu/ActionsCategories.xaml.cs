/*! \class The ActionsCategories View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the ActionsCategories View Class. This page displays and allows the navigation to each of the 12 main categories.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionsCategories : ContentPage
    {
        public ActionsCategories()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to HabitsPage.
        */
        private async void NavigateToHabits(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HabitsPage());
        }
        /** This function navigates to FoodAndDrinkPage.
        */
        private async void NavigateToFoodAndDrink(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodAndDrinkPage());
        }
        /** This function navigates to EnergyPage.
        */
        private async void NavigateToEnergy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnergyPage());
        }
        /** This function navigates to TravelPage.
        */
        private async void NavigateToTravel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TravelPage());
        }
        /** This function navigates to ShoppingPage.
        */
        private async void NavigateToShopping(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }
        /** This function navigates to WaterPage.
        */
        private async void NavigateToWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterPage());
        }
        /** This function navigates to HomePage.
        */
        private async void NavigateToHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        /** This function navigates to OutdoorsPage.
        */
        private async void NavigateToOutdoors(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutdoorsPage());
        }
        /** This function navigates to CommunityPage.
        */
        private async void NavigateToCommunity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommunityPage());
        }
        /** This function navigates to WastePage.
        */
        private async void NavigateToWaste(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WastePage());
        }
        /** This function navigates to WorkPage.
        */
        private async void NavigateToWork(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkPage());
        }
        /** This function navigates to AdvancedPage.
        */
        private async void NavigateToAdvanced(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdvancedPage());
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