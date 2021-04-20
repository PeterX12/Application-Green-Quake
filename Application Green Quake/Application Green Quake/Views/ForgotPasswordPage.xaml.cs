using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        string email;
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private async void OnResetPassword(object sender, EventArgs e)
        {
            email = EmailInput.Text;
            var authService = DependencyService.Resolve<IAuth>();
            await authService.ResetPassword(email);

            await DisplayAlert("Password Reset", "Password recovery sent, check your email", "OK");

            await Navigation.PushAsync(new MainPage());
        }

    }
}