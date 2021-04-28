/*! \mainpage The SecurityMethods ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the SecurityMethods ViewModel Class. It performs security checks for the application whenever a log is made in the application. It
 * prevents the user from logging more than 15 actions per day and more than 1 action per 60 seconds.
 *
 */
using System;
using System.Threading.Tasks;
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class SecurityMethods
    {
        IAuth auth;
        string theDate = "";
        long theTime = 0;
        int theCount = 0;
        string currentDate = "";
        long currentTime = 0;
        private long timeDifference = 0;

        /**
         * This function gets the date and the count from the SecurityChecks Node in the database and compares the stored date to the current date. If
         * the count is 15 and the date is the same as todays date the function returns true. Otherwise False.
         * @return value return true/false
        */
        public async Task<bool> DayLimitLock()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            currentDate = DateTime.UtcNow.ToString("d");
            currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            try
            {
                theDate = (await firebaseClient
                    .Child("SecurityChecks")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<SecurityChecks>()).date;

                theCount = (await firebaseClient
                    .Child("SecurityChecks")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<SecurityChecks>()).counter;

                if (theCount == 15 && theDate == currentDate)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
        /**
         * This function gets the time from the SecurityChecks Node in the database and compares the stored time to the current time. The time difference
         * is found by subtracting the time stored in the database from the current time and if the difference is not greater than or equal to 60 seconds then the
         * function returns true otherwise it returns false.
         * @return value return true/false
        */
        public async Task<bool> TimeLimitLock()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            currentDate = DateTime.UtcNow.ToString("d");
            currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            try
            {
                theTime = (await firebaseClient
                    .Child("SecurityChecks")
                    .Child(auth.GetUid())
                    .OnceSingleAsync<SecurityChecks>()).time;

                timeDifference = currentTime - theTime;

                if (timeDifference < 60000)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
