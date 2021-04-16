using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Shopping;
using Application_Green_Quake.Views.EcoActions.Water;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingPage : ContentPage
    {
        int lvl = 0;
        public ShoppingPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToReusableWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PurchaseReusableWater());
        }

        private async void NavigateToPurchaseReusableBag(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReusableBag());
        }

        private async void NavigateToLocalProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocalProduct());
        }

        private async void NavigateToOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrganicFood());
        }

        private async void NavigateToFoodInBulk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodInBulk());
        }
        private async void NavigateToEcoFriendlyProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFriendlyProduct());
        }

        private async void NavigateToEthicalClothes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EthicalClothes());
        }

        private async void NavigateToEcoFriendlyToothbrush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFriendlyToothbrush());
        }

        private async void NavigateToEcoFreidnlyApplicance(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreidnlyApplicance());
        }

        private async void NavigateToLooseLeafTea(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LooseLeafTea());
        }

        private async void NavigateToReBatteries(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReBatteries());
        }

        private async void NavigateToClothNapkins(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothNapkins());
        }

        private async void NavigateToClothTowels(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothTowels());
        }

        protected async override void OnAppearing()
        {
            try
            {
                GetData theLvl = new GetData();
                Task<int> myTask4 = theLvl.GetLevel();
                await myTask4;
                lvl = myTask4.Result;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            theLevel.Text = "LVL: " + lvl;
        }
    }
}