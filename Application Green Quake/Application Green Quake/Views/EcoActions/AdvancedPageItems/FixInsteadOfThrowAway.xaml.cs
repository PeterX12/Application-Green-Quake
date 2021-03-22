using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.AdvancedPageItems
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FixInsteadOfThrowAway : ContentPage
    {
        public FixInsteadOfThrowAway()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            AdvancedPointsUpdate helper2 = new AdvancedPointsUpdate();
            helper2.FixPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}
