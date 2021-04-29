/*! \mainpage The AdvancedPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the AdvancedPage View Class. This page displays and allows the navigation to each of the actions in the Advanced category.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.AdvancedPageItems;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedPage : ContentPage
    {
        public AdvancedPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        /** This function navigates to FixInsteadOfThrowAway.
        */
        private async void NavigateToFix(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FixInsteadOfThrowAway());
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