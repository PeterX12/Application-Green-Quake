using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.FoodAndDrink
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WaterOverFizzy : ContentPage
    {
        public WaterOverFizzy()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            FoodAndDrinkPointsUpdate helper2 = new FoodAndDrinkPointsUpdate();
            helper2.WaterOverFizzyPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
        }
    }
}