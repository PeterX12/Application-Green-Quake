﻿using Application_Green_Quake.Models;
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
    public partial class EatAllYouMake : ContentPage
    {
        int lvl = 0;
        public EatAllYouMake()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByFourPoints();
            FoodAndDrinkPointsUpdate helper2 = new FoodAndDrinkPointsUpdate();
            helper2.EatAllPoints();
            await DisplayAlert("Alert", AppConstants.fourPointsMsg, "OK");
            await Navigation.PushAsync(new MainMenu());
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