using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.EcoActionsMenu;
using Application_Green_Quake.Views.RefillPage;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Media.Audiofx.BassBoost;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : TabbedPage
    {
        IAuth auth;
        int lvl = 0;

        public MainPage MainPage { get; private set; }

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

        protected async override void OnAppearing()
        {
            try
            {
                GetData theLvl = new GetData();
                Task<int> myTask4 = theLvl.GetLevel();
                await myTask4;
                lvl = myTask4.Result;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            theLevel.Text = "LVL: " + lvl;
        }
    }
}