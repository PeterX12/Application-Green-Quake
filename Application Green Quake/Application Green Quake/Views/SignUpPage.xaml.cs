/*! \mainpage The SignUpPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the SignUpPage View Class. This is the class that allows a user to sign up for the application. It contains validation checks.
 *
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Acr.UserDialogs;
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
        /** This function fires when the Sign Up button is clicked. It carries out validation checks and if all are passed the the new user is created. If not
        * the correct error message is displayed. 
        */
        async void SignUpClicked(object sender, EventArgs e)
        {
            var emailPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
            var hasNum = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSpecialChar = new Regex(@"[^\w]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            UsernameErrorLabel.Text = null;
            EmailErrorLabel.Text = null;
            PasswordErrorLabel.Text = null;

            if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text != null)
            {
                
                UsernameInput.Text = null;
                UsernameErrorLabel.Text = "No Username Entered";
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                EmailErrorLabel.Text = "No Email Entered";
            }
            else if (UsernameInput.Text != null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                
                PasswordInput.Text = null;
                PasswordErrorLabel.TextColor = Color.Red;
                PasswordErrorLabel.Text = "No Password Entered";
            }
            else if (UsernameInput.Text != null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                PasswordErrorLabel.TextColor = Color.Red;
                PasswordErrorLabel.Text = "No Password Entered";
                EmailErrorLabel.Text = "No Email Entered";
            }
            else if (UsernameInput.Text == null && EmailInput.Text != null && PasswordInput.Text == null)
            {
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                PasswordErrorLabel.TextColor = Color.Red;
                UsernameErrorLabel.Text = "No Username Entered";
                PasswordErrorLabel.Text = "No Password Entered";
                    await DisplayAlert("Sign Up Failed", "No Username or  Password", "Ok");
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                
                UsernameInput.Text = null;
                UsernameErrorLabel.Text = "No Username Entered";
                EmailErrorLabel.Text = "No Email Entered";
            }
            else if (UsernameInput.Text == null && EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                UsernameInput.Text = null;
                PasswordErrorLabel.TextColor = Color.Red;
                EmailErrorLabel.Text = "No Email Entered";
                PasswordErrorLabel.Text = "No Password Entered";
                UsernameErrorLabel.Text = "No Username Entered";
            }

            if (UsernameInput.Text != null && EmailInput.Text != null && PasswordInput.Text != null)
            {
                if (!Regex.IsMatch(EmailInput.Text, emailPattern))
                {
                    EmailInput.Text = null;
                    EmailErrorLabel.Text = "Email is invalid";
                }
                if (!hasNum.IsMatch(PasswordInput.Text))
                {
                    PasswordInput.Text = null;
                    PasswordErrorLabel.TextColor = Color.Red;
                    PasswordErrorLabel.Text = "Password must have at least one number";
                }
                else if (!hasLowerChar.IsMatch(PasswordInput.Text))
                {
                    PasswordInput.Text = null;
                    PasswordErrorLabel.TextColor = Color.Red;
                    PasswordErrorLabel.Text = "Password must have at least one lower case character";
                }
                else if (!hasUpperChar.IsMatch(PasswordInput.Text))
                {
                    PasswordInput.Text = null;
                    PasswordErrorLabel.TextColor = Color.Red;
                    PasswordErrorLabel.Text = "Password must have at least one upper case character";
                }
                else if (!hasSpecialChar.IsMatch(PasswordInput.Text))
                {
                    PasswordInput.Text = null;
                    PasswordErrorLabel.TextColor = Color.Red;
                    PasswordErrorLabel.Text = "Password must have at least one special character";
                }
                else if (!hasMinimum8Chars.IsMatch(PasswordInput.Text))
                {
                    PasswordInput.Text = null;
                    PasswordErrorLabel.TextColor = Color.Red;
                    PasswordErrorLabel.Text = "Password must be at least 8 characters";
                }
                else if (EmailErrorLabel.Text == null && PasswordErrorLabel.Text == null && UsernameErrorLabel.Text == null)
                {
                   
                    var user = auth.SignUpWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
                    if (user != null)
                    {
                        var signOut = auth.SignOut();

                        FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                        string usernameInput = UsernameInput.Text;
                        string token = await user;
                        string theBio = "";
                        string theNation = RegionInfo.CurrentRegion.EnglishName;

                        if (token != "duplicate")
                        {
                            UserDialogs.Instance.ShowLoading("");

                            await firebaseClient
                                .Child("users")
                                .Child(token)
                                .PutAsync(new Users() { username = usernameInput, bio = theBio, nation = theNation});

                            await firebaseClient
                                .Child("usernames")
                                .Child(usernameInput)
                                .PutAsync(new Usernames() { Uid = token });

                            if (signOut)
                            {
                                UserDialogs.Instance.HideLoading();
                                await DisplayAlert("Success", "New User Created", "OK");
                                await Navigation.PushAsync(new MainPage());
                            }
                            else
                            {
                                await DisplayAlert("Error", "An error has occurred, please try again", "Ok");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", "The email already exists, please try again.", "Ok");
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "Please connect to the internet.", "Ok");
                    }
                }
            }
        }
    }
}