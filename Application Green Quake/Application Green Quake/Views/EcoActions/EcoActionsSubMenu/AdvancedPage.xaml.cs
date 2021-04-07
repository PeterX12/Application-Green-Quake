using Application_Green_Quake.Views.EcoActions.AdvancedPageItems;
using Application_Green_Quake.Views.EcoActions.Outdoors;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedPage : ContentPage
    {
        public AdvancedPage()
        {
            InitializeComponent();
        }

        private async void NavigateToFix(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FixInsteadOfThrowAway());
        }
    }
}