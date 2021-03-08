using Application_Green_Quake.Models;
using Application_Green_Quake.Views;
using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetData
    {
        public string username = "";
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

    }
}
