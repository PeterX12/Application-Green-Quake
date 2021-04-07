using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Work
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffElectronics : ContentPage
    {
        public OffElectronics()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateBySixPoints();
            WorkPointsUpdate helper2 = new WorkPointsUpdate();
            helper2.ElectonicsOffPoints();
            await DisplayAlert("Alert", AppConstants.sixPointsMsg, "OK");
        }
    }
}