using Application_Green_Quake.EcoActions.Outdoors;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutdoorsPage : ContentPage
    {
        public OutdoorsPage()
        {
            InitializeComponent();
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
            await Navigation.PushAsync(new GoCamping());

        }

        private async void NavigateToSetUpBirdfeeder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpBirdfeeder());

        }
    }
}