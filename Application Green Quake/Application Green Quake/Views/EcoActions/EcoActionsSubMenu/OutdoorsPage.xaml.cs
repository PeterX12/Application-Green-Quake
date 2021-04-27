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

        private async void NavigateToPlantATree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantATree());
        }

        private async void NavigateToPlantAFlower(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantAFlower());
        }

        private async void NavigateToPlantABush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantABush());
        }

        private async void NavigateToPicnic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Picnic());
        }

        private async void NavigateToGoCamping(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoCamping());
        }

        private async void NavigateToScoop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scoop());
        }

        private async void NavigateToSetUpHerbGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpHerbGarden());
        }

        private async void NavigateToSetUpVegetableGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpVegetableGarden());
        }

        private async void NavigateToSetUpFruitGarden(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpFruitGarden());
        }

        private async void NavigateToSetUpRainWaterColector(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RainBarrel());
        }

        private async void NavigateToSetUpBirdfeeder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpBirdfeeder());
        }

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}