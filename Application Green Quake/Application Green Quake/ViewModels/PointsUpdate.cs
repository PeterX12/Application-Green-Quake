using Application_Green_Quake.Models;
using Application_Green_Quake.Views;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class PointsUpdate
    {
        int points2 = 0;
        string username = "";
        string theDate = "";
        long theTime = 0;
        int theCount = 0;
        string currentDate = "";
        long currentTime = 0;


        IAuth auth;
        public async void UpdateByTenPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            currentDate = DateTime.UtcNow.ToString("d");
            currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            try
            {
                theDate = (await firebaseClient
                .Child("SecurityChecks")
                .Child(auth.GetUid())
                .OnceSingleAsync<SecurityChecks>()).date;

                theTime = (await firebaseClient
                .Child("SecurityChecks")
                .Child(auth.GetUid())
                .OnceSingleAsync<SecurityChecks>()).time;

                theCount = (await firebaseClient
                .Child("SecurityChecks")
                .Child(auth.GetUid())
                .OnceSingleAsync<SecurityChecks>()).counter;

                if (theDate == currentDate)
                {
                    theCount++;
                }
                else
                {
                    theCount = 0;
                }

                await firebaseClient
                .Child("SecurityChecks")
                .Child(auth.GetUid())
                .PutAsync(new SecurityChecks() { date = currentDate, time = currentTime, counter = theCount });

            }
            catch (Exception)
            {
                await firebaseClient
                .Child("SecurityChecks")
                .Child(auth.GetUid())
                .PutAsync(new SecurityChecks() { date = currentDate, time = currentTime , counter = 1});
            }

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

                points2 = points2 + AppConstants.tenPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
        }

        public async void UpdateByEightPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

                points2 = points2 + AppConstants.eightPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2});
            }
        }

        public async void UpdateBySixPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

                points2 = points2 + AppConstants.sixPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2});

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
        }

        public async void UpdateByFourPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

                points2 = points2 + AppConstants.fourPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
        }

        public async void UpdateByTwoPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

                points2 = points2 + AppConstants.twoPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2 });

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { username = username, points = points2});
            }
        }
    }
}
