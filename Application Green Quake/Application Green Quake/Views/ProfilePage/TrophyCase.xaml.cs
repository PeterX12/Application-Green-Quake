/*! \mainpage The TrophyCase View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the TrophyCase View Class. This class is the class that displays all the trophies on the trophy page.
 *
 */
using Application_Green_Quake.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophyCase : TabbedPage
    {
        /** The constructor for Main menu
        @param tab supplied to tell the class which tabbed page to display.
        */
        public TrophyCase(int tab)
        {
            InitializeComponent();
            CurrentPage = Children[tab];
            OnAppearing();
        }
        /** This function is called before the page is displayed. It displays the image as the criteria is met
        */
        protected override void OnAppearing()
        {
            if (GetData.points >= 1000)
            {
                t1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Trophies.diamond.png");
                t1Txt.Text = "Diamond Trophy";
            }
            if (GetData.points >= 500)
            {
                t2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Trophies.gold.png");
                t2Txt.Text = "Gold Trophy";
            }
            if (GetData.points >= 250)
            {
                t3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Trophies.silver.png");
                t3Txt.Text = "Silver Trophy";
            }
            if (GetData.points >= 100)
            {
                t4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Trophies.bronze.png");
                t4Txt.Text = "Bronze Trophy";
            }
        }
    }
}