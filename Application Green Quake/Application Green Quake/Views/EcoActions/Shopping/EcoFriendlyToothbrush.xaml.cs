using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Shopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EcoFriendlyToothbrush : ContentPage
    {
        public EcoFriendlyToothbrush()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateBySixPoints();
            ShoppingPointsUpdate helper2 = new ShoppingPointsUpdate();
            helper2.EcoToothbrushPoints();
            await DisplayAlert("Alert", AppConstants.sixPointsMsg, "OK");
        }
    }
}