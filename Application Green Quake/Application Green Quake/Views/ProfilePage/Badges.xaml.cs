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
        IAuth auth;
        int habitsLog = 0;
        int advancedLog = 0;
        int communityLog = 0;
        int energyLog = 0;
        int foodDrinkLog = 0;
        int homeLog = 0;
        int outdoorsLog = 0;
        int shoppingLog = 0;
        int travelLog = 0;
        int wasteLog = 0;
        int waterLog = 0;
        int workLog = 0;
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
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }

        protected async override void OnAppearing()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
             habitsLog = (await firebaseClient
            .Child("HabitsPoints")
            .Child(auth.GetUid())
            .OnceSingleAsync<HabitsPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             advancedLog = (await firebaseClient
             .Child("AdvancedPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<AdvancedPoints>()).numberOfLogs;
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
            try
            {
             communityLog = (await firebaseClient
             .Child("CommunityPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<CommunityPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             energyLog = (await firebaseClient
             .Child("EnergyPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<EnergyPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             foodDrinkLog = (await firebaseClient
             .Child("FoodAndDrinkPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             homeLog = (await firebaseClient
             .Child("HomePoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<HomePoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             outdoorsLog = (await firebaseClient
             .Child("OutdoorsPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<OutdoorsPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             shoppingLog = (await firebaseClient
             .Child("ShoppingPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             travelLog = (await firebaseClient
             .Child("TravelPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<TravelPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             wasteLog = (await firebaseClient
             .Child("WastePoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<WastePoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             waterLog = (await firebaseClient
             .Child("WaterPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<WaterPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
             workLog = (await firebaseClient
             .Child("WorkPoints")
             .Child(auth.GetUid())
             .OnceSingleAsync<WorkPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            if (habitsLog > 0 && habitsLog < 5)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsOne.png");
                a1Txt.Text = "Habits Novice";
                habitsStage = 1;
            }
            else if (habitsLog >= 5 && habitsLog < 10)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsTwo.png");
                a1Txt.Text = "Habits Apprentice";
                habitsStage = 2;
            }
            else if (habitsLog >= 10 && habitsLog < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsThree.png");
                a1Txt.Text = "Habits Adept";
                habitsStage = 3;
            }
            else if (habitsLog >= 25 && habitsLog < 50)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFour.png");
                a1Txt.Text = "Habits Expert";
                habitsStage = 4;
            }
            else if (habitsLog >= 50 && habitsLog < 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFive.png");
                a1Txt.Text = "Habits Master";
                habitsStage = 5;
            }
            else if (habitsLog >= 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsSix.png");
                a1Txt.Text = "Habits Legend";
                habitsStage = 6;
            }


            if (advancedLog > 0 && advancedLog < 5)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedOne.png");
                a2Txt.Text = "Advanced Novice";
                advancedStage = 1;
            }
            else if (advancedLog >= 5 && advancedLog < 10)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedTwo.png");
                a2Txt.Text = "Advanced Apprentice";
                advancedStage = 2;
            }
            else if (advancedLog >= 10 && advancedLog < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedThree.png");
                a2Txt.Text = "Advanced Adept";
                advancedStage = 3;
            }
            else if (advancedLog >= 25 && advancedLog < 50)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFour.png");
                a2Txt.Text = "Advanced Expert";
                advancedStage = 4;
            }
            else if (advancedLog >= 50 && advancedLog < 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFive.png");
                a2Txt.Text = "Advanced Master";
                advancedStage = 5;
            }
            else if (advancedLog >= 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedSix.png");
                a2Txt.Text = "Advanced Legend";
                advancedStage = 6;
            }

            if (communityLog > 0 && communityLog < 5)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityOne.png");
                a3Txt.Text = "Community Novice";
                communityStage = 1;
            }
            else if (communityLog >= 5 && communityLog < 10)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityTwo.png");
                a3Txt.Text = "Community Apprentice";
                communityStage = 2;
            }
            else if (communityLog >= 10 && communityLog < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityThree.png");
                a3Txt.Text = "Community Adept";
                communityStage = 3;
            }
            else if (communityLog >= 25 && communityLog < 50)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFour.png");
                a3Txt.Text = "Community Expert";
                communityStage = 4;
            }
            else if (communityLog >= 50 && communityLog < 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFive.png");
                a3Txt.Text = "Community Master";
                communityStage = 5;
            }
            else if (communityLog >= 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communitySix.png");
                a3Txt.Text = "Community Legend";
                communityStage = 6;
            }

            if (energyLog > 0 && energyLog < 5)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyOne.png");
                a4Txt.Text = "Energy Novice";
                energyStage = 1;
            }
            else if (energyLog >= 5 && energyLog < 10)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyTwo.png");
                a4Txt.Text = "Energy Apprentice";
                energyStage = 2;
            }
            else if (energyLog >= 10 && energyLog < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyThree.png");
                a4Txt.Text = "Energy Adept";
                energyStage = 3;
            }
            else if (energyLog >= 25 && energyLog < 50)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFour.png");
                a4Txt.Text = "Energy Expert";
                energyStage = 4;
            }
            else if (energyLog >= 50 && energyLog < 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFive.png");
                a4Txt.Text = "Energy Master";
                energyStage = 5;
            }
            else if (energyLog >= 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energySix.png");
                a4Txt.Text = "Energy Legend";
                energyStage = 6;
            }

            if (foodDrinkLog > 0 && foodDrinkLog < 5)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDOne.png");
                a5Txt.Text = "F & D Novice";
                foodDrinkStage = 1;
            }
            else if (foodDrinkLog >= 5 && foodDrinkLog < 10)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDTwo.png");
                a5Txt.Text = "F & D Apprentice";
                foodDrinkStage = 2;
            }
            else if (foodDrinkLog >= 10 && foodDrinkLog < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDThree.png");
                a5Txt.Text = "F & D Adept";
                foodDrinkStage = 3;
            }
            else if (foodDrinkLog >= 25 && foodDrinkLog < 50)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFour.png");
                a5Txt.Text = "F & D Expert";
                foodDrinkStage = 4;
            }
            else if (foodDrinkLog >= 50 && foodDrinkLog < 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFive.png");
                a5Txt.Text = "F & D Master";
                foodDrinkStage = 5;
            }
            else if (foodDrinkLog >= 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDSix.png");
                a5Txt.Text = "F & D Legend";
                foodDrinkStage = 6;
            }

            if (homeLog > 0 && homeLog < 5)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeOne.png");
                a6Txt.Text = "Home Novice";
                homeStage = 1;
            }
            else if (homeLog >= 5 && homeLog < 10)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeTwo.png");
                a6Txt.Text = "Home Apprentice";
                homeStage = 2;
            }
            else if (homeLog >= 10 && homeLog < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeThree.png");
                a6Txt.Text = "Home Adept";
                homeStage = 3;
            }
            else if (homeLog >= 25 && homeLog < 50)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFour.png");
                a6Txt.Text = "Home Expert";
                homeStage = 4;
            }
            else if (homeLog >= 50 && homeLog < 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFive.png");
                a6Txt.Text = "Home Master";
                homeStage = 5;
            }
            else if (homeLog >= 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeSix.png");
                a6Txt.Text = "Home Legend";
                homeStage = 6;
            }

            if (outdoorsLog > 0 && outdoorsLog < 5)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsOne.png");
                a7Txt.Text = "Outdoors Novice";
                outdoorsStage = 1;
            }
            else if (outdoorsLog >= 5 && outdoorsLog < 10)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsTwo.png");
                a7Txt.Text = "Outdoors Apprentice";
                outdoorsStage = 2;
            }
            else if (outdoorsLog >= 10 && outdoorsLog < 25)
            {
                a7.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Outdoors.outdoorsThree.png");
                a7Txt.Text = "Outdoors Adept";
                outdoorsStage = 3;
            }
            else if (outdoorsLog >= 25 && outdoorsLog < 50)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFour.png");
                a7Txt.Text = "Outdoors Expert";
                outdoorsStage = 4;
            }
            else if (outdoorsLog >= 50 && outdoorsLog < 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFive.png");
                a7Txt.Text = "Outdoors Master";
                outdoorsStage = 5;
            }
            else if (outdoorsLog >= 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsSix.png");
                a7Txt.Text = "Outdoors Legend";
                outdoorsStage = 6;
            }

            if (shoppingLog > 0 && shoppingLog < 5)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingOne.png");
                a8Txt.Text = "Shopping Novice";
                shoppingStage = 1;
            }
            else if (shoppingLog >= 5 && shoppingLog < 10)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingTwo.png");
                a8Txt.Text = "Shopping Apprentice";
                shoppingStage = 2;
            }
            else if (shoppingLog >= 10 && shoppingLog < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingThree.png");
                a8Txt.Text = "Shopping Adept";
                shoppingStage = 3;
            }
            else if (shoppingLog >= 25 && shoppingLog < 50)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFour.png");
                a8Txt.Text = "Shopping Expert";
                shoppingStage = 4;
            }
            else if (shoppingLog >= 50 && shoppingLog < 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFive.png");
                a8Txt.Text = "Shopping Master";
                shoppingStage = 5;
            }
            else if (shoppingLog >= 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingSix.png");
                a8Txt.Text = "Shopping Legend";
                shoppingStage = 6;
            }

            if (travelLog > 0 && travelLog < 5)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelOne.png");
                a9Txt.Text = "Travel Novice";
                travelStage = 1;
            }
            else if (travelLog >= 5 && travelLog < 10)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelTwo.png");
                a9Txt.Text = "Travel Apprentice";
                travelStage = 2;
            }
            else if (travelLog >= 10 && travelLog < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelThree.png");
                a9Txt.Text = "Travel Adept";
                travelStage = 3;
            }
            else if (travelLog >= 25 && travelLog < 50)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFour.png");
                a9Txt.Text = "Travel Expert";
                travelStage = 4;
            }
            else if (travelLog >= 50 && travelLog < 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFive.png");
                a9Txt.Text = "Travel Master";
                travelStage = 5;
            }
            else if (travelLog >= 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelSix.png");
                a9Txt.Text = "Travel Legend";
                travelStage = 6;
            }

            if (wasteLog > 0 && wasteLog < 5)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteOne.png");
                a10Txt.Text = "Waste Novice";
                wasteStage = 1;
            }
            else if (wasteLog >= 5 && wasteLog < 10)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteTwo.png");
                a10Txt.Text = "Waste Apprentice";
                wasteStage = 2;
            }
            else if (wasteLog >= 10 && wasteLog < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteThree.png");
                a10Txt.Text = "Waste Adept";
                wasteStage = 3;
            }
            else if (wasteLog >= 25 && wasteLog < 50)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFour.png");
                a10Txt.Text = "Waste Expert";
                wasteStage = 4;
            }
            else if (wasteLog >= 50 && wasteLog < 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFive.png");
                a10Txt.Text = "Waste Master";
                wasteStage = 5;
            }
            else if (wasteLog >= 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteSix.png");
                a10Txt.Text = "Waste Legend";
                wasteStage = 6;
            }

            if (waterLog > 0 && waterLog < 5)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterOne.png");
                a11Txt.Text = "Water Novice";
                waterStage = 1;
            }
            else if (waterLog >= 5 && waterLog < 10)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterTwo.png");
                a11Txt.Text = "Water Apprentice";
                waterStage = 2;
            }
            else if (waterLog >= 10 && waterLog < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterThree.png");
                a11Txt.Text = "Water Adept";
                waterStage = 3;
            }
            else if (waterLog >= 25 && waterLog < 50)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFour.png");
                a11Txt.Text = "Water Expert";
                waterStage = 4;
            }
            else if (waterLog >= 50 && waterLog < 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFive.png");
                a11Txt.Text = "Water Master";
                waterStage = 5;
            }
            else if (waterLog >= 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterSix.png");
                a11Txt.Text = "Water Legend";
                waterStage = 6;
            }

            if (workLog > 0 && workLog < 5)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workOne.png");
                a12Txt.Text = "Work Novice";
                workStage = 1;
            }
            else if (workLog >= 5 && workLog < 10)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workTwo.png");
                a12Txt.Text = "Work Apprentice";
                workStage = 2;
            }
            else if (workLog >= 10 && workLog < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workThree.png");
                a12Txt.Text = "Work Adept";
                workStage = 3;
            }
            else if (workLog >= 25 && workLog < 50)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFour.png");
                a12Txt.Text = "Work Expert";
                workStage = 4;
            }
            else if (workLog >= 50 && workLog < 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFive.png");
                a12Txt.Text = "Work Master";
                workStage = 5;
            }
            else if (workLog >= 100)
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