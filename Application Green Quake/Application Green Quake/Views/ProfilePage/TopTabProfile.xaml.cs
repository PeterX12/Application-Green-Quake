using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopTabProfile : ContentPage
    {
        IAuth auth;
        public TopTabProfile()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }


        protected async override void OnAppearing()
        {
            try
            {
                ProfilePic.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child(auth.GetUid())
                .Child("Profile.jpg")
                .GetDownloadUrlAsync();
            }
            catch (Exception e)
            {

            }
            try
            {
                GetData username = new GetData();
                Task<string> myTask = username.GetUsername();
                await myTask;
                Username.Text = myTask.Result;
            }
            catch (Exception e)
            {

            }
            try
            {
                GetData bio = new GetData();
                Task<string> myTask2 = bio.GetBio();
                await myTask2;
                Bio.Text = myTask2.Result;
            }
            catch (Exception e)
            {

            }
        }

        private async void ImageClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new UploadImagePopUp());
        }

        private async void NavigateToTrophyCase(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrophyCase(0));
        }

        private async void NavigateToAchievements(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrophyCase(1));
        }

        private async void NavigateToBadges(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrophyCase(2));
        }

        private async void SaveText(object sender, EventArgs e)
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            string bioInput = Bio.Text;
            string username = Username.Text;

            await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .PutAsync(new Users() {username = username ,bio = bioInput });
        }
    }
}