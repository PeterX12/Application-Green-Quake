using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Habits
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UseMatches : ContentPage
    {
        public UseMatches()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTwoPoints();
            HabitsPointsUpdate helper2 = new HabitsPointsUpdate();
            helper2.MatchesPoints();
            await DisplayAlert("Alert", AppConstants.twoPointsMsg, "OK");
        }
    }
}