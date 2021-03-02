using Application_Green_Quake.EcoActions.Waste;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WastePage : ContentPage
    {
        public WastePage()
        {
            InitializeComponent();
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
            await Navigation.PushAsync(new SpreadAwareness());
        }

        private async void NavigateToCompostWaste(object sender, EventArgs e)
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
    }
}