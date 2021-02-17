using Application_Green_Quake.Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
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
        async void SignUpClicked(object sender, EventArgs e)
        {
            var signOut = auth.SignOut();

            if (signOut)
            {
                await Navigation.PushAsync(new SignUpPage());
            }
        }
    }
}