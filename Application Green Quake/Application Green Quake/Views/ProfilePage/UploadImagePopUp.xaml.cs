﻿/*! \class The UploadImagePopUp View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the UploadImagePopUp View Class. This class is the popup that appears to upload a new profile picture.
 *
 */
using Plugin.Media;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Firebase.Storage;
using Plugin.Media.Abstractions;
using Rg.Plugins.Popup.Services;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadImagePopUp
    {
        IAuth auth;
        public MediaFile File { get; set; }

        public UploadImagePopUp()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }
        /** This function enables the capturing of an image.
        */
        private async void CapturePhotoClicked(object sender, System.EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", "No Camera Detected", "OK");
                return;
            }

            File = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    SaveToAlbum = true
                }
                );
            if (File == null)
                return;

            ChosenImage.Source = ImageSource.FromStream(() =>
            {
                var stream = File.GetStream();       
                return stream;
            });
        }

        /** This function enables the uploading of an image.
        */
        private async void UplaodPhotoClicked(object sender, System.EventArgs e)
        {
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
                    var imageSteram = File.GetStream();
                    return imageSteram;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /** This function enables the storing of an image.
        */
        private async void storeImageClicked(object sender, System.EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            try
            {
                {
                    await StoreImages(File.GetStream());
                }


                async Task<string> StoreImages(Stream imageStream)
                {
                    var stroageImage = await new FirebaseStorage("application-green-quake.appspot.com")
                        .Child(auth.GetUid())
                        .Child("Profile.jpg")
                        .PutAsync(imageStream);
                    string imgurl = stroageImage;
                    return imgurl;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }
            await Navigation.PushAsync(new MainMenu(2));
            await PopupNavigation.Instance.PopAsync(true);
            // Hide the loading screen
            UserDialogs.Instance.HideLoading();
        }
    }
} 