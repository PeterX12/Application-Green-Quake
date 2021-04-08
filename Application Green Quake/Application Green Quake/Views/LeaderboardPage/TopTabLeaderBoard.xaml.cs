using Application_Green_Quake.Models;
using Firebase.Database;
using Rg.Plugins.Popup.Services;
using System;
using System.Linq;

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


        protected async override void OnAppearing()
        {
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

            foreach (var i in list2)
            {
                index++;
                i.rank = index;
            }

            LeaderBoard.ItemsSource = list2;
        }

        private void OnItemTapped (Object sender, ItemTappedEventArgs e)
        {
           
            var dataItem = e.Item as LeaderBoard;

            PopupNavigation.Instance.PushAsync(new LeaderBoardPopUp(dataItem.username));
        }
    }
}