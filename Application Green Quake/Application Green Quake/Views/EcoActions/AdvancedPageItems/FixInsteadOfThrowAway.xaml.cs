using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.AdvancedPageItems
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FixInsteadOfThrowAway : ContentPage
    {
        int addPoints = 2;
        public FixInsteadOfThrowAway()
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
