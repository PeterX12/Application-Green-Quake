﻿using Application_Green_Quake.Reusable;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.EcoActions.Outdoors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoCamping : ContentPage
    {
        int addPoints = 3;
        public GoCamping()
        {
            InitializeComponent();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            PointsUpdate helper = new PointsUpdate();
            helper.UpdatePoints(addPoints);
            await DisplayAlert("Alert", addPoints + " Point Have been added", "OK");
        }
    }
}