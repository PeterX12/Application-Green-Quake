/*! \mainpage The HabitsPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the HabitsPage View Class. This page displays and allows the navigation to each of the actions in the Habits category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Habits;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HabitsPage : ContentPage
    {
        public HabitsPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function navigates to BrushingTeeth.
        */
        private async void NavigateToBrushingPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrushingTeeth());
        }
        /** This function navigates to TimedShower.
        */
        private async void NavigateToTimedShowerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimedShower());
        }
        /** This function navigates to ShowerInstead.
        */
        private async void NavigateToShoweredInsteadOfBath(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowerInstead());
        }
        /** This function navigates to DishwasherFull.
        */
        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }
        /** This function navigates to TurnOffLights.
        */
        private async void NavigateToTurnOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());

        }
        /** This function navigates to UseMatches.
        */
        private async void NavigateToUseMatches(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseMatches());
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