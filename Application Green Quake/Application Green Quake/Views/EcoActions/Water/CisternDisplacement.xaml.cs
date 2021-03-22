using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Water
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CisternDisplacement : ContentPage
    {
        public CisternDisplacement()
        {
            InitializeComponent();
        }
        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            WaterPointsUpdate helper2 = new WaterPointsUpdate();
            helper2.CisternPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}