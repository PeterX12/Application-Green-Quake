using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class AdvancedPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int fixCount2 = 0;
        string username = "";
        
        IAuth auth;
        public async void FixPoints()
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
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<AdvancedPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<AdvancedPoints>()).numberOfLogs;

                numberOfLogs2++;

                fixCount2 = (await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<AdvancedPoints>()).fixCount;

                fixCount2++;

                await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .PutAsync(new AdvancedPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    fixCount = fixCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .PutAsync(new AdvancedPoints() { username = username, points = points2, numberOfLogs = 1, fixCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .PutAsync(new AdvancedPoints() { username = username, points = points2, numberOfLogs = 1, fixCount = 1 });
            }
        }
    }
}
