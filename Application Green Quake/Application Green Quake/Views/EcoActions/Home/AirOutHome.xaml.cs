using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirOutHome : ContentPage
    {
        public AirOutHome()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTwoPoints();
            HomePointsUpdate helper2 = new HomePointsUpdate();
            helper2.AirOutPoints();
            await DisplayAlert("Alert", AppConstants.twoPointsMsg, "OK");
        }
    }
}