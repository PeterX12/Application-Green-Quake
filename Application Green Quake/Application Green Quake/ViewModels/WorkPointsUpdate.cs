/*! \class The WorkPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WorkPointsUpdate ViewModel Class. It updates the data for the Work Category of the application. The functions in this class
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
    class WorkPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int paperCount2 = 0;
        int offElectronicsCount2 = 0;
        int remoteWorkCount2 = 0;

        string username = "";

        IAuth auth;
        /** This function updates the points in the Work category by four points. It also increments the number of logs logged in the Work
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void PaperPoints()
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).numberOfLogs;

                numberOfLogs2++;

                paperCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).paperCount;

                paperCount2++;

                offElectronicsCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).offElectronicsCount;

                remoteWorkCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).remoteWorkCount;

                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    paperCount = paperCount2,
                    offElectronicsCount = offElectronicsCount2,
                    remoteWorkCount = remoteWorkCount2,
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, paperCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, paperCount = 1 });
            }
        }
        /** This function updates the points in the Work category by six points. It also increments the number of logs logged in the Work
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void ElectonicsOffPoints()
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).numberOfLogs;

                numberOfLogs2++;

                paperCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).paperCount;

                offElectronicsCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).offElectronicsCount;

                offElectronicsCount2++;

                remoteWorkCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).remoteWorkCount;

                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    paperCount = paperCount2,
                    offElectronicsCount = offElectronicsCount2,
                    remoteWorkCount = remoteWorkCount2,
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, offElectronicsCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, offElectronicsCount = 1 });
            }
        }
        /** This function updates the points in the Work category by ten points. It also increments the number of logs logged in the Work
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void RemoteWorkPoints()
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).numberOfLogs;

                numberOfLogs2++;

                paperCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).paperCount;

                offElectronicsCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).offElectronicsCount;

                remoteWorkCount2 = (await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WorkPoints>()).remoteWorkCount;

                remoteWorkCount2++;

                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    paperCount = paperCount2,
                    offElectronicsCount = offElectronicsCount2,
                    remoteWorkCount = remoteWorkCount2,
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
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, remoteWorkCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("WorkPoints")
                .Child(auth.GetUid())
                .PutAsync(new WorkPoints() { username = username, points = points2, numberOfLogs = 1, remoteWorkCount = 1 });
            }
        }
    }
}
