using Application_Green_Quake.Table;
using Firebase.Database;
using Firebase.Database.Query;
using System;

namespace Application_Green_Quake.Reusable
{
    class PointsUpdate
    {
        int points2 = 0;
        string username = "";
        public async void UpdatePoints(int addPoints)
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            

            try
            {
                username = (await firebaseClient
                     .Child("users")
                     .Child(MainPage.token)
                     .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                     .Child("Points")
                     .Child(MainPage.token)
                     .OnceSingleAsync<Points>()).points;

                points2 = points2 + addPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username});
            }
            catch (FirebaseException)
            {
                points2 = 1;
                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2 });

            }
            catch (NullReferenceException)
            {
                points2 = 1;
                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2 });
            }
        }
    }
}
