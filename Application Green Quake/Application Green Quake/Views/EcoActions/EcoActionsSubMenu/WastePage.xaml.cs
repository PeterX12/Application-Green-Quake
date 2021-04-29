/*! \mainpage The WastePage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WastePage View Class. This page displays and allows the navigation to each of the actions in the Waste category.
 *
 */
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
        /** This function navigates to UseRecyclingBin.
        */
        private async void NavigateToUseRecyclingBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseRecyclingBin());
        }
        /** This function navigates to SetUpRecyclingBin.
        */
        private async void NavigateToSetUpRecyclingBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetUpRecyclingBin());
        }
        /** This function navigates to CompostWaste.
        */
        private async void NavigateToSetUpCompostBin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompostWaste());
        }
        /** This function navigates to UseBiogradableBinBags.
        */
        private async void NavigateToUseBiogradableBinBags(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseBiogradableBinBags());
        }
        /** This function navigates to BillsOnline.
        */
        private async void NavigateToPayBillsOnline(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BillsOnline());
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