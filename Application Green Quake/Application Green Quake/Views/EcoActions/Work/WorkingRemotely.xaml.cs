﻿using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.Work
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkingRemotely : ContentPage
    {
        public WorkingRemotely()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function creates objects and calls their methods. First the security methods are called and if they return false call the points updating
         * methods
        */
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
                WorkPointsUpdate helper2 = new WorkPointsUpdate();
                helper2.RemoteWorkPoints();
                await DisplayAlert("Points Added", AppConstants.tenPointsMsg, "OK");
                await Navigation.PushAsync(new MainMenu());
            }
        }
        /** This function creates objects and calls their methods. First the security methods are called and if they return false call the points updating
         * methods
        */
        protected override void OnAppearing()
        {
            GetData data = new GetData();
            data.SetLvl();

            theLevel.Text = "LVL: " + GetData.lvl.ToString();
        }
    }
}