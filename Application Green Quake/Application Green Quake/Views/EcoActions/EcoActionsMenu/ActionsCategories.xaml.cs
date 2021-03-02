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
        }
        private async void NavigateToRecent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecentPage());
        }

        private async void NavigateToHabits(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HabitsPage());
        }

        private async void NavigateToFoodAndDrink(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodAndDrinkPage());
        }
        private async void NavigateToEnergy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnergyPage());
        }

        private async void NavigateToTravel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TravelPage());
        }

        private async void NavigateToShopping(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }
        private async void NavigateToWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterPage());
        }

        private async void NavigateToHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        private async void NavigateToOutdoors(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutdoorsPage());
        }
        private async void NavigateToCommunity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommunityPage());
        }
        private async void NavigateToWaste(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WastePage());
        }

        private async void NavigateToWork(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkPage());
        }

        private async void NavigateToAdvanced(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdvancedPage());
        }
    }
}