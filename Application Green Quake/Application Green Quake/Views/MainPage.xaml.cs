/*! \class The MainPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the MainPage View Class. This is the class that allows a user to login to the application. It contains validation checks.
 *
 */
using System;
using Application_Green_Quake.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        IAuth auth;
        public static string token;
        public MainPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }
        /** This function fires when the Login button is clicked. It carries out validation checks and if all are passed the the user is logged in. If not
         * the correct error message is displayed.
        */
        async void LoginClicked(object sender, EventArgs e)
        {
            EmailErrorLabel.Text = null;
            PasswordErrorLabel.Text = null;

            if (EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                EmailErrorLabel.Text = "No Email Entered";
            }
            else if (PasswordInput.Text == null && EmailInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                PasswordErrorLabel.Text = "No Password Entered";
            }
            else if (EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                EmailErrorLabel.Text = "No Email Entered";
                PasswordErrorLabel.Text = "No Password Entered";
            }
            else
            {
                try
                {
                    token = await auth.LoginWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
                    if (token != string.Empty)
                    {
                        GetData level = new GetData();
                        level.SetLvl();
                        await Navigation.PushAsync(new LoginSplashPage());
                    }
                    else
                    {
                        EmailInput.Text = null;
                        PasswordInput.Text = null;
                        await DisplayAlert("Authentication Failed", "Email or Password are incorrect", "Ok");
                    }
                }
                catch (Exception)
                {
                    await DisplayAlert("Authentication Failed", "Please connect to the internet", "Ok");
                }
                
            }
        }
        /** This function fires when the Sign Up Text is clicked. It signs out the user if a user is signed in and redirects to the Sign Up page.
        */
        void SignUpClicked(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                Navigation.PushAsync(new SignUpPage());
            }
        }
        /** This function fires when the Forgot Password Text is clicked. It redirects to the Forgot Password page.
        */
        private async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }
    }
}