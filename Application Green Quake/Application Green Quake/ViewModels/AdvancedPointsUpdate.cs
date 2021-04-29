/*! \class The AdvancedPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the AdvancedPointsUpdate ViewModel Class. It updates the data for the Advanced Category of the application. The functions in this class
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
    class AdvancedPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int fixCount2 = 0;
        string username = "";
        
        IAuth auth;
        /** This function updates the points in the Advanced category by ten points. It also increments the number of logs logged in the Advanced
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
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
