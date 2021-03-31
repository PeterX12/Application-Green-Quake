using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Waste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UseRecyclingBin : ContentPage
    {
        public UseRecyclingBin()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            WastePointsUpdate helper2 = new WastePointsUpdate();
            helper2.RecyclingBinPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}