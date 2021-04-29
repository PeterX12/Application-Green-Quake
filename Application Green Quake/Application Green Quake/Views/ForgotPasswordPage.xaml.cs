/*! \class The ForgotPasswordPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the ForgotPasswordPage View Class. This page allows a user to request a password reset email after successful validation.
 *
 */
using System;
using System.Text.RegularExpressions;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        IAuth auth;
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        /** This function fires when the Send button is clicked. It sends a password recovery email to the email submitted if the validation checks are passed.
        */
        private async void OnResetPassword(object sender, EventArgs e)
        {
            var emailPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

            EmailErrorLabel.Text = null;
            if (EmailInput.Text == null)
            {
                EmailInput.Text = null;
                EmailErrorLabel.Text = "No Email Entered";
            }
            else if (!Regex.IsMatch(EmailInput.Text, emailPattern))
            {
                EmailInput.Text = null;
                EmailErrorLabel.Text = "Email is invalid";
            }
            else
            {
                
                try
                {
                    UserDialogs.Instance.ShowLoading("");
                    await auth.ResetPassword(EmailInput.Text);
                    await DisplayAlert("Password Reset", "If a matching account was found an email was sent to " + EmailInput.Text + " to allow you to reset your password.", "OK");
                    await Navigation.PushAsync(new MainPage());
                    //Hide the loading spinner
                    UserDialogs.Instance.HideLoading();
                }
                catch (NullReferenceException)
                {
                    await DisplayAlert("Password Reset", "Please Try again and make sure you are connected to the internet " + EmailInput.Text + " to allow you to reset your password.", "OK");
                    UserDialogs.Instance.HideLoading();
                }
            }  
        }

    }
}