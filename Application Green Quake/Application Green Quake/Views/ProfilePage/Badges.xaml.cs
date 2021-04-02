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
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsOne.png")
                .GetDownloadUrlAsync();

                a1Txt.Text = "Starter";
            }
            else if (habitsLog >= 5 && habitsLog < 10)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (habitsLog >= 10 && habitsLog < 25)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsThree.png")
                .GetDownloadUrlAsync();
            }
            else if (habitsLog >= 25 && habitsLog < 50)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsFour.png")
                .GetDownloadUrlAsync();
            }
            else if (habitsLog >= 50 && habitsLog < 100)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsFive.png")
                .GetDownloadUrlAsync();
            }
            else if (habitsLog >= 100)
            {
                a1.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("habitsSix.png")
                .GetDownloadUrlAsync();
            }

            if (foodDrinkLog > 0 && foodDrinkLog < 5)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("FoodDrink")
                .Child("fDOne.png")
                .GetDownloadUrlAsync();
            }
            else if (foodDrinkLog >= 5 && foodDrinkLog < 10)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("FoodDrink")
                .Child("fDTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (foodDrinkLog >= 10 && foodDrinkLog < 25)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("FoodDrink")
                .Child("fDThree.png")
                .GetDownloadUrlAsync();
            }
            else if (foodDrinkLog >= 25 && foodDrinkLog < 50)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("FoodDrink")
                .Child("fDFour.png")
                .GetDownloadUrlAsync();
            }
            else if (foodDrinkLog >= 50 && foodDrinkLog < 100)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("FoodDrink")
                .Child("fDFive.png")
                .GetDownloadUrlAsync();
            }
            else if (foodDrinkLog >= 100)
            {
                a2.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Habits")
                .Child("fDSix.png")
                .GetDownloadUrlAsync();
            }

            if (energyLog > 0 && energyLog < 5)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energyOne.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Starter";
            }
            else if (energyLog >= 5 && energyLog < 10)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energyTwo.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Novice";
            }
            else if (energyLog >= 10 && energyLog < 25)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energyThree.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Apprentice";
            }
            else if (energyLog >= 25 && energyLog < 50)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energyFour.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Adept";
            }
            else if (energyLog >= 50 && energyLog < 100)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energyFive.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Expert";
            }
            else if (energyLog >= 100)
            {
                a3.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Energy")
                .Child("energySix.png")
                .GetDownloadUrlAsync();

                a3Txt.Text = "Master";
            }

            if (travelLog > 0 && travelLog < 5)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelOne.png")
                .GetDownloadUrlAsync();
            }
            else if (travelLog >= 5 && travelLog < 10)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (travelLog >= 10 && travelLog < 25)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelThree.png")
                .GetDownloadUrlAsync();
            }
            else if (travelLog >= 25 && travelLog < 50)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelFour.png")
                .GetDownloadUrlAsync();
            }
            else if (travelLog >= 50 && travelLog < 100)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelFive.png")
                .GetDownloadUrlAsync();
            }
            else if (travelLog >= 100)
            {
                a4.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Travel")
                .Child("travelSix.png")
                .GetDownloadUrlAsync();
            }

            if (shoppingLog > 0 && shoppingLog < 5)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingOne.png")
                .GetDownloadUrlAsync();
            }
            else if (shoppingLog >= 5 && shoppingLog < 10)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (shoppingLog >= 10 && shoppingLog < 25)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingThree.png")
                .GetDownloadUrlAsync();
            }
            else if (shoppingLog >= 25 && shoppingLog < 50)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingFour.png")
                .GetDownloadUrlAsync();
            }
            else if (shoppingLog >= 50 && shoppingLog < 100)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingFive.png")
                .GetDownloadUrlAsync();
            }
            else if (shoppingLog >= 100)
            {
                a5.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Shopping")
                .Child("shoppingSix.png")
                .GetDownloadUrlAsync();
            }

            if (waterLog > 0 && waterLog < 5)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterOne.png")
                .GetDownloadUrlAsync();
            }
            else if (waterLog >= 5 && waterLog < 10)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (waterLog >= 10 && waterLog < 25)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterThree.png")
                .GetDownloadUrlAsync();
            }
            else if (waterLog >= 25 && waterLog < 50)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterFour.png")
                .GetDownloadUrlAsync();
            }
            else if (waterLog >= 50 && waterLog < 100)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterFive.png")
                .GetDownloadUrlAsync();
            }
            else if (waterLog >= 100)
            {
                a6.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Water")
                .Child("waterSix.png")
                .GetDownloadUrlAsync();
            }

            if (homeLog > 0 && homeLog < 5)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeOne.png")
                .GetDownloadUrlAsync();
            }
            else if (homeLog >= 5 && homeLog < 10)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (homeLog >= 10 && homeLog < 25)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeThree.png")
                .GetDownloadUrlAsync();
            }
            else if (homeLog >= 25 && homeLog < 50)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeFour.png")
                .GetDownloadUrlAsync();
            }
            else if (homeLog >= 50 && homeLog < 100)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeFive.png")
                .GetDownloadUrlAsync();
            }
            else if (homeLog >= 100)
            {
                a7.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("homeSix.png")
                .GetDownloadUrlAsync();
            }

            if (outdoorsLog > 0 && outdoorsLog < 5)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Outdoors")
                .Child("outdoorsOne.png")
                .GetDownloadUrlAsync();
            }
            else if (outdoorsLog >= 5 && outdoorsLog < 10)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("outdoorsTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (outdoorsLog >= 10 && outdoorsLog < 25)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("outdoorsThree.png")
                .GetDownloadUrlAsync();
            }
            else if (outdoorsLog >= 25 && outdoorsLog < 50)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("outdoorsFour.png")
                .GetDownloadUrlAsync();
            }
            else if (outdoorsLog >= 50 && outdoorsLog < 100)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("outdoorsFive.png")
                .GetDownloadUrlAsync();
            }
            else if (outdoorsLog >= 100)
            {
                a8.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Home")
                .Child("outdoorsSix.png")
                .GetDownloadUrlAsync();
            }

            if (communityLog > 0 && communityLog < 5)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communityOne.png")
                .GetDownloadUrlAsync();
            }
            else if (communityLog >= 5 && communityLog < 10)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communityTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (communityLog >= 10 && communityLog < 25)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communityThree.png")
                .GetDownloadUrlAsync();
            }
            else if (communityLog >= 25 && communityLog < 50)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communityFour.png")
                .GetDownloadUrlAsync();
            }
            else if (communityLog >= 50 && communityLog < 100)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communityFive.png")
                .GetDownloadUrlAsync();
            }
            else if (communityLog >= 100)
            {
                a9.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Community")
                .Child("communitySix.png")
                .GetDownloadUrlAsync();
            }

            if (wasteLog > 0 && wasteLog < 5)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteOne.png")
                .GetDownloadUrlAsync();
            }
            else if (wasteLog >= 5 && wasteLog < 10)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (wasteLog >= 10 && wasteLog < 25)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteThree.png")
                .GetDownloadUrlAsync();
            }
            else if (wasteLog >= 25 && wasteLog < 50)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteFour.png")
                .GetDownloadUrlAsync();
            }
            else if (wasteLog >= 50 && wasteLog < 100)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteFive.png")
                .GetDownloadUrlAsync();
            }
            else if (wasteLog >= 100)
            {
                a10.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Waste")
                .Child("wasteSix.png")
                .GetDownloadUrlAsync();
            }

            if (workLog > 0 && workLog < 5)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workOne.png")
                .GetDownloadUrlAsync();
            }
            else if (workLog >= 5 && workLog < 10)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (workLog >= 10 && workLog < 25)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workThree.png")
                .GetDownloadUrlAsync();
            }
            else if (workLog >= 25 && workLog < 50)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workFour.png")
                .GetDownloadUrlAsync();
            }
            else if (workLog >= 50 && workLog < 100)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workFive.png")
                .GetDownloadUrlAsync();
            }
            else if (workLog >= 100)
            {
                a11.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Work")
                .Child("workSix.png")
                .GetDownloadUrlAsync();
            }

            if (advancedLog > 0 && advancedLog < 5)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedOne.png")
                .GetDownloadUrlAsync();
            }
            else if (advancedLog >= 5 && advancedLog < 10)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedTwo.png")
                .GetDownloadUrlAsync();
            }
            else if (advancedLog >= 10 && advancedLog < 25)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedThree.png")
                .GetDownloadUrlAsync();
            }
            else if (advancedLog >= 25 && advancedLog < 50)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedFour.png")
                .GetDownloadUrlAsync();
            }
            else if (advancedLog >= 50 && advancedLog < 100)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedFive.png")
                .GetDownloadUrlAsync();
            }
            else if (advancedLog >= 100)
            {
                a12.Source = await new FirebaseStorage("application-green-quake.appspot.com")
                .Child("Badges")
                .Child("Advanced")
                .Child("advancedSix.png")
                .GetDownloadUrlAsync();
            }
        }

        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }

    }
}