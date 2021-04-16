using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.AdvancedPageItems;
using Application_Green_Quake.Views.EcoActions.Outdoors;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedPage : ContentPage
    {
        int lvl = 0;
        public AdvancedPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToFix(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FixInsteadOfThrowAway());
        }

        protected async override void OnAppearing()
        {
            try
            {
                GetData theLvl = new GetData();
                Task<int> myTask4 = theLvl.GetLevel();
                await myTask4;
                lvl = myTask4.Result;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            theLevel.Text = "LVL: " + lvl;
        }
    }
}