using System;
using System.Linq;
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
                        await Navigation.PushAsync(new MainMenu());
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
            
        void SignUpClicked(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                Navigation.PushAsync(new SignUpPage());
            }
        }
        private async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }
    }
}