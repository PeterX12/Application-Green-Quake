/*! \mainpage The TravelPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the TravelPointsUpdate ViewModel Class. It updates the data for the Travel Category of the application. The functions in this class
 * work by reading in all the chosen data and updating the selected fields and then sending this data to back firebase.
 *
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class TravelPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int carpoolCount2 = 0;
        int cycleCount2 = 0;
        int ecoCarCount2 = 0;
        int transportCount2 = 0;
        int walkCount2 = 0;


        string username = "";

        IAuth auth;
        /** This function updates the points in the Travel category by six points. It also increments the number of logs logged in the Travel
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void CarpoolPoints()
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).numberOfLogs;

                numberOfLogs2++;

                carpoolCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).carpoolCount;

                carpoolCount2++;

                cycleCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).cycleCount;

                ecoCarCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).ecoCarCount;

                transportCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).transportCount;

                walkCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).walkCount;

                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    carpoolCount = carpoolCount2,
                    cycleCount = cycleCount2,
                    ecoCarCount = ecoCarCount2,
                    transportCount = transportCount2,
                    walkCount = walkCount2,
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, carpoolCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, carpoolCount = 1 });
            }
        }
        /** This function updates the points in the Travel category by ten points. It also increments the number of logs logged in the Travel
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void CyclePoints()
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).numberOfLogs;

                numberOfLogs2++;

                carpoolCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).carpoolCount;

                cycleCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).cycleCount;

                cycleCount2++;

                ecoCarCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).ecoCarCount;

                transportCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).transportCount;

                walkCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).walkCount;

                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    carpoolCount = carpoolCount2,
                    cycleCount = cycleCount2,
                    ecoCarCount = ecoCarCount2,
                    transportCount = transportCount2,
                    walkCount = walkCount2,
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, cycleCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, cycleCount = 1 });
            }
        }
        /** This function updates the points in the Travel category by ten points. It also increments the number of logs logged in the Travel
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void EcoCarPoints()
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).numberOfLogs;

                numberOfLogs2++;

                carpoolCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).carpoolCount;

                cycleCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).cycleCount;

                ecoCarCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).ecoCarCount;

                ecoCarCount2++;

                transportCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).transportCount;

                walkCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).walkCount;

                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    carpoolCount = carpoolCount2,
                    cycleCount = cycleCount2,
                    ecoCarCount = ecoCarCount2,
                    transportCount = transportCount2,
                    walkCount = walkCount2,
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, ecoCarCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, ecoCarCount = 1 });
            }
        }
        /** This function updates the points in the Travel category by eight points. It also increments the number of logs logged in the Travel
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void TransportPoints()
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).numberOfLogs;

                numberOfLogs2++;

                carpoolCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).carpoolCount;

                cycleCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).cycleCount;

                ecoCarCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).ecoCarCount;

                transportCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).transportCount;

                transportCount2++;

                walkCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).walkCount;

                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    carpoolCount = carpoolCount2,
                    cycleCount = cycleCount2,
                    ecoCarCount = ecoCarCount2,
                    transportCount = transportCount2,
                    walkCount = walkCount2,
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, transportCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, transportCount = 1 });
            }
        }
        /** This function updates the points in the Travel category by ten points. It also increments the number of logs logged in the Travel
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void WalkPoints()
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).numberOfLogs;

                numberOfLogs2++;

                carpoolCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).carpoolCount;

                cycleCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).cycleCount;

                ecoCarCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).ecoCarCount;

                transportCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).transportCount;

                walkCount2 = (await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<TravelPoints>()).walkCount;

                walkCount2++;

                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    carpoolCount = carpoolCount2,
                    cycleCount = cycleCount2,
                    ecoCarCount = ecoCarCount2,
                    transportCount = transportCount2,
                    walkCount = walkCount2,
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
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, walkCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("TravelPoints")
                .Child(auth.GetUid())
                .PutAsync(new TravelPoints() { username = username, points = points2, numberOfLogs = 1, walkCount = 1 });
            }
        }
    }
}
