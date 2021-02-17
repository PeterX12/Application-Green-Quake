using Application_Green_Quake.Table;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        IAuth auth;
        public SignUpPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }

       async void SignUpClicked(object sender, EventArgs e)
        {
            var user = auth.SignUpWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
            if (user != null)
            {
                await DisplayAlert("Sucess", "New User Created","OK");

                var signOut = auth.SignOut();

                if (signOut)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Error", "An error has occured, please try again", "Ok");
                }

                FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                string usernameInput = UsernameInput.Text;
                string token = await user;

                await firebaseClient
                    .Child("users")
                    .Child(token)
                    .PutAsync(new Users() { username = usernameInput });

                await firebaseClient
                    .Child("usernames")
                    .Child(usernameInput)
                    .PatchAsync(new Usernames() { Uid = token });
            }
        }
    }
}