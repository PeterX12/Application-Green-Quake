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
            token = await auth.LoginWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
            if (token != string.Empty)
            {
                await Navigation.PushAsync(new MainMenu());
                
            }
            else
            {
               await DisplayAlert("Authentication Failed", "Email or Password are incorrect", "Ok");
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