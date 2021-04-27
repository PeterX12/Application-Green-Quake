using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetData
    {
        IAuth auth;
        public static string username = "";
        public static string bio = "";
        public static int points = 0;
        public static int lvl = 0;
        public static string nation = "";

        public async void SetData()
        {
            try
            {
                FirebaseClient firebaseClient =
                    new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
                auth = DependencyService.Get<IAuth>();

                username = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).username;

                bio = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).bio;

                nation = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).nation;

                points = (await firebaseClient
                    .Child("Points")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Points>()).points;

                lvl = (int) Math.Floor((float) points / 10);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public async void SetLvl()
        {
            try
            {
                FirebaseClient firebaseClient =
                    new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
                auth = DependencyService.Get<IAuth>();

                points = (await firebaseClient
                    .Child("Points")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Points>()).points;

                lvl = (int) Math.Floor((float) points / 10);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
