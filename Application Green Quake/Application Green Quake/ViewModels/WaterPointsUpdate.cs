/*! \mainpage The WaterPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WaterPointsUpdate ViewModel Class. It updates the data for the Water Category of the application. The functions in this class
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
    class WaterPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int cisternCount2 = 0;
        int rainBarrel2 = 0;
        int reWater2 = 0;
        int showerBucket2 = 0;
        int wSShowerHead2 = 0;

        string username = "";

        IAuth auth;
        /** This function updates the points in the Water category by ten points. It also increments the number of logs logged in the Water
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void CisternPoints()
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).numberOfLogs;

                numberOfLogs2++;

                cisternCount2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).cisternCount;

                cisternCount2++;

                rainBarrel2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).rainBarrelCount;

                reWater2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).reWaterCount;

                showerBucket2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).showerBucketCount;

                wSShowerHead2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;

                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    cisternCount = cisternCount2,
                    rainBarrelCount = rainBarrel2,
                    reWaterCount = reWater2,
                    showerBucketCount = showerBucket2,
                    wSShowerHeadCount = wSShowerHead2,
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, cisternCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, cisternCount = 1 });
            }
        }
        /** This function updates the points in the Water category by ten points. It also increments the number of logs logged in the Water
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void BarrelPoints()
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).numberOfLogs;

                numberOfLogs2++;

                cisternCount2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).cisternCount;

                rainBarrel2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).rainBarrelCount;

                rainBarrel2++;

                reWater2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).reWaterCount;

                showerBucket2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).showerBucketCount;

                wSShowerHead2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;

                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    cisternCount = cisternCount2,
                    rainBarrelCount = rainBarrel2,
                    reWaterCount = reWater2,
                    showerBucketCount = showerBucket2,
                    wSShowerHeadCount = wSShowerHead2,
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, rainBarrelCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, rainBarrelCount = 1 });
            }
        }
        /** This function updates the points in the Water category by eight points. It also increments the number of logs logged in the Water
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void ReWaterPoints()
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).numberOfLogs;

                numberOfLogs2++;

                cisternCount2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).cisternCount;

                rainBarrel2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).rainBarrelCount;

                reWater2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).reWaterCount;

                reWater2++;

                showerBucket2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).showerBucketCount;

                wSShowerHead2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;

                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    cisternCount = cisternCount2,
                    rainBarrelCount = rainBarrel2,
                    reWaterCount = reWater2,
                    showerBucketCount = showerBucket2,
                    wSShowerHeadCount = wSShowerHead2,
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, reWaterCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, reWaterCount = 1 });
            }
        }
        /** This function updates the points in the Water category by eight points. It also increments the number of logs logged in the Water
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void ShowerBucketPoints()
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).numberOfLogs;

                numberOfLogs2++;

                cisternCount2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).cisternCount;

                rainBarrel2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).rainBarrelCount;

                reWater2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).reWaterCount;

                showerBucket2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).showerBucketCount;

                showerBucket2++;

                wSShowerHead2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;

                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    cisternCount = cisternCount2,
                    rainBarrelCount = rainBarrel2,
                    reWaterCount = reWater2,
                    showerBucketCount = showerBucket2,
                    wSShowerHeadCount = wSShowerHead2,
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, showerBucketCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, showerBucketCount = 1 });
            }
        }
        /** This function updates the points in the Water category by ten points. It also increments the number of logs logged in the Water
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void WSSowerHeadPoints()
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).numberOfLogs;

                numberOfLogs2++;

                cisternCount2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).cisternCount;

                rainBarrel2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).rainBarrelCount;

                reWater2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).reWaterCount;

                showerBucket2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).showerBucketCount;

                wSShowerHead2 = (await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;

                wSShowerHead2++;

                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    cisternCount = cisternCount2,
                    rainBarrelCount = rainBarrel2,
                    reWaterCount = reWater2,
                    showerBucketCount = showerBucket2,
                    wSShowerHeadCount = wSShowerHead2,
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
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, wSShowerHeadCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("WaterPoints")
                .Child(auth.GetUid())
                .PutAsync(new WaterPoints() { username = username, points = points2, numberOfLogs = 1, wSShowerHeadCount = 1 });
            }
        }
    }
}
