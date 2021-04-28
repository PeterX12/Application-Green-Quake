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