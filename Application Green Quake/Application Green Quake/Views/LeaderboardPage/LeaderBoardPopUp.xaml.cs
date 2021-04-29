/*! \mainpage The LeaderBoardPopUp View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the LeaderBoardPopUp View Class. This class is the popup that appears when a entry in the LeaderBoard is tapped.
 *
 */
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.LeaderboardPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderBoardPopUp
    {
        /** The LeaderBoardPopUp Constructor
        @param username is the username to display
        @param points are the points to display
        @param rank is the rank to display
        @param image is the image to display
        @param bio is the bio to display
        */
        public LeaderBoardPopUp(string username, int points, string rank, ImageSource image, string bio)
        {
            InitializeComponent();
            profileImage.Source = image;
            theName.Text = "Username: " + username;
            thePoints.Text = "Points: " + points.ToString();
            theBio.Text = "Bio: " + bio;
            theRank.Text = rank;
        }
    }
}