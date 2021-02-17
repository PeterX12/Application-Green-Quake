using Application_Green_Quake.Table;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Reusable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopTabLeaderBoard : ContentPage
    {
        IAuth auth;
        public TopTabLeaderBoard()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }


        protected async override void OnAppearing()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            name.Text = auth.GetUid();

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