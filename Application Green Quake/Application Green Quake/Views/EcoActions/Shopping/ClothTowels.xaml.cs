using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Shopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClothTowels : ContentPage
    {
        public ClothTowels()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTwoPoints();
            ShoppingPointsUpdate helper2 = new ShoppingPointsUpdate();
            helper2.ClothTowelsPoints();
            await DisplayAlert("Alert", AppConstants.twoPointsMsg, "OK");
        }
    }
}