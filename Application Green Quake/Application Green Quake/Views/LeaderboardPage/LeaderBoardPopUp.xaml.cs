using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.LeaderboardPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderBoardPopUp
    {
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