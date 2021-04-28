/*! \mainpage The GetData ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the GetData ViewModel Class. It gets data that is needed for the applications back end and front end.
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetData
    {
        IAuth auth;
        public static string username = "";
        public static string bio = "";
        public static int points = 0;
        public static int lvl = 0;
        public static string nation = "";

        /**
         * This function sets the data to be used for the font end in this application. It sets the username, bio, points, nation and lvl for the logged in
         * user. These are saved in global public variables that are used across the application for front end.
        */
        public async void SetData()
        {
            try
            {
                FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
                auth = DependencyService.Get<IAuth>();

                username = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).username;

                bio = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).bio;

                nation = (await firebaseClient
                    .Child("users")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Users>()).nation;

                points = (await firebaseClient
                    .Child("Points")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Points>()).points;

                lvl = (int) Math.Floor((float) points / 10);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
        /**
         * This function just sets the level of the user in a global static varaible shared across all the classes to be displayed for the front end.
        */
        public async void SetLvl()
        {
            try
            {
                FirebaseClient firebaseClient =
                    new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
                auth = DependencyService.Get<IAuth>();

                points = (await firebaseClient
                    .Child("Points")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<Points>()).points;

                lvl = (int) Math.Floor((float) points / 10);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
