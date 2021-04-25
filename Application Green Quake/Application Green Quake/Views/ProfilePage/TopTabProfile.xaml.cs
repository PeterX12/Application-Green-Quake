using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopTabProfile : ContentPage
    {
        IAuth auth;
        float progress = 0;
        string bioInput = "";
        float count = 0;

        public TopTabProfile()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }

        protected override async void OnAppearing()
        {
            Username.Text = GetData.username;
            try
            {
                ProfilePic.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child(auth.GetUid())
                .Child("Profile.jpg")
                .GetDownloadUrlAsync();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            progress = (float)GetData.points / 10;
            progress = (int)(((decimal)progress % 1) * 10);

            progress = progress / 10;

            count = progress;
            count = count * 10;

            theLevel.Text =  "Lvl:  " + GetData.lvl.ToString() + " Points: " + count.ToString() + " /10";
            await progressbar.ProgressTo(progress, 500, Easing.Linear);

            if (GetData.lvl == 1)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m1outlineOne.jpg");
            }
            else if (GetData.lvl == 2)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m1outlineTwo.jpg");
            }
            else if (GetData.lvl == 3)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m1outlineThree.jpg");
            }
            else if (GetData.lvl == 4)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m1outlineFour.jpg");
            }
            else if (GetData.lvl == 5)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m1.jpg");
            }
            else if (GetData.lvl == 6)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m2outlineOne.jpg");
            }
            else if (GetData.lvl == 7)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m2outlineTwo.jpg");
            }
            else if (GetData.lvl == 8)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m2outlineThree.jpg");
            }
            else if (GetData.lvl == 9)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m2outlineFour.jpg");
            }
            else if (GetData.lvl == 10)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m2.jpg");
            }
            else if (GetData.lvl == 11)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m3outlineOne.jpg");
            }
            else if (GetData.lvl == 12)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m3outlineTwo.jpg");
            }
            else if (GetData.lvl == 13)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m3outlineThree.jpg");
            }
            else if (GetData.lvl == 14)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m3outlineFour.jpg");
            }
            else if (GetData.lvl == 15)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m3.jpg");
            }
            else if (GetData.lvl == 16)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m4outlineOne.jpg");
            }
            else if (GetData.lvl == 17)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m4outlineTwo.jpg");
            }
            else if (GetData.lvl == 18)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m4outlineThree.jpg");
            }
            else if (GetData.lvl == 19)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m4outlineFour.jpg");
            }
            else if (GetData.lvl == 20)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m4.jpg");
            }
            else if (GetData.lvl == 21)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m5outlineOne.jpg");
            }
            else if (GetData.lvl == 22)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m5outlineTwo.jpg");
            }
            else if (GetData.lvl == 23)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m5outlineThree.jpg");
            }
            else if (GetData.lvl == 24)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m5outlineFour.jpg");
            }
            else if (GetData.lvl == 25)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m5.jpg");
            }
            else if (GetData.lvl == 26)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m6outlineOne.jpg");
            }
            else if (GetData.lvl == 27)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m6outlineTwo.jpg");
            }
            else if (GetData.lvl == 28)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m6outlineThree.jpg");
            }
            else if (GetData.lvl == 29)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m6outlineFour.jpg");
            }
            else if (GetData.lvl == 30)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m6.jpg");
            }
            else if (GetData.lvl == 31)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m7outlineOne.jpg");
            }
            else if (GetData.lvl == 32)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m7outlineTwo.jpg");
            }
            else if (GetData.lvl == 33)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m7outlineThree.jpg");
            }
            else if (GetData.lvl == 34)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m7outlineFour.jpg");
            }
            else if (GetData.lvl == 35)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m7.jpg");
            }
            else if (GetData.lvl == 36)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m8outlineOne.jpg");
            }
            else if (GetData.lvl == 37)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m8outlineTwo.jpg");
            }
            else if (GetData.lvl == 38)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m8outlineThree.jpg");
            }
            else if (GetData.lvl == 39)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m8outlineFour.jpg");
            }
            else if (GetData.lvl == 40)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m8.jpg");
            }
            else if (GetData.lvl == 41)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m9outlineOne.jpg");
            }
            else if (GetData.lvl == 42)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m9outlineTwo.jpg");
            }
            else if (GetData.lvl == 43)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m9outlineThree.jpg");
            }
            else if (GetData.lvl == 44)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m9outlineFour.jpg");
            }
            else if (GetData.lvl == 45)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m9.jpg");
            }
            else if (GetData.lvl == 46)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m10outlineOne.jpg");
            }
            else if (GetData.lvl == 47)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m10outlineTwo.jpg");
            }
            else if (GetData.lvl == 48)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m10outlineThree.jpg");
            }
            else if (GetData.lvl == 49)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m10outlineFour.jpg");
            }
            else if (GetData.lvl == 50)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m10.jpg");
            }
            else if (GetData.lvl == 51)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m11outlineOne.jpg");
            }
            else if (GetData.lvl == 52)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m11outlineTwo.jpg");
            }
            else if (GetData.lvl == 53)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m11outlineThree.jpg");
            }
            else if (GetData.lvl == 54)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m11outlineFour.jpg");
            }
            else if (GetData.lvl == 55)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m11.jpg");
            }
            else if (GetData.lvl == 56)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m12outlineOne.jpg");
            }
            else if (GetData.lvl == 57)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m12outlineTwo.jpg");
            }
            else if (GetData.lvl == 58)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m12outlineThree.jpg");
            }
            else if (GetData.lvl == 59)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m12outlineFour.jpg");
            }
            else if (GetData.lvl == 60)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m12.jpg");
            }
            else if (GetData.lvl == 61)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m13outlineOne.jpg");
            }
            else if (GetData.lvl == 62)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m13outlineTwo.jpg");
            }
            else if (GetData.lvl == 63)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m13outlineThree.jpg");
            }
            else if (GetData.lvl == 64)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m13outlineFour.jpg");
            }
            else if (GetData.lvl == 65)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m13.jpg");
            }
            else if (GetData.lvl == 66)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m14outlineOne.jpg");
            }
            else if (GetData.lvl == 67)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m14outlineTwo.jpg");
            }
            else if (GetData.lvl == 68)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m14outlineThree.jpg");
            }
            else if (GetData.lvl == 69)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m14outlineFour.jpg");
            }
            else if (GetData.lvl == 70)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m14.jpg");
            }
            else if (GetData.lvl == 71)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m15outlineOne.jpg");
            }
            else if (GetData.lvl == 72)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m15outlineTwo.jpg");
            }
            else if (GetData.lvl == 73)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m15outlineThree.jpg");
            }
            else if (GetData.lvl == 74)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m15outlineFour.jpg");
            }
            else if (GetData.lvl == 75)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m15.jpg");
            }
            else if (GetData.lvl == 76)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m16outlineOne.jpg");
            }
            else if (GetData.lvl == 77)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m16outlineTwo.jpg");
            }
            else if (GetData.lvl == 78)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m16outlineThree.jpg");
            }
            else if (GetData.lvl == 79)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m16outlineFour.jpg");
            }
            else if (GetData.lvl == 80)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m16.jpg");
            }
            else if (GetData.lvl == 81)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m17outlineOne.jpg");
            }
            else if (GetData.lvl == 82)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m17outlineTwo.jpg");
            }
            else if (GetData.lvl == 83)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m17outlineThree.jpg");
            }
            else if (GetData.lvl == 84)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m17outlineFour.jpg");
            }
            else if (GetData.lvl == 85)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m17.jpg");
            }
            else if (GetData.lvl == 86)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m18outlineOne.jpg");
            }
            else if (GetData.lvl == 87)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m18outlineTwo.jpg");
            }
            else if (GetData.lvl == 88)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m18outlineThree.jpg");
            }
            else if (GetData.lvl == 89)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m18outlineFour.jpg");
            }
            else if (GetData.lvl == 90)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m18.jpg");
            }
            else if (GetData.lvl == 91)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m19outlineOne.jpg");
            }
            else if (GetData.lvl == 92)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m19outlineTwo.jpg");
            }
            else if (GetData.lvl == 93)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m19outlineThree.jpg");
            }
            else if (GetData.lvl == 94)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m19outlineFour.jpg");
            }
            else if (GetData.lvl == 95)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m19.jpg");
            }
            else if (GetData.lvl == 96)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m20outlineOne.jpg");
            }
            else if (GetData.lvl == 97)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m20outlineTwo.jpg");
            }
            else if (GetData.lvl == 98)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m20outlineThree.jpg");
            }
            else if (GetData.lvl == 99)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m20outlineFour.jpg");
            }
            else if (GetData.lvl == 100)
            {
                mosiac.Source = ImageSource.FromResource("Application_Green_Quake.Images.Mosaics.m20.jpg");
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

            bioInput = Bio.Text;

            await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .PutAsync(new Users() {username = GetData.username ,bio = bioInput, nation = GetData.nation});
        }
    }
}