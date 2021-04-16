﻿using Application_Green_Quake.ViewModels;
using Application_Green_Quake.Views.EcoActions.Habits;
using Application_Green_Quake.Views.EcoActions.Travel;
using Application_Green_Quake.Views.EcoActions.Work;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.EcoActions.EcoActionsSubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : ContentPage
    {
        int lvl = 0;
        public WorkPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        private async void NavigateToCarpool(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carpool());
        }

        private async void NavigateToPublicTransport(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicTransport());
        }

        private async void NavigateToCycle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cycle());
        }

        private async void NavigateToWalk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Walk());
        }

        private async void NavigateToEcoFreindlyCar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EcoFreindlyCar());
        }

        private async void NavigateToOffLights(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurnOffLights());
        }

        private async void NavigateToOffElectronics(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffElectronics());
        }

        private async void NavigateToWorkingRemotely(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkingRemotely());
        }

        private async void NavigateToBothSidesPaper(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BothSidesPaper());
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