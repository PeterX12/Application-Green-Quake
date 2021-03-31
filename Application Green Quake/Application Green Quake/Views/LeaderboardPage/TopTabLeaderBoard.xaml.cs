using Application_Green_Quake.Models;
using Firebase.Database;
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

            lstPersons.ItemsSource = (await firebaseClient
                  .Child("Points")
                  .OnceAsync<Points>()).Select(item => new Points
                  {
                      username = item.Object.username,
                      points = item.Object.points,
                  }).ToList().OrderByDescending(s => s.points);
        }
    }
}