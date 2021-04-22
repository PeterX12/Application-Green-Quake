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
            if (EmailInput.Text == null && PasswordInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Email Entered", "Ok");
            }
            else if (PasswordInput.Text == null && EmailInput.Text != null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Password Entered", "Ok");
            }
            else if (EmailInput.Text == null && PasswordInput.Text == null)
            {
                EmailInput.Text = null;
                PasswordInput.Text = null;
                await DisplayAlert("Authentication Failed", "No Email or Password Entered", "Ok");
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
                catch (Exception ex)
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