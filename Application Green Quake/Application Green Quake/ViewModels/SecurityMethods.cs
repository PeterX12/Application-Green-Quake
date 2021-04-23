using System;
using System.Collections.Generic;
using System.Text;
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
            catch (Exception ex)
            {
                return false;
            }
        }

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
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
