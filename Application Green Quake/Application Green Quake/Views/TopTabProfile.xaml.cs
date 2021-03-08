using Application_Green_Quake.ViewModels;
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
        public TopTabProfile()
        {
            InitializeComponent();
            OnAppearing();
        }

        protected async override void OnAppearing()
        {
            GetData username = new GetData();
            Task<string> myTask = username.GetUsername();
            await myTask;
            Username.Text = myTask.Result;
        }

        private async void ImageClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new UploadImagePopUp());
        }
    }
}