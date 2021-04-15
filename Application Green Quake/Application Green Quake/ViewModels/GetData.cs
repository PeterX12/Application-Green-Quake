using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetData
    {
        public string username = "";
        public string bio = "";
        int points = 0;
        int level = 0;
        IAuth auth;
        
        public async Task<string> GetUsername()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            username = (await firebaseClient
            .Child("users")
            .Child(auth.GetUid())
            .OnceSingleAsync<Users>()).username;

            return username;

        }

        public async Task<string> GetBio()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            bio = (await firebaseClient
            .Child("users")
            .Child(auth.GetUid())
            .OnceSingleAsync<Users>()).bio;

            return bio;

        }

        public async Task<int> GetPoints()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();


            points = (await firebaseClient
                .Child("Points")
                .Child(auth.GetUid())
                .OnceSingleAsync<Points>()).points;

            return points;
        }

        public async Task<int> GetLevel()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();


            level = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).level;

            return level;
        }

    }
}
