/*! \class The CommunityPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the CommunityPage View Class. This page displays and allows the navigation to each of the actions in the Community category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Community;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommunityPage : ContentPage
    {
        public CommunityPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        /** This function navigates to EnvironmentalGroups.
        */
        private async void NavigateToEnvironmentalGroups(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnvironmentalGroups());
        }
        /** This function navigates to CreateEnvironmentalGroup.
        */
        private async void NavigateToCreateEnvironmentalGroup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEnvironmentalGroup());
        }
        /** This function navigates to SpreadAwareness.
        */
        private async void NavigateToSpreadAwareness(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpreadAwareness());
        }
        /** This function navigates to DoCommunity.
        */
        private async void NavigateToDoCommunity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoCommunity());
        }
        /** This function navigates to DonateItems.
        */
        private async void NavigateToDonateItems(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DonateItems());
        }
        /** This function navigates to ShareThisApp.
        */
        private async void NavigateToShareThisaApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShareThisApp());
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