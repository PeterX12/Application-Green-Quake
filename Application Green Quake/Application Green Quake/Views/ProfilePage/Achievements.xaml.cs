using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Achievements : ContentPage
    {
        public Achievements()
        {
            InitializeComponent();
        }

        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }
    }
}