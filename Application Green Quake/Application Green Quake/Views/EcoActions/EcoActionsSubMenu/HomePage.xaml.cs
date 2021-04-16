using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Home;
using Application_Green_Quake.Views.EcoActions.Shopping;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        int lvl = 0;
        public HomePage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToAirOutHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirOutHome());

        }

        private async void NavigateToOutsideOnce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutsideOnce());

        }

        private async void NavigateToPlantIntoHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantIntoHome());

        }

        private async void NavigateToNonHarmfulProducts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonHarmfulProducts());

        }

        private async void NavigateToSaveFlush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToiletFlushes());

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