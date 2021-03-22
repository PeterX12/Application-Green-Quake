﻿using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonHarmfulProducts : ContentPage
    {
        public NonHarmfulProducts()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByFourPoints();
            HomePointsUpdate helper2 = new HomePointsUpdate();
            helper2.NonHarmfulPoints();
            await DisplayAlert("Alert", AppConstants.fourPointsMsg, "OK");
        }
    }
}