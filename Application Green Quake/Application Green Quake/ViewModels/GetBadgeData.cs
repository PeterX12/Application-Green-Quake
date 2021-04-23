using System;
using System.Collections.Generic;
using System.Text;
using Android.Bluetooth;
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetBadgeData
    {
        IAuth auth;
        public static int advancedLog = 0;
        public static int habitsLog = 0;
        public static int communityLog = 0;
        public static int energyLog = 0;
        public static int foodDrinkLog = 0;
        public static int homeLog = 0;
        public static int outdoorsLog = 0;
        public static int shoppingLog = 0;
        public static int travelLog = 0;
        public static int wasteLog = 0;
        public static int waterLog = 0;
        public static int workLog = 0;

        public async void SetBadgeData()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                advancedLog = (await firebaseClient
                .Child("AdvancedPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<AdvancedPoints>()).numberOfLogs;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
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
        }
    }
}
