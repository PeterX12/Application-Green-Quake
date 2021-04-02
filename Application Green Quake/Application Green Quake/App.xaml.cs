using Xamarin.Forms;

namespace Application_Green_Quake
{
    public partial class App : Application
    {
        IAuth auth;
        public App()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
           
            if (auth.IsSignIn())
            {
                MainPage = new NavigationPage(new Views.MainPage());
            }
            else
            {
                MainPage = new NavigationPage(new Views.MainPage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
