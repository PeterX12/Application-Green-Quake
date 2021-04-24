using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.AdvancedPageItems;
using System;
using System.Threading.Tasks;
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
            OnAppearing();
        }

        private async void NavigateToFix(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FixInsteadOfThrowAway());
        }

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}