using Application_Green_Quake.Models;
using Application_Green_Quake.Views;
using Firebase.Database;
using Firebase.Database.Query;
using System;

namespace Application_Green_Quake.ViewModels
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

        public async void UpdateByTenPoints()
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

                points2 = points2 + AppConstants.tenPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username });
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

        public async void UpdateByEightPoints()
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

                points2 = points2 + AppConstants.eightPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username });
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

        public async void UpdateBySixPoints()
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

                points2 = points2 + AppConstants.sixPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username });
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

        public async void UpdateByFourPoints()
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

                points2 = points2 + AppConstants.fourPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username });
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

        public async void UpdateByTwoPoints()
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

                points2 = points2 + AppConstants.twoPoints;

                await firebaseClient
                .Child("Points")
                .Child(MainPage.token)
                .PutAsync(new Points() { points = points2, username = username });
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
