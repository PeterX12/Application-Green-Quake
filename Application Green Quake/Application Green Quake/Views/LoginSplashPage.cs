using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Application_Green_Quake.Views
{
    public class LoginSplashPage : ContentPage
    {
        Image splashImage;

        public LoginSplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = ImageSource.FromResource("Application_Green_Quake.Images.trees.png"),
                WidthRequest =  150,
                HeightRequest =  150
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize,AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#50C878");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(0.4, 1100, Easing.Linear);
            await splashImage.ScaleTo(700, 900, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainMenu());
        }
    }
}
