using Application_Green_Quake.EcoActions.Energy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnergyPage : ContentPage
    {
        public EnergyPage()
        {
            InitializeComponent();
        }

        private async void NavigateToDryerFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DryerFull());
        }

        private async void NavigateToMachineFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MachineFull());
        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());
        }

        private async void NavigateToHangDry(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HangDry());

        }

        private async void NavigateToEfficientThermostat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EfficientThermostat());

        }

        private async void NavigateToSolarPanel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SolarPanel());
        }

        private async void NavigateToLedLightbulb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LedLightbulb());
        }

        private async void NavigateToOffSocketSwitch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffSocketSwitch());
        }

        private async void NavigateToOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());
        }

        private async void NavigateToIsolateHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsolateHome());
        }

        private async void NavigateToMicrowaveNotOven(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MicrowaveNotOven());
        }

        private async void NavigateToReBatteries(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReBatteries());
        }

        private async void NavigateToRefrigiratorDown(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefrigiratorDown());
        }

        private async void NavigateToInsulateWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsulateWater());
        }

        private async void NavigateToSealDrafts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SealDrafts());
        }

        private async void NavigateToSealDucts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SealDucts());
        }
    }
}