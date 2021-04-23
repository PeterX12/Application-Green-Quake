using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Badges : ContentPage
    {
        int habitsStage = 0;
        int advancedStage = 0;
        int communityStage = 0;
        int energyStage = 0;
        int foodDrinkStage = 0;
        int homeStage = 0;
        int outdoorsStage = 0;
        int shoppingStage = 0;
        int travelStage = 0;
        int wasteStage = 0;
        int waterStage = 0;
        int workStage = 0;
        public Badges()
        {
            InitializeComponent();
            OnAppearing();
        }

        protected override void OnAppearing()
        {
            if (GetBadgeData.habitsLog > 0 && GetBadgeData.habitsLog < 5)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsOne.png");
                a1Txt.Text = "Habits Novice";
                habitsStage = 1;
            }
            else if (GetBadgeData.habitsLog >= 5 && GetBadgeData.habitsLog < 10)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsTwo.png");
                a1Txt.Text = "Habits Apprentice";
                habitsStage = 2;
            }
            else if (GetBadgeData.habitsLog >= 10 && GetBadgeData.habitsLog < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsThree.png");
                a1Txt.Text = "Habits Adept";
                habitsStage = 3;
            }
            else if (GetBadgeData.habitsLog >= 25 && GetBadgeData.habitsLog < 50)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFour.png");
                a1Txt.Text = "Habits Expert";
                habitsStage = 4;
            }
            else if (GetBadgeData.habitsLog >= 50 && GetBadgeData.habitsLog < 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFive.png");
                a1Txt.Text = "Habits Master";
                habitsStage = 5;
            }
            else if (GetBadgeData.habitsLog >= 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsSix.png");
                a1Txt.Text = "Habits Legend";
                habitsStage = 6;
            }


            if (GetBadgeData.advancedLog > 0 && GetBadgeData.advancedLog < 5)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedOne.png");
                a2Txt.Text = "Advanced Novice";
                advancedStage = 1;
            }
            else if (GetBadgeData.advancedLog >= 5 && GetBadgeData.advancedLog < 10)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedTwo.png");
                a2Txt.Text = "Advanced Apprentice";
                advancedStage = 2;
            }
            else if (GetBadgeData.advancedLog >= 10 && GetBadgeData.advancedLog < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedThree.png");
                a2Txt.Text = "Advanced Adept";
                advancedStage = 3;
            }
            else if (GetBadgeData.advancedLog >= 25 && GetBadgeData.advancedLog < 50)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFour.png");
                a2Txt.Text = "Advanced Expert";
                advancedStage = 4;
            }
            else if (GetBadgeData.advancedLog >= 50 && GetBadgeData.advancedLog < 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFive.png");
                a2Txt.Text = "Advanced Master";
                advancedStage = 5;
            }
            else if (GetBadgeData.advancedLog >= 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedSix.png");
                a2Txt.Text = "Advanced Legend";
                advancedStage = 6;
            }
            
            if (GetBadgeData.communityLog > 0 && GetBadgeData.communityLog < 5)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityOne.png");
                a3Txt.Text = "Community Novice";
                communityStage = 1;
            }
            else if (GetBadgeData.communityLog >= 5 && GetBadgeData.communityLog < 10)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityTwo.png");
                a3Txt.Text = "Community Apprentice";
                communityStage = 2;
            }
            else if (GetBadgeData.communityLog >= 10 && GetBadgeData.communityLog < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityThree.png");
                a3Txt.Text = "Community Adept";
                communityStage = 3;
            }
            else if (GetBadgeData.communityLog >= 25 && GetBadgeData.communityLog < 50)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFour.png");
                a3Txt.Text = "Community Expert";
                communityStage = 4;
            }
            else if (GetBadgeData.communityLog >= 50 && GetBadgeData.communityLog < 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFive.png");
                a3Txt.Text = "Community Master";
                communityStage = 5;
            }
            else if (GetBadgeData.communityLog >= 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communitySix.png");
                a3Txt.Text = "Community Legend";
                communityStage = 6;
            }

            if (GetBadgeData.energyLog > 0 && GetBadgeData.energyLog < 5)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyOne.png");
                a4Txt.Text = "Energy Novice";
                energyStage = 1;
            }
            else if (GetBadgeData.energyLog >= 5 && GetBadgeData.energyLog < 10)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyTwo.png");
                a4Txt.Text = "Energy Apprentice";
                energyStage = 2;
            }
            else if (GetBadgeData.energyLog >= 10 && GetBadgeData.energyLog < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyThree.png");
                a4Txt.Text = "Energy Adept";
                energyStage = 3;
            }
            else if (GetBadgeData.energyLog >= 25 && GetBadgeData.energyLog < 50)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFour.png");
                a4Txt.Text = "Energy Expert";
                energyStage = 4;
            }
            else if (GetBadgeData.energyLog >= 50 && GetBadgeData.energyLog < 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFive.png");
                a4Txt.Text = "Energy Master";
                energyStage = 5;
            }
            else if (GetBadgeData.energyLog >= 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energySix.png");
                a4Txt.Text = "Energy Legend";
                energyStage = 6;
            }

            if (GetBadgeData.foodDrinkLog > 0 && GetBadgeData.foodDrinkLog < 5)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDOne.png");
                a5Txt.Text = "F & D Novice";
                foodDrinkStage = 1;
            }
            else if (GetBadgeData.foodDrinkLog >= 5 && GetBadgeData.foodDrinkLog < 10)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDTwo.png");
                a5Txt.Text = "F & D Apprentice";
                foodDrinkStage = 2;
            }
            else if (GetBadgeData.foodDrinkLog >= 10 && GetBadgeData.foodDrinkLog < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDThree.png");
                a5Txt.Text = "F & D Adept";
                foodDrinkStage = 3;
            }
            else if (GetBadgeData.foodDrinkLog >= 25 && GetBadgeData.foodDrinkLog < 50)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFour.png");
                a5Txt.Text = "F & D Expert";
                foodDrinkStage = 4;
            }
            else if (GetBadgeData.foodDrinkLog >= 50 && GetBadgeData.foodDrinkLog < 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFive.png");
                a5Txt.Text = "F & D Master";
                foodDrinkStage = 5;
            }
            else if (GetBadgeData.foodDrinkLog >= 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDSix.png");
                a5Txt.Text = "F & D Legend";
                foodDrinkStage = 6;
            }

            if (GetBadgeData.homeLog > 0 && GetBadgeData.homeLog < 5)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeOne.png");
                a6Txt.Text = "Home Novice";
                homeStage = 1;
            }
            else if (GetBadgeData.homeLog >= 5 && GetBadgeData.homeLog < 10)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeTwo.png");
                a6Txt.Text = "Home Apprentice";
                homeStage = 2;
            }
            else if (GetBadgeData.homeLog >= 10 && GetBadgeData.homeLog < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeThree.png");
                a6Txt.Text = "Home Adept";
                homeStage = 3;
            }
            else if (GetBadgeData.homeLog >= 25 && GetBadgeData.homeLog < 50)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFour.png");
                a6Txt.Text = "Home Expert";
                homeStage = 4;
            }
            else if (GetBadgeData.homeLog >= 50 && GetBadgeData.homeLog < 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFive.png");
                a6Txt.Text = "Home Master";
                homeStage = 5;
            }
            else if (GetBadgeData.homeLog >= 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeSix.png");
                a6Txt.Text = "Home Legend";
                homeStage = 6;
            }

            if (GetBadgeData.outdoorsLog > 0 && GetBadgeData.outdoorsLog < 5)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsOne.png");
                a7Txt.Text = "Outdoors Novice";
                outdoorsStage = 1;
            }
            else if (GetBadgeData.outdoorsLog >= 5 && GetBadgeData.outdoorsLog < 10)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsTwo.png");
                a7Txt.Text = "Outdoors Apprentice";
                outdoorsStage = 2;
            }
            else if (GetBadgeData.outdoorsLog >= 10 && GetBadgeData.outdoorsLog < 25)
            {
                a7.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Outdoors.outdoorsThree.png");
                a7Txt.Text = "Outdoors Adept";
                outdoorsStage = 3;
            }
            else if (GetBadgeData.outdoorsLog >= 25 && GetBadgeData.outdoorsLog < 50)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFour.png");
                a7Txt.Text = "Outdoors Expert";
                outdoorsStage = 4;
            }
            else if (GetBadgeData.outdoorsLog >= 50 && GetBadgeData.outdoorsLog < 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFive.png");
                a7Txt.Text = "Outdoors Master";
                outdoorsStage = 5;
            }
            else if (GetBadgeData.outdoorsLog >= 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsSix.png");
                a7Txt.Text = "Outdoors Legend";
                outdoorsStage = 6;
            }

            if (GetBadgeData.shoppingLog > 0 && GetBadgeData.shoppingLog < 5)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingOne.png");
                a8Txt.Text = "Shopping Novice";
                shoppingStage = 1;
            }
            else if (GetBadgeData.shoppingLog >= 5 && GetBadgeData.shoppingLog < 10)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingTwo.png");
                a8Txt.Text = "Shopping Apprentice";
                shoppingStage = 2;
            }
            else if (GetBadgeData.shoppingLog >= 10 && GetBadgeData.shoppingLog < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingThree.png");
                a8Txt.Text = "Shopping Adept";
                shoppingStage = 3;
            }
            else if (GetBadgeData.shoppingLog >= 25 && GetBadgeData.shoppingLog < 50)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFour.png");
                a8Txt.Text = "Shopping Expert";
                shoppingStage = 4;
            }
            else if (GetBadgeData.shoppingLog >= 50 && GetBadgeData.shoppingLog < 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFive.png");
                a8Txt.Text = "Shopping Master";
                shoppingStage = 5;
            }
            else if (GetBadgeData.shoppingLog >= 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingSix.png");
                a8Txt.Text = "Shopping Legend";
                shoppingStage = 6;
            }

            if (GetBadgeData.travelLog > 0 && GetBadgeData.travelLog < 5)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelOne.png");
                a9Txt.Text = "Travel Novice";
                travelStage = 1;
            }
            else if (GetBadgeData.travelLog >= 5 && GetBadgeData.travelLog < 10)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelTwo.png");
                a9Txt.Text = "Travel Apprentice";
                travelStage = 2;
            }
            else if (GetBadgeData.travelLog >= 10 && GetBadgeData.travelLog < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelThree.png");
                a9Txt.Text = "Travel Adept";
                travelStage = 3;
            }
            else if (GetBadgeData.travelLog >= 25 && GetBadgeData.travelLog < 50)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFour.png");
                a9Txt.Text = "Travel Expert";
                travelStage = 4;
            }
            else if (GetBadgeData.travelLog >= 50 && GetBadgeData.travelLog < 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFive.png");
                a9Txt.Text = "Travel Master";
                travelStage = 5;
            }
            else if (GetBadgeData.travelLog >= 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelSix.png");
                a9Txt.Text = "Travel Legend";
                travelStage = 6;
            }

            if (GetBadgeData.wasteLog > 0 && GetBadgeData.wasteLog < 5)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteOne.png");
                a10Txt.Text = "Waste Novice";
                wasteStage = 1;
            }
            else if (GetBadgeData.wasteLog >= 5 && GetBadgeData.wasteLog < 10)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteTwo.png");
                a10Txt.Text = "Waste Apprentice";
                wasteStage = 2;
            }
            else if (GetBadgeData.wasteLog >= 10 && GetBadgeData.wasteLog < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteThree.png");
                a10Txt.Text = "Waste Adept";
                wasteStage = 3;
            }
            else if (GetBadgeData.wasteLog >= 25 && GetBadgeData.wasteLog < 50)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFour.png");
                a10Txt.Text = "Waste Expert";
                wasteStage = 4;
            }
            else if (GetBadgeData.wasteLog >= 50 && GetBadgeData.wasteLog < 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFive.png");
                a10Txt.Text = "Waste Master";
                wasteStage = 5;
            }
            else if (GetBadgeData.wasteLog >= 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteSix.png");
                a10Txt.Text = "Waste Legend";
                wasteStage = 6;
            }

            if (GetBadgeData.waterLog > 0 && GetBadgeData.waterLog < 5)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterOne.png");
                a11Txt.Text = "Water Novice";
                waterStage = 1;
            }
            else if (GetBadgeData.waterLog >= 5 && GetBadgeData.waterLog < 10)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterTwo.png");
                a11Txt.Text = "Water Apprentice";
                waterStage = 2;
            }
            else if (GetBadgeData.waterLog >= 10 && GetBadgeData.waterLog < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterThree.png");
                a11Txt.Text = "Water Adept";
                waterStage = 3;
            }
            else if (GetBadgeData.waterLog >= 25 && GetBadgeData.waterLog < 50)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFour.png");
                a11Txt.Text = "Water Expert";
                waterStage = 4;
            }
            else if (GetBadgeData.waterLog >= 50 && GetBadgeData.waterLog < 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFive.png");
                a11Txt.Text = "Water Master";
                waterStage = 5;
            }
            else if (GetBadgeData.waterLog >= 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterSix.png");
                a11Txt.Text = "Water Legend";
                waterStage = 6;
            }

            if (GetBadgeData.workLog > 0 && GetBadgeData.workLog < 5)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workOne.png");
                a12Txt.Text = "Work Novice";
                workStage = 1;
            }
            else if (GetBadgeData.workLog >= 5 && GetBadgeData.workLog < 10)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workTwo.png");
                a12Txt.Text = "Work Apprentice";
                workStage = 2;
            }
            else if (GetBadgeData.workLog >= 10 && GetBadgeData.workLog < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workThree.png");
                a12Txt.Text = "Work Adept";
                workStage = 3;
            }
            else if (GetBadgeData.workLog >= 25 && GetBadgeData.workLog < 50)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFour.png");
                a12Txt.Text = "Work Expert";
                workStage = 4;
            }
            else if (GetBadgeData.workLog >= 50 && GetBadgeData.workLog < 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFive.png");
                a12Txt.Text = "Work Master";
                workStage = 5;
            }
            else if (GetBadgeData.workLog >= 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workSix.png");
                a12Txt.Text = "Work Legend";
                workStage = 6;
            }
        }

        private async void NavigateToBadgePopUpOne(object sender, EventArgs e)
        {
            int number = 1;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, habitsStage));
        }

        private async void NavigateToBadgePopUpTwo(object sender, EventArgs e)
        {
            int number = 2;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, advancedStage));
        }

        private async void NavigateToBadgePopUpThree(object sender, EventArgs e)
        {
            int number = 3;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, communityStage));
        }

        private async void NavigateToBadgePopUpFour(object sender, EventArgs e)
        {
            int number = 4;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, energyStage));
        }

        private async void NavigateToBadgePopUpFive(object sender, EventArgs e)
        {
            int number = 5;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, foodDrinkStage));
        }

        private async void NavigateToBadgePopUpSix(object sender, EventArgs e)
        {
            int number = 6;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, homeStage));
        }

        private async void NavigateToBadgePopUpSeven(object sender, EventArgs e)
        {
            int number = 7;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, outdoorsStage));
        }

        private async void NavigateToBadgePopUpEight(object sender, EventArgs e)
        {
            int number = 8;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, shoppingStage));
        }

        private async void NavigateToBadgePopUpNine(object sender, EventArgs e)
        {
            int number = 9;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, travelStage));
        }

        private async void NavigateToBadgePopUpTen(object sender, EventArgs e)
        {
            int number = 10;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, wasteStage));
        }

        private async void NavigateToBadgePopUpEleven(object sender, EventArgs e)
        {
            int number = 11;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, waterStage));
        }

        private async void NavigateToBadgePopUpTwelve(object sender, EventArgs e)
        {
            int number = 12;
            await PopupNavigation.Instance.PushAsync(new BadgePopUp(number, workStage));
        }
    }
}