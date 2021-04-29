/*! \class The HomePage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the HomePage View Class. This page displays and allows the navigation to each of the actions in the Home category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Home;
using Application_Green_Quake.Views.EcoActions.Shopping;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to AirOutHome.
        */
        private async void NavigateToAirOutHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirOutHome());

        }
        /** This function navigates to OutsideOnce.
        */
        private async void NavigateToOutsideOnce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutsideOnce());

        }
        /** This function navigates to PlantIntoHome.
        */
        private async void NavigateToPlantIntoHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantIntoHome());

        }
        /** This function navigates to NonHarmfulProducts.
        */
        private async void NavigateToNonHarmfulProducts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonHarmfulProducts());

        }
        /** This function navigates to ToiletFlushes.
        */
        private async void NavigateToSaveFlush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToiletFlushes());

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