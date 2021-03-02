using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HabitsPage : ContentPage
    {
        public HabitsPage()
        {
            InitializeComponent();
        }

        private async void NavigateToBrushingPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrushingTeeth());
        }

        private async void NavigateToTimedShowerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimedShower());
        }

        private async void NavigateToShoweredInsteadOfBath(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowerInstead());
        }

        private async void NavigateToDishwasherFull(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DishwasherFull());

        }

        private async void NavigateToTurnOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());

        }

        private async void NavigateToUseMatches(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UseMatches());
        }
    }
}