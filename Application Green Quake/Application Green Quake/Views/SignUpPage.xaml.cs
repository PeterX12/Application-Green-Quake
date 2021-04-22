using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
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

                try
                {
                    FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                    string usernameInput = UsernameInput.Text;
                    string token = await user;
                    string theBio = "";

                    await firebaseClient
                        .Child("users")
                        .Child(token)
                        .PutAsync(new Users() { username = usernameInput, bio = theBio });

                    await firebaseClient
                        .Child("usernames")
                        .Child(usernameInput)
                        .PatchAsync(new Usernames() { Uid = token });
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    await DisplayAlert("Error", "Please Connect to the Internet", "Ok");
                }
                
            }
        }
    }
}