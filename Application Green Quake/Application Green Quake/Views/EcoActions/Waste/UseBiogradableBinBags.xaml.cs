using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Waste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UseBiogradableBinBags : ContentPage
    {
        public UseBiogradableBinBags()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByFourPoints();
            WastePointsUpdate helper2 = new WastePointsUpdate();
            helper2.BioBinBagPoints();
            await DisplayAlert("Alert", AppConstants.fourPointsMsg, "OK");
        }
    }
}