using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Badges : ContentPage
    {
        IAuth auth;
        int numOfLogs = 0;
        public Badges()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }

        protected async override void OnAppearing()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            numOfLogs = (await firebaseClient
            .Child("EnergyPoints")
            .Child(auth.GetUid())
            .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

            if (numOfLogs == 4)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("testBadge.png")
                .GetDownloadUrlAsync();
            }
        }

        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }

    }
}