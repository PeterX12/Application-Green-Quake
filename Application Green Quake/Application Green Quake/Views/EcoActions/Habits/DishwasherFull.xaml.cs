using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Habits
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishwasherFull : ContentPage
    {
        public DishwasherFull()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            HabitsPointsUpdate helper2 = new HabitsPointsUpdate();
            helper2.DishWasherFullPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
        }
    }
}