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

            if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Username Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Email Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Password Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Email or Passowrd Entered", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Username or  Password", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Username or Email Entered", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Username, Email or Password Entered", "Ok");
            }
            else
            {
                try
                {
                    var user = auth.SignUpWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
                    if (user != null)
                    {
                        await DisplayAlert("Sucess", "New User Created", "OK");

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
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", "Please Connect to the Internet", "Ok");
                }
            }
        }
    }
}