using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Text.RegularExpressions;
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
            var emailPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
            var hasNum = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSpecialChar = new Regex(@"[^\w]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Username Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Email Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Password Entered", "Ok");
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Email or Password Entered", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Username or  Password", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Username or Email Entered", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                await DisplayAlert("Sign Up Failed", "No Username, Email or Password Entered", "Ok");
            }
            else if (!Regex.IsMatch(EmailInput.Text, emailPattern))
            {
                EmailInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Email is invalid", "Ok");
            }
            else if (!hasNum.IsMatch(PasswordInput.Text))
            {
                PasswordInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Password must have at least one number", "Ok");
            }
            else if (!hasLowerChar.IsMatch(PasswordInput.Text))
            {
                PasswordInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Password must have at least one lower case character", "Ok");
            }
            else if (!hasUpperChar.IsMatch(PasswordInput.Text))
            {
                PasswordInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Password must have at least one upper case character", "Ok");
            }
            else if (!hasSpecialChar.IsMatch(PasswordInput.Text))
            {
                PasswordInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Password must have at least one special character", "Ok");
            }
            else if (!hasMinimum8Chars.IsMatch(PasswordInput.Text))
            {
                PasswordInput.Text = null;
                await DisplayAlert("Sign Up Failed", "Password must be at least 8 characters", "Ok");
            }
            else
            {
                try
                {
                    var user = auth.SignUpWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
                    if (user != null)
                    {
                        var signOut = auth.SignOut();

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

                        if (signOut)
                        {
                            await DisplayAlert("Success", "New User Created", "OK");
                            await Navigation.PushAsync(new MainPage());
                        }
                        else
                        {
                            await DisplayAlert("Error", "An error has occurred, please try again", "Ok");
                        }
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