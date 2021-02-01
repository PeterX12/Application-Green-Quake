﻿using Application_Green_Quake.Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.EcoActions.Shopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EcoFriendlyPorduct : ContentPage
    {
        int addPoints = 3;
        public EcoFriendlyPorduct()
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