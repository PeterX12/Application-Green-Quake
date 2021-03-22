using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Travel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cycle : ContentPage
    {
        public Cycle()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            TravelPointsUpdate helper2 = new TravelPointsUpdate();
            helper2.CyclePoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}