using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Water
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowerBucket : ContentPage
    {
        public ShowerBucket()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            WaterPointsUpdate helper2 = new WaterPointsUpdate();
            helper2.ShowerBucketPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
        }
    }
}