using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.EcoActionsMenu;
using Application_Green_Quake.Views.RefillPage;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        public MainMenu(int tab)
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            CurrentPage = Children[tab];
        }

        private async void NavigateToEcoActionButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsCategories());
        }

        private async void NavigateToRefillStation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefillStation());
        }

        void SignOutButton(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                Application.Current.MainPage  = new NavigationPage(new MainPage());
            }
        }

        protected override void OnAppearing()
        {

            GetBadgeData badgeData = new GetBadgeData();
            badgeData.SetBadgeData();

            GetAchievementsData achievementsData = new GetAchievementsData();
            achievementsData.SetAchievementsData();

            GetData data = new GetData();
            data.SetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}