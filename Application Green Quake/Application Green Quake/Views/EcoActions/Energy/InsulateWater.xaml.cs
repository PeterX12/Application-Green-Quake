using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Energy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsulateWater : ContentPage
    {
        public InsulateWater()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            EnergyPointsUpdate helper2 = new EnergyPointsUpdate();
            helper2.InsulateWaterPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}