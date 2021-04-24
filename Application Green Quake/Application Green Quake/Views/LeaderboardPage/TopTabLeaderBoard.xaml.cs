using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using System.Linq;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.LeaderboardPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopTabLeaderBoard : ContentPage
    {
        public TopTabLeaderBoard()
        {
            InitializeComponent();
            OnAppearing();
        }


        protected  override async void OnAppearing()
        {
            UserDialogs.Instance.ShowLoading("");
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            
            var list = (await firebaseClient
                  .Child("Points")
                  .OnceAsync<Points>()).Select(item => new Points
                  {
                      username = item.Object.username,
                      points = item.Object.points,
                  }).ToList().OrderByDescending(s => s.points);

            

            var list2 = list.Select(item => new LeaderBoard
            {
                username = item.username,
                points = item.points,
            }).ToList();

            int index = 0;
            string rankIndex = "";
            foreach (var i in list2)
            {
                index++;
                rankIndex = "Rank: " + index.ToString();
                i.rank = rankIndex;
                try
                {
                    var uid = (await firebaseClient
                    .Child("usernames")
                    .Child(i.username)
                    .OnceSingleAsync<Usernames>()).Uid;

                    i.image = await new FirebaseStorage("application-green-quake.appspot.com")
                    .Child(uid)
                    .Child("Profile.jpg")
                    .GetDownloadUrlAsync();
                }
                catch (Exception e)
                {
                    i.image = ImageSource.FromResource("Application_Green_Quake.Images.user.png");
                    Console.Write(e);
                }
                try
                {
                    var uid = (await firebaseClient
                    .Child("usernames")
                    .Child(i.username)
                    .OnceSingleAsync<Usernames>()).Uid;

                    i.bio = (await firebaseClient
                    .Child("users")
                    .Child(uid)
                    .OnceSingleAsync<Users>()).bio;
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
            LeaderBoard.ItemsSource = list2;
            UserDialogs.Instance.HideLoading();
        }

        private void OnItemTapped (Object sender, ItemTappedEventArgs e)
        {
           
            var dataItem = e.Item as LeaderBoard;
            PopupNavigation.Instance.PushAsync(new LeaderBoardPopUp(dataItem.username, dataItem.points, dataItem.rank, dataItem.image, dataItem.bio));
        }
    }
}