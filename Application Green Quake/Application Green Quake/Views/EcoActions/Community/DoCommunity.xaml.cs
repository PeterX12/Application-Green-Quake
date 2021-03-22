using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Community
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoCommunity : ContentPage
    {
        public DoCommunity()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            CommunityPointsUpdate helper2 = new CommunityPointsUpdate();
            helper2.CommunityPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}