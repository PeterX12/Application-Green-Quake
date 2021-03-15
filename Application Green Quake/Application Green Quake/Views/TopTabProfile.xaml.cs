using Application_Green_Quake.ViewModels;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
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
            GetData username = new GetData();
            Task<string> myTask = username.GetUsername();
            await myTask;
            Username.Text = myTask.Result;

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
    }
}