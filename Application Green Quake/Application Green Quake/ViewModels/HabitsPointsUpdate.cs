using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class HabitsPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int brushingCount2 = 0;
        int fullWasherCount2 = 0;
        int showerCount2 = 0;
        int timedShowerCount2 = 0;
        int offLigtsCount2 = 0;
        int matchesCount2 = 0;

        string username = "";

        IAuth auth;
        public async void BrushingPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                brushingCount2++;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, brushingCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, brushingCount = 1 });
            }
        }

        public async void DishWasherFullPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                fullWasherCount2++;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, fullWasherCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, fullWasherCount = 1 });
            }
        }

        public async void ShowerInsteadPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                showerCount2++;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, showerCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, showerCount = 1 });
            }
        }

        public async void TimedShowerInsteadPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                timedShowerCount2++;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, timedShowerCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, timedShowerCount = 1 });
            }
        }

        public async void OffLightsPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                offLigtsCount2++;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, offLigtsCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, offLigtsCount = 1 });
            }
        }

        public async void MatchesPoints()
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
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).numberOfLogs;

                numberOfLogs2++;

                brushingCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).brushingCount;

                fullWasherCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).fullWasherCount;

                showerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).showerCount;

                timedShowerCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).timedShowerCount;

                offLigtsCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).offLigtsCount;

                matchesCount2 = (await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HabitsPoints>()).matchesCount;

                matchesCount2++;

                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    brushingCount = brushingCount2,
                    fullWasherCount = fullWasherCount2,
                    showerCount = showerCount2,
                    timedShowerCount = timedShowerCount2,
                    offLigtsCount = offLigtsCount2,
                    matchesCount = matchesCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, matchesCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HabitsPoints")
                .Child(auth.GetUid())
                .PutAsync(new HabitsPoints() { username = username, points = points2, numberOfLogs = 1, matchesCount = 1 });
            }
        }
    }
}
