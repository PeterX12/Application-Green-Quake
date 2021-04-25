using Application_Green_Quake.ViewModels;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Application_Green_Quake.Views;
using Xamarin.Forms;

namespace Application_Green_Quake
{
    public partial class App : Application
    {
        IAuth auth;
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1OTg4QDMxMzkyZTMxMmUzME5wenFtdVBvNHBOWDVCY1o3dWYyVnVadEZ3d1JqTnNFUWYvMW53OHY5dW89");
            GetData set = new GetData();
            set.SetLvl();
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
     
            if (auth.IsSignIn())
            {
                MainPage = new NavigationPage(new MainMenu());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=87250b90-3ea3-429d-ac0b-7e47e6cd70ac;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
