﻿using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

namespace Application_Green_Quake.Views.EcoActions.Community
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateEnvironmentalGroup : ContentPage
    {
        public CreateEnvironmentalGroup()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void AddPointsClicked(object sender, EventArgs e)
        {
            SecurityMethods checks = new SecurityMethods();
            Task<bool> myTask = checks.DayLimitLock();
            await myTask;

            Task<bool> myTaskTwo = checks.TimeLimitLock();
            await myTaskTwo;

            if (myTask.Result)
            {
                await DisplayAlert("Daily Limit Reached", "You can only log 15 Actions per day.", "OK");
                await Navigation.PushAsync(new MainMenu());
            }
            else if (myTaskTwo.Result)
            {
                await DisplayAlert("Too soon", "You must wait 1 minute before logging the next Action.", "OK");
                await Navigation.PushAsync(new MainMenu());
            }
            else
            {
                PointsUpdate helper = new PointsUpdate();
                helper.UpdateByTenPoints();
                CommunityPointsUpdate helper2 = new CommunityPointsUpdate();
                helper2.CreateGroupPoints();
                await DisplayAlert("Points Added", AppConstants.tenPointsMsg, "OK");
                await Navigation.PushAsync(new MainMenu());
            }
        }

        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}