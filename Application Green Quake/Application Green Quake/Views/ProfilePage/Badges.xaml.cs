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
            }
            else if (habitsLog >= 5 && habitsLog < 10)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsTwo.png");
                a1Txt.Text = "Habits Apprentice";
            }
            else if (habitsLog >= 10 && habitsLog < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsThree.png");
                a1Txt.Text = "Habits Adept";
            }
            else if (habitsLog >= 25 && habitsLog < 50)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFour.png");
                a1Txt.Text = "Habits Expert";
            }
            else if (habitsLog >= 50 && habitsLog < 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFive.png");
                a1Txt.Text = "Habits Master";
            }
            else if (habitsLog >= 100)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsSix.png");
                a1Txt.Text = "Habits Legend";
            }


            if (advancedLog > 0 && advancedLog < 5)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedOne.png");
                a2Txt.Text = "Advanced Novice";
            }
            else if (advancedLog >= 5 && advancedLog < 10)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedTwo.png");
                a2Txt.Text = "Advanced Apprentice";
            }
            else if (advancedLog >= 10 && advancedLog < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedThree.png");
                a2Txt.Text = "Advanced Adept";
            }
            else if (advancedLog >= 25 && advancedLog < 50)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFour.png");
                a2Txt.Text = "Advanced Expert";
            }
            else if (advancedLog >= 50 && advancedLog < 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFive.png");
                a2Txt.Text = "Advanced Master";
            }
            else if (advancedLog >= 100)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedSix.png");
                a2Txt.Text = "Advanced Legend";
            }

            if (communityLog > 0 && communityLog < 5)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityOne.png");
                a3Txt.Text = "Community Novice";
            }
            else if (communityLog >= 5 && communityLog < 10)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityTwo.png");
                a3Txt.Text = "Community Apprentice";
            }
            else if (communityLog >= 10 && communityLog < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityThree.png");
                a3Txt.Text = "Community Adept";
            }
            else if (communityLog >= 25 && communityLog < 50)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFour.png");
                a3Txt.Text = "Community Expert";
            }
            else if (communityLog >= 50 && communityLog < 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFive.png");
                a3Txt.Text = "Community Master";
            }
            else if (communityLog >= 100)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communitySix.png");
                a3Txt.Text = "Community Legend";
            }

            if (energyLog > 0 && energyLog < 5)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyOne.png");
                a4Txt.Text = "Energy Novice";
            }
            else if (energyLog >= 5 && energyLog < 10)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyTwo.png");
                a4Txt.Text = "Energy Apprentice";
            }
            else if (energyLog >= 10 && energyLog < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyThree.png");
                a4Txt.Text = "Energy Adept";
            }
            else if (energyLog >= 25 && energyLog < 50)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFour.png");
                a4Txt.Text = "Energy Expert";
            }
            else if (energyLog >= 50 && energyLog < 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFive.png");
                a4Txt.Text = "Energy Master";
            }
            else if (energyLog >= 100)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energySix.png");
                a4Txt.Text = "Energy Legend";
            }

            if (foodDrinkLog > 0 && foodDrinkLog < 5)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDOne.png");
                a5Txt.Text = "F & D Novice";
            }
            else if (foodDrinkLog >= 5 && foodDrinkLog < 10)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDTwo.png");
                a5Txt.Text = "F & D Apprentice";
            }
            else if (foodDrinkLog >= 10 && foodDrinkLog < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDThree.png");
                a5Txt.Text = "F & D Adept";
            }
            else if (foodDrinkLog >= 25 && foodDrinkLog < 50)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFour.png");
                a5Txt.Text = "F & D Expert";
            }
            else if (foodDrinkLog >= 50 && foodDrinkLog < 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFive.png");
                a5Txt.Text = "F & D Master";
            }
            else if (foodDrinkLog >= 100)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDSix.png");
                a5Txt.Text = "F & D Legend";
            }

            if (homeLog > 0 && homeLog < 5)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeOne.png");
                a6Txt.Text = "Home Novice";
            }
            else if (homeLog >= 5 && homeLog < 10)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeTwo.png");
                a6Txt.Text = "Home Apprentice";
            }
            else if (homeLog >= 10 && homeLog < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeThree.png");
                a6Txt.Text = "Home Adept";
            }
            else if (homeLog >= 25 && homeLog < 50)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFour.png");
                a6Txt.Text = "Home Expert";
            }
            else if (homeLog >= 50 && homeLog < 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFive.png");
                a6Txt.Text = "Home Master";
            }
            else if (homeLog >= 100)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeSix.png");
                a6Txt.Text = "Home Legend";
            }

            if (outdoorsLog > 0 && outdoorsLog < 5)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsOne.png");
                a7Txt.Text = "Outdoors Novice";
            }
            else if (outdoorsLog >= 5 && outdoorsLog < 10)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsTwo.png");
                a7Txt.Text = "Outdoors Apprentice";
            }
            else if (outdoorsLog >= 10 && outdoorsLog < 25)
            {
                a7.Source = ImageSource.FromResource("Applica  tion_Green_Quake.Images.Badges.Outdoors.outdoorsThree.png");
                a7Txt.Text = "Outdoors Adept";
            }
            else if (outdoorsLog >= 25 && outdoorsLog < 50)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFour.png");
                a7Txt.Text = "Outdoors Expert";
            }
            else if (outdoorsLog >= 50 && outdoorsLog < 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFive.png");
                a7Txt.Text = "Outdoors Master";
            }
            else if (outdoorsLog >= 100)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsSix.png");
                a7Txt.Text = "Outdoors Legend";
            }

            if (shoppingLog > 0 && shoppingLog < 5)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingOne.png");
                a8Txt.Text = "Shopping Novice";
            }
            else if (shoppingLog >= 5 && shoppingLog < 10)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingTwo.png");
                a8Txt.Text = "Shopping Apprentice";
            }
            else if (shoppingLog >= 10 && shoppingLog < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingThree.png");
                a8Txt.Text = "Shopping Adept";
            }
            else if (shoppingLog >= 25 && shoppingLog < 50)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFour.png");
                a8Txt.Text = "Shopping Expert";
            }
            else if (shoppingLog >= 50 && shoppingLog < 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFive.png");
                a8Txt.Text = "Shopping Master";
            }
            else if (shoppingLog >= 100)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingSix.png");
                a8Txt.Text = "Shopping Legend";
            }

            if (travelLog > 0 && travelLog < 5)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelOne.png");
                a9Txt.Text = "Travel Novice";
            }
            else if (travelLog >= 5 && travelLog < 10)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelTwo.png");
                a9Txt.Text = "Travel Apprentice";
            }
            else if (travelLog >= 10 && travelLog < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelThree.png");
                a9Txt.Text = "Travel Adept";
            }
            else if (travelLog >= 25 && travelLog < 50)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFour.png");
                a9Txt.Text = "Travel Expert";
            }
            else if (travelLog >= 50 && travelLog < 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFive.png");
                a9Txt.Text = "Travel Master";
            }
            else if (travelLog >= 100)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelSix.png");
                a9Txt.Text = "Travel Legend";
            }

            if (wasteLog > 0 && wasteLog < 5)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteOne.png");
                a10Txt.Text = "Waste Novice";
            }
            else if (wasteLog >= 5 && wasteLog < 10)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteTwo.png");
                a10Txt.Text = "Waste Apprentice";
            }
            else if (wasteLog >= 10 && wasteLog < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteThree.png");
                a10Txt.Text = "Waste Adept";
            }
            else if (wasteLog >= 25 && wasteLog < 50)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFour.png");
                a10Txt.Text = "Waste Expert";
            }
            else if (wasteLog >= 50 && wasteLog < 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFive.png");
                a10Txt.Text = "Waste Master";
            }
            else if (wasteLog >= 100)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteSix.png");
                a10Txt.Text = "Waste Legend";
            }

            if (waterLog > 0 && waterLog < 5)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterOne.png");
                a11Txt.Text = "Water Novice";
            }
            else if (waterLog >= 5 && waterLog < 10)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterTwo.png");
                a11Txt.Text = "Water Apprentice";
            }
            else if (waterLog >= 10 && waterLog < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterThree.png");
                a11Txt.Text = "Water Adept";
            }
            else if (waterLog >= 25 && waterLog < 50)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFour.png");
                a11Txt.Text = "Water Expert";
            }
            else if (waterLog >= 50 && waterLog < 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFive.png");
                a11Txt.Text = "Water Master";
            }
            else if (waterLog >= 100)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterSix.png");
                a11Txt.Text = "Water Legend";
            }

            if (workLog > 0 && workLog < 5)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workOne.png");
                a12Txt.Text = "Work Novice";
            }
            else if (workLog >= 5 && workLog < 10)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workTwo.png");
                a12Txt.Text = "Work Apprentice";
            }
            else if (workLog >= 10 && workLog < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workThree.png");
                a12Txt.Text = "Work Adept";
            }
            else if (workLog >= 25 && workLog < 50)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFour.png");
                a12Txt.Text = "Work Expert";
            }
            else if (workLog >= 50 && workLog < 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFive.png");
                a12Txt.Text = "Work Master";
            }
            else if (workLog >= 100)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workSix.png");
                a12Txt.Text = "Work Legend";
            }
        }

        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }

    }
}