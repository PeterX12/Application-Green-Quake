using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Outdoors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoCamping : ContentPage
    {
        public GoCamping()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateBySixPoints();
            OutdoorsPointsUpdate helper2 = new OutdoorsPointsUpdate();
            helper2.CampingPoints();
            await DisplayAlert("Alert", AppConstants.sixPointsMsg, "OK");
        }
    }
}