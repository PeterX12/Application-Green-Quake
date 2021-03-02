using Application_Green_Quake.EcoActions.Outdoors;
using Application_Green_Quake.EcoActions.AdvancedPage;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedPage : ContentPage
    {
        public AdvancedPage()
        {
            InitializeComponent();
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

        private async void NavigateToFixInsteadOfThrowAway(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FixInsteadOfThrowAway());

        }
    }
}