/*! \class The UseMatches View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the UseMatches View Class. This class is the eco action that the user can log.
 *
 */
using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Habits
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UseMatches : ContentPage
    {
        public UseMatches()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function creates objects and calls their methods. First the security methods are called and if they return false call the points updating
         * methods
        */
        private async void AddPointsClicked(object sender, EventArgs e)
        {
            SecurityMethods checks = new SecurityMethods();
            Task<bool> myTask = checks.DayLimitLock();
            await myTask;

            Task<bool> myTaskTwo = checks.TimeLimitLock();
            await myTaskTwo;

            if (myTask.Result)
            {
                await DisplayAlert("Daily Limit Reached", "You can only log 15 Actions per day.", "OK");
                await Navigation.PushAsync(new MainMenu());
            }
            else if (myTaskTwo.Result)
            {
                await DisplayAlert("Too soon", "You must wait 1 minute before logging the next Action.", "OK");
                await Navigation.PushAsync(new MainMenu());
            }
            else
            {
                PointsUpdate helper = new PointsUpdate();
                helper.UpdateByTwoPoints();
                HabitsPointsUpdate helper2 = new HabitsPointsUpdate();
                helper2.MatchesPoints();
                await DisplayAlert("Points Added", AppConstants.twoPointsMsg, "OK");
                await Navigation.PushAsync(new MainMenu());
            }
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