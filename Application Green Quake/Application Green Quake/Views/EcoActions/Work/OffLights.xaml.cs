using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Work
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffLights : ContentPage
    {
        int addPoints = 3;
        public OffLights()
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