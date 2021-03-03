﻿using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutsideOnce : ContentPage
    {
        public OutsideOnce()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTwoPoints();
            await DisplayAlert("Alert", AppConstants.twoPointsMsg, "OK");
        }
    }
}