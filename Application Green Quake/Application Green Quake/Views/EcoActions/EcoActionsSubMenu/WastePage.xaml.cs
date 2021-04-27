using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Waste;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WastePage : ContentPage
    {
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

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}