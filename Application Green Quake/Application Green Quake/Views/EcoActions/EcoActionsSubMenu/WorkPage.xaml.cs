using Application_Green_Quake.EcoActions.Travel;
using Application_Green_Quake.EcoActions.Work;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : ContentPage
    {
        public WorkPage()
        {
            InitializeComponent();
        }

        private async void NavigateToCarpool(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carpool());
        }

        private async void NavigateToPublicTransport(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicTransport());
        }

        private async void NavigateToCycle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cycle());
        }

        private async void NavigateToWalk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Walk());
        }

        private async void NavigateToEcoFreindlyCar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreindlyCar());
        }

        private async void NavigateToOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffLights());
        }

        private async void NavigateToOffElectronics(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffElectronics());
        }

        private async void NavigateToWorkingRemotely(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkingRemotely());
        }

        private async void NavigateToBothSidesPaper(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BothSidesPaper());
        }
    }
}