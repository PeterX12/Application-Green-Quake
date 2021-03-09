using Application_Green_Quake.Models;
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

            ProfilePic.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child(auth.GetUid())
                .Child("Profile.jpg")
                .GetDownloadUrlAsync();
        }



        private async void ImageClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new UploadImagePopUp());
        }
    }
}