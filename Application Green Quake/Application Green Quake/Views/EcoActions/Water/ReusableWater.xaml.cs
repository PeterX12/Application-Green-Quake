using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Water
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReusableWater : ContentPage
    {
        public ReusableWater()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateBySixPoints();
            WaterPointsUpdate helper2 = new WaterPointsUpdate();
            helper2.ReWaterPoints();
            await DisplayAlert("Alert", AppConstants.sixPointsMsg, "OK");
        }
    }
}