/*! \mainpage The MainMenu View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the MainMenu View Class. This page is the main menu of the application and provides navigation to all the apps screens.
 *
 */
using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.EcoActionsMenu;
using Application_Green_Quake.Views.RefillPage;
using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : TabbedPage
    {
        IAuth auth;
        public MainMenu()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }

        /** The constructor for Main menu
        @param tab supplied to tell the class which tabbed page to display.
        */
        public MainMenu(int tab)
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            CurrentPage = Children[tab];
            OnAppearing();
        }

        /** This function navigates to ActionCategories
        */
        private async void NavigateToEcoActionButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsCategories());
        }
        /** This function navigates to RefillStation
        */
        private async void NavigateToRefillStation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefillStation());
        }

        /** This function Signs the user out and navigates to MainPage
        */
        void SignOutButton(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                Application.Current.MainPage  = new NavigationPage(new MainPage());
            }
        }
        /** This function is called before the page is displayed.
        */
        protected override async void OnAppearing()
        {
            // Wait 2 seconds to allow the data to load.
            await Task.Delay(2000);
            //Call functions to load and set data.
            GetData data = new GetData();
            data.SetLvl();
            UserDialogs.Instance.HideLoading();

            GetBadgeData badgeData = new GetBadgeData();
            badgeData.SetBadgeData();

            GetAchievementsData achievementsData = new GetAchievementsData();
            achievementsData.SetAchievementsData();

            //Set the level in the navigation bar.
            theLevel.Text = "LVL: " + GetData.lvl;

        }
    }
}