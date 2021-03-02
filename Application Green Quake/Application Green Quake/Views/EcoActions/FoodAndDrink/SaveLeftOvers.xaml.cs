using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.FoodAndDrink
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaveLeftOvers : ContentPage
    {
        int addPoints = 3;
        public SaveLeftOvers()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdatePoints(addPoints);
            await DisplayAlert("Alert", addPoints + " Point Have been added", "OK");
        }
    }
}