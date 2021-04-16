using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.FoodAndDrink
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuyOrganicFood : ContentPage
    {
        int lvl = 0;
        public BuyOrganicFood()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            ShoppingPointsUpdate helper2 = new ShoppingPointsUpdate();
            helper2.OrganicPoints();
            FoodAndDrinkPointsUpdate helper3 = new FoodAndDrinkPointsUpdate();
            helper3.OrganicPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
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