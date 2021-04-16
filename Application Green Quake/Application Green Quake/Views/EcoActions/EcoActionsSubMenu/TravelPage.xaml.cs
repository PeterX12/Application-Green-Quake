using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Travel;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravelPage : ContentPage
    {
        int lvl = 0;
        public TravelPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToCarpool(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carpool());
        }

        private async void NavigateToPublicTransport(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicTransport());
        }

        private async void NavigateToWalk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Walk());
        }

        private async void NavigateToCycle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cycle());
        }

        private async void NavigateToEcoFreindlyCar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreindlyCar());
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