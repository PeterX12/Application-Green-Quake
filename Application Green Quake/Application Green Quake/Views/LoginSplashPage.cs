/*! \mainpage The LoginSplashPage View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the LoginSplashPage View Class. This class provides the splash screen when a user logs into the applciation.
 *
 */
using Xamarin.Forms;

namespace Application_Green_Quake.Views
{
    public class LoginSplashPage : ContentPage
    {
        Image splashImage;

        /** This function fires when the Login button is clicked. It provides the splash screen and then navigates to the main menu right after.
        */
        public LoginSplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            //Set the image for the splash screen
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
            //Set the animation
            await splashImage.ScaleTo(0.4, 1100, Easing.Linear);
            await splashImage.ScaleTo(700, 900, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainMenu());
        }
    }
}
