using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Work
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BothSidesPaper : ContentPage
    {
        public BothSidesPaper()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByFourPoints();
            WorkPointsUpdate helper2 = new WorkPointsUpdate();
            helper2.PaperPoints();
            await DisplayAlert("Alert", AppConstants.fourPointsMsg, "OK");
        }
    }
}