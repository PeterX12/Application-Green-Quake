using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
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

            }

            if (habitsLog > 0 && habitsLog < 5)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsOne.png");
            }
            else if (habitsLog >= 5 && habitsLog < 10)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsTwo.png");
            }
            else if (habitsLog >= 10 && habitsLog < 25)
            {
                a1.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Habits.habitsThree.png");
            }
            else if (habitsLog >= 25 && habitsLog < 50)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFour.png");
            }
            else if (habitsLog >= 50 && habitsLog < 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFive.png");
            }
            else if (habitsLog >= 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsSix.png");
            }


            if (advancedLog > 0 && advancedLog < 5)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedOne.png");
            }
            else if (advancedLog >= 5 && advancedLog < 10)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedTwo.png");
            }
            else if (advancedLog >= 10 && advancedLog < 25)
            {
                a2.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Advanced.advancedThree.png");
            }
            else if (advancedLog >= 25 && advancedLog < 50)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFour.png");
            }
            else if (advancedLog >= 50 && advancedLog < 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFive.png");
            }
            else if (advancedLog >= 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedSix.png");
            }

            if (communityLog > 0 && communityLog < 5)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityOne.png");
            }
            else if (communityLog >= 5 && communityLog < 10)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityTwo.png");
            }
            else if (communityLog >= 10 && communityLog < 25)
            {
                a3.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Community.communityThree.png");
            }
            else if (communityLog >= 25 && communityLog < 50)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFour.png");
            }
            else if (communityLog >= 50 && communityLog < 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFive.png");
            }
            else if (communityLog >= 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communitySix.png");
            }

            if (energyLog > 0 && energyLog < 5)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyOne.png");
            }
            else if (energyLog >= 5 && energyLog < 10)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyTwo.png");
            }
            else if (energyLog >= 10 && energyLog < 25)
            {
                a4.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Energy.energyThree.png");
            }
            else if (energyLog >= 25 && energyLog < 50)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFour.png");
            }
            else if (energyLog >= 50 && energyLog < 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFive.png");
            }
            else if (energyLog >= 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energySix.png");
            }

            if (foodDrinkLog > 0 && foodDrinkLog < 5)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDOne.png");
            }
            else if (foodDrinkLog >= 5 && foodDrinkLog < 10)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDTwo.png");
            }
            else if (foodDrinkLog >= 10 && foodDrinkLog < 25)
            {
                a5.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.FD.fDThree.png");
            }
            else if (foodDrinkLog >= 25 && foodDrinkLog < 50)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFour.png");
            }
            else if (foodDrinkLog >= 50 && foodDrinkLog < 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFive.png");
            }
            else if (foodDrinkLog >= 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDSix.png");
            }

            if (homeLog > 0 && homeLog < 5)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeOne.png");
            }
            else if (homeLog >= 5 && homeLog < 10)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeTwo.png");
            }
            else if (homeLog >= 10 && homeLog < 25)
            {
                a6.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Home.homeThree.png");
            }
            else if (homeLog >= 25 && homeLog < 50)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFour.png");
            }
            else if (homeLog >= 50 && homeLog < 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFive.png");
            }
            else if (homeLog >= 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeSix.png");
            }

            if (outdoorsLog > 0 && outdoorsLog < 5)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsOne.png");
            }
            else if (outdoorsLog >= 5 && outdoorsLog < 10)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsTwo.png");
            }
            else if (outdoorsLog >= 10 && outdoorsLog < 25)
            {
                a7.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Outdoors.outdoorsThree.png");
            }
            else if (outdoorsLog >= 25 && outdoorsLog < 50)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFour.png");
            }
            else if (outdoorsLog >= 50 && outdoorsLog < 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFive.png");
            }
            else if (outdoorsLog >= 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsSix.png");
            }

            if (shoppingLog > 0 && shoppingLog < 5)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingOne.png");
            }
            else if (shoppingLog >= 5 && shoppingLog < 10)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingTwo.png");
            }
            else if (shoppingLog >= 10 && shoppingLog < 25)
            {
                a8.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Shopping.shoppingThree.png");
            }
            else if (shoppingLog >= 25 && shoppingLog < 50)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFour.png");
            }
            else if (shoppingLog >= 50 && shoppingLog < 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFive.png");
            }
            else if (shoppingLog >= 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingSix.png");
            }

            if (travelLog > 0 && travelLog < 5)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelOne.png");
            }
            else if (travelLog >= 5 && travelLog < 10)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelTwo.png");
            }
            else if (travelLog >= 10 && travelLog < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelThree.png");
            }
            else if (travelLog >= 25 && travelLog < 50)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFour.png");
            }
            else if (travelLog >= 50 && travelLog < 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFive.png");
            }
            else if (travelLog >= 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelSix.png");
            }

            if (wasteLog > 0 && wasteLog < 5)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteOne.png");
            }
            else if (wasteLog >= 5 && wasteLog < 10)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteTwo.png");
            }
            else if (wasteLog >= 10 && wasteLog < 25)
            {
                a10.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Waste.wasteThree.png");
            }
            else if (wasteLog >= 25 && wasteLog < 50)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFour.png");
            }
            else if (wasteLog >= 50 && wasteLog < 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFive.png");
            }
            else if (wasteLog >= 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteSix.png");
            }

            if (waterLog > 0 && waterLog < 5)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterOne.png");
            }
            else if (waterLog >= 5 && waterLog < 10)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterTwo.png");
            }
            else if (waterLog >= 10 && waterLog < 25)
            {
                a11.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Water.waterThree.png");
            }
            else if (waterLog >= 25 && waterLog < 50)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFour.png");
            }
            else if (waterLog >= 50 && waterLog < 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFive.png");
            }
            else if (waterLog >= 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterSix.png");
            }

            if (workLog > 0 && workLog < 5)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workOne.png");
            }
            else if (workLog >= 5 && workLog < 10)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workTwo.png");
            }
            else if (workLog >= 10 && workLog < 25)
            {
                a12.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Work.workThree.png");
            }
            else if (workLog >= 25 && workLog < 50)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFour.png");
            }
            else if (workLog >= 50 && workLog < 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFive.png");
            }
            else if (workLog >= 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workSix.png");
            }
        }

        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }

    }
}