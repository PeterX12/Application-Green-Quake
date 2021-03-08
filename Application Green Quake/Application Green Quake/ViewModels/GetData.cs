using Application_Green_Quake.Models;
using Application_Green_Quake.Views;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application_Green_Quake.ViewModels
{
    class GetData
    {
        public string username = "";
        public async Task<string> GetUsername()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            username = (await firebaseClient
            .Child("users")
            .Child(MainPage.token)
            .OnceSingleAsync<Users>()).username;

            return username;

        }

    }
}
