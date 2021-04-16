using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Community;
using Application_Green_Quake.Views.EcoActions.Waste;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WastePage : ContentPage
    {
        int lvl = 0;
        public WastePage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToUseRecyclingBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseRecyclingBin());
        }

        private async void NavigateToSetUpRecyclingBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpRecyclingBin());
        }

        private async void NavigateToSetUpCompostBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompostWaste());
        }

        private async void NavigateToUseBiogradableBinBags(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseBiogradableBinBags());
        }

        private async void NavigateToPayBillsOnline(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BillsOnline());
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