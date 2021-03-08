using Application_Green_Quake.ViewModels;
using Plugin.Media;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Threading.Tasks;
using Firebase.Storage;
using Plugin.Media.Abstractions;
using Rg.Plugins.Popup.Services;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadImagePopUp
    {
        public MediaFile File { get; set; }

        public UploadImagePopUp()
        {
            InitializeComponent();
        }

        private void CapturePhotoClicked(object sender, System.EventArgs e)
        {
            PhotoUtility capture = new PhotoUtility();

        }

        private async void UplaodPhotoClicked(object sender, System.EventArgs e)
        {
            PhotoUtility upload = new PhotoUtility();
            await CrossMedia.Current.Initialize();
            try
            {
                File = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                {
                    PhotoSize = PhotoSize.Medium
                });
                if (File == null)
                    return;
                ChosenImage.Source = ImageSource.FromStream(() =>
                {
                    var imageStram = File.GetStream();
                    return imageStram;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async void storeImageClicked(object sender, System.EventArgs e)
        {
            {
                await StoreImages(File.GetStream());
            }

            async Task<string> StoreImages(Stream imageStream)
            {
                var stroageImage = await new FirebaseStorage("application-green-quake.appspot.com")
                    .Child("XamarinMonkeys")
                    .Child("image.jpg")
                    .PutAsync(imageStream);
                string imgurl = stroageImage;
                return imgurl;
            }

            await PopupNavigation.Instance.PopAsync(true);
        }
    }
} 