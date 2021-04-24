using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Community;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommunityPage : ContentPage
    {
        public CommunityPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToEnvironmentalGroups(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnvironmentalGroups());
        }

        private async void NavigateToCreateEnvironmentalGroup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEnvironmentalGroup());
        }

        private async void NavigateToSpreadAwareness(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpreadAwareness());
        }

        private async void NavigateToDoCommunity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoCommunity());
        }

        private async void NavigateToDonateItems(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DonateItems());
        }

        private async void NavigateToShareThisaApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShareThisApp());
        }

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}