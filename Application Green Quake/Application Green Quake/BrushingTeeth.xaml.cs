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

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrushingTeeth : ContentPage
    {
        public BrushingTeeth()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            await firebaseClient
                .Child("User")
                .PostAsync(new User() { UserName = "Bob", Points="1" });

            await DisplayAlert("Alert", "1 Point Have been added", "OK");
        }
    }
}