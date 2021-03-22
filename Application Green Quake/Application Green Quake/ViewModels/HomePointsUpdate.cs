using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class HomePointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int airOutCount2 = 0;
        int nonHarmCount2 = 0;
        int outsideCount2 = 0;
        int plantIntoHomeCount2 = 0;
        int toiletFlushCount2 = 0;

        string username = "";

        IAuth auth;
        public async void AirOutPoints()
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).numberOfLogs;

                numberOfLogs2++;

                airOutCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).airOutCount;

                airOutCount2++;

                nonHarmCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).nonHarmCount;

                outsideCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).outsideCount;

                plantIntoHomeCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;

                toiletFlushCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).toiletFlushCount;

                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    airOutCount = airOutCount2,
                    nonHarmCount = nonHarmCount2,
                    outsideCount = outsideCount2,
                    plantIntoHomeCount = plantIntoHomeCount2,
                    toiletFlushCount = toiletFlushCount2,
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, airOutCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, airOutCount = 1 });
            }
        }

        public async void NonHarmfulPoints()
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).numberOfLogs;

                numberOfLogs2++;

                airOutCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).airOutCount;

                nonHarmCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).nonHarmCount;

                nonHarmCount2++;

                outsideCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).outsideCount;

                plantIntoHomeCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;

                toiletFlushCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).toiletFlushCount;

                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    airOutCount = airOutCount2,
                    nonHarmCount = nonHarmCount2,
                    outsideCount = outsideCount2,
                    plantIntoHomeCount = plantIntoHomeCount2,
                    toiletFlushCount = toiletFlushCount2,
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, nonHarmCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, nonHarmCount = 1 });
            }
        }

        public async void OutsidePoints()
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).numberOfLogs;

                numberOfLogs2++;

                airOutCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).airOutCount;

                nonHarmCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).nonHarmCount;

                outsideCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).outsideCount;

                outsideCount2++;

                plantIntoHomeCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;

                toiletFlushCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).toiletFlushCount;

                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    airOutCount = airOutCount2,
                    nonHarmCount = nonHarmCount2,
                    outsideCount = outsideCount2,
                    plantIntoHomeCount = plantIntoHomeCount2,
                    toiletFlushCount = toiletFlushCount2,
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, outsideCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, outsideCount = 1 });
            }
        }

        public async void PlantsInsidePoints()
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).numberOfLogs;

                numberOfLogs2++;

                airOutCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).airOutCount;

                nonHarmCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).nonHarmCount;

                outsideCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).outsideCount;

                plantIntoHomeCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;

                plantIntoHomeCount2++;

                toiletFlushCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).toiletFlushCount;

                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    airOutCount = airOutCount2,
                    nonHarmCount = nonHarmCount2,
                    outsideCount = outsideCount2,
                    plantIntoHomeCount = plantIntoHomeCount2,
                    toiletFlushCount = toiletFlushCount2,
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, plantIntoHomeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, plantIntoHomeCount = 1 });
            }
        }

        public async void ToiletPoints()
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).numberOfLogs;

                numberOfLogs2++;

                airOutCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).airOutCount;

                nonHarmCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).nonHarmCount;

                outsideCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).outsideCount;

                plantIntoHomeCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;

                toiletFlushCount2 = (await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<HomePoints>()).toiletFlushCount;

                toiletFlushCount2++;

                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    airOutCount = airOutCount2,
                    nonHarmCount = nonHarmCount2,
                    outsideCount = outsideCount2,
                    plantIntoHomeCount = plantIntoHomeCount2,
                    toiletFlushCount = toiletFlushCount2,
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
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, toiletFlushCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("HomePoints")
                .Child(auth.GetUid())
                .PutAsync(new HomePoints() { username = username, points = points2, numberOfLogs = 1, toiletFlushCount = 1 });
            }
        }
    }
}
