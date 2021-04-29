/*! \mainpage The WorkPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WorkPage View Class. This page displays and allows the navigation to each of the actions in the Work category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Habits;
using Application_Green_Quake.Views.EcoActions.Travel;
using Application_Green_Quake.Views.EcoActions.Work;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : ContentPage
    {
        public WorkPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to Carpool.
        */
        private async void NavigateToCarpool(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carpool());
        }
        /** This function navigates to PublicTransport.
        */
        private async void NavigateToPublicTransport(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicTransport());
        }
        /** This function navigates to Cycle.
        */
        private async void NavigateToCycle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cycle());
        }
        /** This function navigates to Walk.
        */
        private async void NavigateToWalk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Walk());
        }
        /** This function navigates to EcoFreindlyCar.
        */
        private async void NavigateToEcoFreindlyCar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreindlyCar());
        }
        /** This function navigates to TurnOffLights.
        */
        private async void NavigateToOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());
        }
        /** This function navigates to OffElectronics.
        */
        private async void NavigateToOffElectronics(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffElectronics());
        }
        /** This function navigates to WorkingRemotely.
        */
        private async void NavigateToWorkingRemotely(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkingRemotely());
        }
        /** This function navigates to BothSidesPaper.
        */
        private async void NavigateToBothSidesPaper(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BothSidesPaper());
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