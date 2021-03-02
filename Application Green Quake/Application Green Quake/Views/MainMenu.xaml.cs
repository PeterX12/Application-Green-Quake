using Application_Green_Quake.Views;
using Application_Green_Quake.Views.EcoActions.EcoActionsMenu;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : TabbedPage
    {
        IAuth auth;
        public MainMenu()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }

        private async void NavigateToEcoActionButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsCategories());
        }

        private async void NavigateToRefillStation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefillStation());
        }

        private async void NavigateToFoodInventory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodInventoryMenu());
        }
        private async void NavigateToDatabaseTest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodInventoryMenu());
        }

        async void SignOutButton(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}