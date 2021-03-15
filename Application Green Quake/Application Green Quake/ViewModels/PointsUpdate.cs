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

        IAuth auth;
        public async void UpdateByTenPoints()
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

                points2 = points2 + AppConstants.tenPoints;

                await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });

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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });

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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });

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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });

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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });
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
                .PutAsync(new Points() { points = points2, username = username });

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
                .PutAsync(new Points() { points = points2, username = username });
            }
        }
    }
}
