/*! \mainpage The OutdoorsPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the OutdoorsPointsUpdate ViewModel Class. It updates the data for the Outdoors Category of the application. The functions in this class
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
    class OutdoorsPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int campingCount2 = 0;
        int picnicCount2 = 0;
        int plantBushCount2 = 0;
        int plantFlowerCount2 = 0;
        int plantTreeCount2 = 0;
        int scoopCount2 = 0;
        int fruitGardenCount2 = 0;
        int herbGardenCount2 = 0;
        int vegetableGardenCount2 = 0;
        int birdFeederCount2 = 0;

        string username = "";

        IAuth auth;
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void CampingPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                campingCount2++;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantBushCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, campingCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, campingCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by six points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void PicnicPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                picnicCount2++;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantBushCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, picnicCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, picnicCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by eight points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void PlantBushPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantBushCount2++;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantBushCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantBushCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void PlantTreePoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                plantTreeCount2++;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantTreeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantTreeCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by eight points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void PlantFlowerPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantFlowerCount2++;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantTreeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, plantTreeCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by four points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void ScoopPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                scoopCount2++;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, scoopCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, scoopCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void FruitGardenPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                fruitGardenCount2++;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, fruitGardenCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, fruitGardenCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void HerbGardenPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                herbGardenCount2++;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, herbGardenCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, herbGardenCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void VegetableGardenPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                vegetableGardenCount2++;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, vegetableGardenCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, vegetableGardenCount = 1 });
            }
        }
        /** This function updates the points in the Outdoors category by ten points. It also increments the number of logs logged in the Outdoors
        * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase.
        */
        public async void BirdFeederPoints()
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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;

                numberOfLogs2++;

                campingCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).campingCount;

                picnicCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).picnicCount;

                plantBushCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;

                plantFlowerCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;

                plantTreeCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;

                scoopCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).scoopCount;

                fruitGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;

                herbGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;

                vegetableGardenCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;

                birdFeederCount2 = (await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;

                birdFeederCount2++;

                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    campingCount = campingCount2,
                    picnicCount = picnicCount2,
                    plantBushCount = plantBushCount2,
                    plantFlowerCount = plantFlowerCount2,
                    plantTreeCount = plantTreeCount2,
                    scoopCount = scoopCount2,
                    fruitGardenCount = fruitGardenCount2,
                    herbGardenCount = herbGardenCount2,
                    vegetableGardenCount = vegetableGardenCount2,
                    birdFeederCount = birdFeederCount2,

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
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, birdFeederCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("OutdoorsPoints")
                .Child(auth.GetUid())
                .PutAsync(new OutdoorsPoints() { username = username, points = points2, numberOfLogs = 1, birdFeederCount = 1 });
            }
        }
    }
}
