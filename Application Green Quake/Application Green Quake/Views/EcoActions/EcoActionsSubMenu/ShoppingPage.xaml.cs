/*! \class The ShoppingPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the ShoppingPage View Class. This page displays and allows the navigation to each of the actions in the Shopping category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Shopping;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingPage : ContentPage
    {
        public ShoppingPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to PurchaseReusableWater.
        */
        private async void NavigateToReusableWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PurchaseReusableWater());
        }
        /** This function navigates to ReusableBag.
        */
        private async void NavigateToPurchaseReusableBag(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReusableBag());
        }
        /** This function navigates to LocalProduct.
        */
        private async void NavigateToLocalProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocalProduct());
        }
        /** This function navigates to OrganicFood.
        */
        private async void NavigateToOrganicFood(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrganicFood());
        }
        /** This function navigates to FoodInBulk.
        */
        private async void NavigateToFoodInBulk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodInBulk());
        }
        /** This function navigates to EcoFriendlyProduct.
        */
        private async void NavigateToEcoFriendlyProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFriendlyProduct());
        }
        /** This function navigates to EthicalClothes.
        */
        private async void NavigateToEthicalClothes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EthicalClothes());
        }
        /** This function navigates to EcoFriendlyToothbrush.
        */
        private async void NavigateToEcoFriendlyToothbrush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFriendlyToothbrush());
        }
        /** This function navigates to EcoFreidnlyApplicance.
        */
        private async void NavigateToEcoFreidnlyApplicance(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreidnlyApplicance());
        }
        /** This function navigates to LooseLeafTea.
        */
        private async void NavigateToLooseLeafTea(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LooseLeafTea());
        }
        /** This function navigates to ReBatteries.
        */
        private async void NavigateToReBatteries(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReBatteries());
        }
        /** This function navigates to ClothNapkins.
        */
        private async void NavigateToClothNapkins(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothNapkins());
        }
        /** This function navigates to ClothTowels.
        */
        private async void NavigateToClothTowels(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClothTowels());
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