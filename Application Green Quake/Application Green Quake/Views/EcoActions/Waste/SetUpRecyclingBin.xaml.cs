﻿using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Waste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetUpRecyclingBin : ContentPage
    {
        public SetUpRecyclingBin()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdateByTenPoints();
            WastePointsUpdate helper2 = WastePointsUpdate();
            helper2.SetUpRecyclingBinPoints();
            await DisplayAlert("Alert", AppConstants.tenPointsMsg, "OK");
        }
    }
}