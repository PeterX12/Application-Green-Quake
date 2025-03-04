﻿/*! \mainpage The App Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the App Class. This is the class that gets loaded first on app launch.
 *
 */
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
     
            //If the user is signed in navigate to the main menu
            if (auth.IsSignIn())
            {
                MainPage = new NavigationPage(new MainMenu());
            }
            //If the users is not signed in navigate to the login screen
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }

        protected override void OnStart()
        {
            GetData data = new GetData();
            data.SetLvl();
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
            GetData data = new GetData();
            data.SetLvl();
        }
    }
}
