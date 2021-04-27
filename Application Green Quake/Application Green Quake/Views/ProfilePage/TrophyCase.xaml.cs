using Application_Green_Quake.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophyCase : TabbedPage
    {
        public TrophyCase(int tab)
        {
            InitializeComponent();
            CurrentPage = Children[tab];
            OnAppearing();
        }

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