/*! \class The EnergyPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the EnergyPage View Class. This page displays and allows the navigation to each of the actions in the Energy category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Energy;
using Application_Green_Quake.Views.EcoActions.Habits;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnergyPage : ContentPage
    {
        public EnergyPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to DryerFull.
       */
        private async void NavigateToDryerFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DryerFull());
        }
        /** This function navigates to MachineFull.
       */
        private async void NavigateToMachineFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MachineFull());
        }
        /** This function navigates to DishwasherFull.
       */
        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());
        }
        /** This function navigates to HangDry.
       */
        private async void NavigateToHangDry(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HangDry());

        }
        /** This function navigates to EfficientThermostat.
       */
        private async void NavigateToEfficientThermostat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EfficientThermostat());

        }
        /** This function navigates to SolarPanel.
       */
        private async void NavigateToSolarPanel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SolarPanel());
        }
        /** This function navigates to LedLightBulb.
       */
        private async void NavigateToLedLightbulb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LedLightBulb());
        }
        /** This function navigates to OffSocketSwitch.
       */
        private async void NavigateToOffSocketSwitch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffSocketSwitch());
        }
        /** This function navigates to TurnOffLights.
       */
        private async void NavigateToOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());
        }
        /** This function navigates to IsolateHome.
       */
        private async void NavigateToIsolateHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsolateHome());
        }
        /** This function navigates to MicrowaveNotOven.
       */
        private async void NavigateToMicrowaveNotOven(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MicrowaveNotOven());
        }
        /** This function navigates to ReBatteries.
       */
        private async void NavigateToReBatteries(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReBatteries());
        }
        /** This function navigates to RefrigiratorDown.
       */
        private async void NavigateToRefrigiratorDown(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefrigiratorDown());
        }
        /** This function navigates to InsulateWater.
       */
        private async void NavigateToInsulateWater(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsulateWater());
        }
        /** This function navigates to SealDrafts.
       */
        private async void NavigateToSealDrafts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SealDrafts());
        }
        /** This function navigates to SealDucts.
       */
        private async void NavigateToSealDucts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SealDucts());
        }
         /** This function is called before the page is displayed and it created an object ans uses it's SetLvl method to set the players level in the app
         * and display it in the navigation bar.
        */
        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}