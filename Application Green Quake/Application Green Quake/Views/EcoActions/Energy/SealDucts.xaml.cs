﻿using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Energy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SealDucts : ContentPage
    {
        int lvl = 0;
        public SealDucts()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByEightPoints();
            EnergyPointsUpdate helper2 = new EnergyPointsUpdate();
            helper2.SealDuctsPoints();
            await DisplayAlert("Alert", AppConstants.eightPointsMsg, "OK");
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