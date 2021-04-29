/*! \mainpage The OutdoorsPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the OutdoorsPage View Class. This page displays and allows the navigation to each of the actions in the Outdoors category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Outdoors;
using Application_Green_Quake.Views.EcoActions.Water;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutdoorsPage : ContentPage
    {
        public OutdoorsPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to PlantATree.
        */
        private async void NavigateToPlantATree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantATree());
        }
        /** This function navigates to PlantAFlower.
        */
        private async void NavigateToPlantAFlower(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantAFlower());
        }
        /** This function navigates to PlantABush.
        */
        private async void NavigateToPlantABush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantABush());
        }
        /** This function navigates to Picnic.
        */
        private async void NavigateToPicnic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Picnic());
        }
        /** This function navigates to GoCamping.
        */
        private async void NavigateToGoCamping(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoCamping());
        }
        /** This function navigates to Scoop.
        */
        private async void NavigateToScoop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scoop());
        }
        /** This function navigates to SetUpHerbGarden.
        */
        private async void NavigateToSetUpHerbGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpHerbGarden());
        }
        /** This function navigates to SetUpVegetableGarden.
        */
        private async void NavigateToSetUpVegetableGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpVegetableGarden());
        }
        /** This function navigates to SetUpFruitGarden.
        */
        private async void NavigateToSetUpFruitGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpFruitGarden());
        }
        /** This function navigates to RainBarrel.
        */
        private async void NavigateToSetUpRainWaterColector(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RainBarrel());
        }
        /** This function navigates to UpBirdfeeder.
        */
        private async void NavigateToSetUpBirdfeeder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpBirdfeeder());
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