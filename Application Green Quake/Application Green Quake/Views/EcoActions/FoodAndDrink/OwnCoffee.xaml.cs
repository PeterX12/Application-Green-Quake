using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.FoodAndDrink
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OwnCoffee : ContentPage
    {
        public OwnCoffee()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTwoPoints();
            FoodAndDrinkPointsUpdate helper2 = new FoodAndDrinkPointsUpdate();
            helper2.OwnCoffeePoints();
            await DisplayAlert("Alert", AppConstants.twoPointsMsg, "OK");
        }
    }
}