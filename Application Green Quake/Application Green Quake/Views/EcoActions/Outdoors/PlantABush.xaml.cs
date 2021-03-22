using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Outdoors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantABush : ContentPage
    {
        public PlantABush()
        {
            InitializeComponent();
        }
        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            OutdoorsPointsUpdate helper2 = new OutdoorsPointsUpdate();
            helper2.PlantBushPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
        }
    }
}