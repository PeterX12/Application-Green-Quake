using Application_Green_Quake.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Green_Quake.ViewModels
{
    class FirebaseHelper
    {
        public async Task<List<Station>> GetAllStations()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            return (await firebaseClient
              .Child("Stations")
              .OnceAsync<Station>()).Select(item => new Station
              {
                  description = item.Object.description,
                  label = item.Object.label,
                  latitude = item.Object.latitude,
                  longitude = item.Object.longitude,

              }).ToList();                  
        }
    }
}
