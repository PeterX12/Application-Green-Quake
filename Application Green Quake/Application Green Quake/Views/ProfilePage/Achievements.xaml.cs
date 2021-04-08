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
    public partial class Achievements : ContentPage
    {
        IAuth auth;
        private int fixCount = 0;
        private int wSShowerHeadCount = 0;
        private int waterOverFizzyCount = 0;
        private int createGroupCount = 0;
        private int communityCount = 0;
        private int donateCount = 0 ;
        private int groupCount = 0 ;
        private int shareCount = 0;
        private int awarenessCount = 0;
        private int fullDryerCount = 0;
        private int insulateWaterCount = 0;
        private int efficientThermostatCount = 0;
        private int isolateHomeCount = 0;
        private int ledLightBulbCount = 0;
        private int microwaveCount = 0;
        private int offSocketCount = 0;
        private int reBatteriesCount = 0;
        private int reBatCount = 0;
        private int fridgeCount = 0;
        private int draftSealCount = 0;
        private int ductSealCount = 0;
        private int solarPanelCount = 0;
        private int eatAllCount = 0;
        private int foodDeliverCount = 0;
        private int noMeatCount = 0;
        private int ownCoffeeCount = 0;
        private int reCoffeeMugCount = 0;
        private int saveLeftOversCount = 0;
        private int steelStrawCount = 0;
        private int brushingCount = 0;
        private int fullWasherCount = 0;
        private int showerCount = 0;
        private int timedShowerCount = 0;
        private int offLigtsCount = 0;
        private int matchesCount = 0;
        private int airOutCount = 0;
        private int nonHarmCount = 0;
        private int outsideCount = 0;
        private int plantIntoHomeCount = 0;
        private int toiletFlushCount = 0;
        private int campingCount = 0;
        private int picnicCount = 0;
        private int plantBushCount = 0;
        private int plantFlowerCount = 0;
        private int plantTreeCount = 0;
        private int scoopCount = 0;
        private int fruitGardenCount = 0;
        private int herbGardenCount = 0;
        private int vegetableGardenCount = 0;
        private int birdFeederCount = 0;
        private int clothNapkinCount = 0;
        private int clothTowelCount = 0;
        private int applianceCount = 0;
        private int productCount = 0;
        private int toothbrushCount = 0;
        private int clothesCount = 0;
        private int localCount = 0;
        private int looseLeafCount = 0;
        private int organicFoodCount = 0;
        private int reusableCount = 0;
        private int reBagCount = 0;
        private int carpoolCount = 0;
        private int cycleCount = 0;
        private int ecoCarCount = 0;
        private int transportCount = 0;
        private int walkCount = 0;
        private int billsCount = 0;
        private int compostCount = 0;
        private int setUpRecyclingBinCount = 0;
        private int bioBinBagsCount = 0;
        private int recyclingBinCount = 0;
        private int cisternCount = 0;
        private int rainBarrelCount = 0;
        private int reWaterCount = 0;
        private int showerBucketCount = 0;
        private int paperCount = 0;
        private int offElectronicsCount = 0;
        private int remoteWorkCount = 0;
        private int hangDryCount = 0;
        private int foodCount = 0;

        public Achievements()
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
                fixCount = (await firebaseClient
               .Child("AdvancedPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<AdvancedPoints>()).fixCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                createGroupCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).createGroupCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                communityCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).communityCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                donateCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).donateCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                groupCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).groupCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                shareCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).shareCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                awarenessCount = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).awarenessCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                hangDryCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).hangDryCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                fullDryerCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).fullDryerCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                insulateWaterCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                efficientThermostatCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                isolateHomeCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                ledLightBulbCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                microwaveCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).microwaveCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                offSocketCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).offSocketCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reBatteriesCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reBatCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).reBatCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                fridgeCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).fridgeCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                draftSealCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).draftSealCount;
            }
            catch (Exception e)
            {

            }

            try
            {
                ductSealCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).ductSealCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                solarPanelCount = (await firebaseClient
               .Child("EnergyPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<EnergyPoints>()).solarPanelCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                eatAllCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                foodDeliverCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                noMeatCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                ownCoffeeCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reCoffeeMugCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                saveLeftOversCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                steelStrawCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                waterOverFizzyCount = (await firebaseClient
               .Child("FoodAndDrinkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                brushingCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).brushingCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                fullWasherCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).fullWasherCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                showerCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).showerCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                timedShowerCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).timedShowerCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                offLigtsCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).offLigtsCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                matchesCount = (await firebaseClient
               .Child("HabitsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HabitsPoints>()).matchesCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                airOutCount = (await firebaseClient
               .Child("HomePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HomePoints>()).airOutCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                nonHarmCount = (await firebaseClient
               .Child("HomePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HomePoints>()).nonHarmCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                outsideCount = (await firebaseClient
               .Child("HomePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HomePoints>()).outsideCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                plantIntoHomeCount = (await firebaseClient
               .Child("HomePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HomePoints>()).plantIntoHomeCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                toiletFlushCount = (await firebaseClient
               .Child("HomePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<HomePoints>()).toiletFlushCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                campingCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).campingCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                picnicCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).picnicCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                plantBushCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).plantBushCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                plantFlowerCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).plantFlowerCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                plantTreeCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).plantTreeCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                scoopCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).scoopCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                fruitGardenCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).fruitGardenCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                herbGardenCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).herbGardenCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                vegetableGardenCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).vegetableGardenCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                birdFeederCount = (await firebaseClient
               .Child("OutdoorsPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<OutdoorsPoints>()).birdFeederCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                clothNapkinCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                clothTowelCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                applianceCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).applianceCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                productCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).productCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                toothbrushCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                clothesCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).clothesCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                localCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).localCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                looseLeafCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                organicFoodCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reusableCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).reusableCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reBagCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).reBagCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                foodCount = (await firebaseClient
               .Child("ShoppingPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<ShoppingPoints>()).foodCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                carpoolCount = (await firebaseClient
               .Child("TravelPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<TravelPoints>()).carpoolCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                cycleCount = (await firebaseClient
               .Child("TravelPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<TravelPoints>()).cycleCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                ecoCarCount = (await firebaseClient
               .Child("TravelPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<TravelPoints>()).ecoCarCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                transportCount = (await firebaseClient
               .Child("TravelPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<TravelPoints>()).transportCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                walkCount = (await firebaseClient
               .Child("TravelPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<TravelPoints>()).walkCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                billsCount = (await firebaseClient
               .Child("WastePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WastePoints>()).billsCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                compostCount = (await firebaseClient
               .Child("WastePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WastePoints>()).compostCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                setUpRecyclingBinCount = (await firebaseClient
               .Child("WastePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                bioBinBagsCount = (await firebaseClient
               .Child("WastePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WastePoints>()).bioBinBagsCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                recyclingBinCount = (await firebaseClient
               .Child("WastePoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WastePoints>()).recyclingBinCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                cisternCount = (await firebaseClient
               .Child("WaterPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WaterPoints>()).cisternCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                rainBarrelCount = (await firebaseClient
               .Child("WaterPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WaterPoints>()).rainBarrelCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                reWaterCount = (await firebaseClient
               .Child("WaterPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WaterPoints>()).reWaterCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                showerBucketCount = (await firebaseClient
               .Child("WaterPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WaterPoints>()).showerBucketCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                wSShowerHeadCount = (await firebaseClient
               .Child("WaterPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WaterPoints>()).wSShowerHeadCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                paperCount = (await firebaseClient
               .Child("WorkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WorkPoints>()).paperCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                offElectronicsCount = (await firebaseClient
               .Child("WorkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WorkPoints>()).offElectronicsCount;
            }
            catch (Exception e)
            {

            }
            try
            {
                remoteWorkCount = (await firebaseClient
               .Child("WorkPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<WorkPoints>()).remoteWorkCount;
            }
            catch (Exception e)
            {

            }

            if (brushingCount >= 5 && brushingCount < 15)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingBronze.png");
            }
            else if (brushingCount >= 15 && brushingCount < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingSilver.png");
            }
            else if (brushingCount >= 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingGold.png");
            }

            if (fullWasherCount >= 5 && fullWasherCount < 15)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterBronze.png");
            }
            else if (fullWasherCount >= 15 && fullWasherCount < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterSilver.png");
            }
            else if (fullWasherCount >= 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterGold.png");
            }

            if (showerCount >= 5 && showerCount < 15)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerBronze.png");
            }
            else if (showerCount >= 15 && showerCount < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerSilver.png");
            }
            else if (showerCount >= 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerGold.png");
            }

            if (timedShowerCount >= 5 && timedShowerCount < 15)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerBronze.png");
            }
            else if (timedShowerCount >= 15 && timedShowerCount < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerSilver.png");
            }
            else if (timedShowerCount >= 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerGold.png");
            }

            if (offLigtsCount >= 5 && offLigtsCount < 15)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightBronze.png");
            }
            else if (offLigtsCount >= 15 && offLigtsCount < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightSilver.png");
            }
            else if (offLigtsCount >= 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightGold.png");
            }

            if (matchesCount >= 5 && matchesCount < 15)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchBronze.png");
            }
            else if (matchesCount >= 15 && matchesCount < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchSilver.png");
            }
            else if (matchesCount >= 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchGold.png");
            }

            if (foodDeliverCount >= 5 && foodDeliverCount < 15)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverBronze.png");
            }
            else if (foodDeliverCount >= 15 && foodDeliverCount < 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverSilver.png");
            }
            else if (foodDeliverCount >= 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverGold.png");
            }

            if (eatAllCount >= 5 && eatAllCount < 15)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllBronze.png");
            }
            else if (eatAllCount >= 15 && eatAllCount < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllSilver.png");
            }
            else if (eatAllCount >= 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllGold.png");
            }

            if (saveLeftOversCount >= 5 && saveLeftOversCount < 15)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversBronze.png");
            }
            else if (saveLeftOversCount >= 15 && saveLeftOversCount < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversSilver.png");
            }
            else if (saveLeftOversCount >= 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversGold.png");
            }

            if (noMeatCount >= 5 && noMeatCount < 15)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatBronze.png");
            }
            else if (noMeatCount >= 15 && noMeatCount < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatSilver.png");
            }
            else if (noMeatCount >= 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatGold.png");
            }

            if (organicFoodCount >= 5 && organicFoodCount < 15)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicBronze.png");
            }
            else if (organicFoodCount >= 15 && organicFoodCount < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicSilver.png");
            }
            else if (organicFoodCount >= 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicGold.png");
            }

            if (ownCoffeeCount >= 5 && ownCoffeeCount < 15)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeBronze.png");
            }
            else if (ownCoffeeCount >= 15 && ownCoffeeCount < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeSilver.png");
            }
            else if (ownCoffeeCount >= 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeGold.png");
            }

            if (reCoffeeMugCount >= 5 && reCoffeeMugCount < 15)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupBronze.png");
            }
            else if (reCoffeeMugCount >= 15 && reCoffeeMugCount < 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupSilver.png");
            }
            else if (reCoffeeMugCount >= 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupGold.png");
            }

            if (steelStrawCount >= 5 && steelStrawCount < 15)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawBronze.png");
            }
            else if (steelStrawCount >= 15 && steelStrawCount < 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawSilver.png");
            }
            else if (steelStrawCount >= 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawGold.png");
            }

            if (waterOverFizzyCount >= 5 && waterOverFizzyCount < 15)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterBronze.png");
            }
            else if (waterOverFizzyCount >= 15 && waterOverFizzyCount < 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterSilver.png");
            }
            else if (waterOverFizzyCount >= 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterGold.png");
            }

            if (fullDryerCount >= 5 && fullDryerCount < 15)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerBronze.png");
            }
            else if (fullDryerCount >= 15 && fullDryerCount < 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerSilver.png");
            }
            else if (fullDryerCount >= 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerGold.png");
            }

            if (hangDryCount >= 5 && hangDryCount < 15)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangBronze.png");
            }
            else if (hangDryCount >= 15 && hangDryCount < 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangSilver.png");
            }
            else if (hangDryCount >= 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangGold.png");
            }

            if (microwaveCount >= 5 && microwaveCount < 15)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveBronze.png");
            }
            else if (microwaveCount >= 15 && microwaveCount < 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveSilver.png");
            }
            else if (microwaveCount >= 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveGold.png");
            }

            if (reBatteriesCount >= 5 && reBatteriesCount < 15)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesBronze.png");
            }
            else if (reBatteriesCount >= 15 && reBatteriesCount < 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesSilver.png");
            }
            else if (reBatteriesCount >= 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesGold.png");
            }

            if (offSocketCount >= 5 && offSocketCount < 15)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketBronze.png");
            }
            else if (offSocketCount >= 15 && offSocketCount < 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketSilver.png");
            }
            else if (offSocketCount >= 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketGold.png");
            }

            if (fullWasherCount >= 5 && fullWasherCount < 15)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineBronze.png");
            }
            else if (fullWasherCount >= 15 && fullWasherCount < 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineSilver.png");
            }
            else if (fullWasherCount >= 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineGold.png");
            }

            if (carpoolCount >= 5 && carpoolCount < 15)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolBronze.png");
            }
            else if (carpoolCount >= 15 && carpoolCount < 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolSilver.png");
            }
            else if (carpoolCount >= 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolGold.png");
            }

            if (cycleCount >= 5 && cycleCount < 15)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleBronze.png");
            }
            else if (cycleCount >= 15 && cycleCount < 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleSilver.png");
            }
            else if (cycleCount >= 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleGold.png");
            }

            if (ecoCarCount >= 5 && ecoCarCount < 15)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarBronze.png");
            }
            else if (ecoCarCount >= 15 && ecoCarCount < 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarSilver.png");
            }
            else if (ecoCarCount >= 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarGold.png");
            }

            if (transportCount >= 5 && transportCount < 15)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbBronze.png");
            }
            else if (transportCount >= 15 && transportCount < 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbSilver.png");
            }
            else if (transportCount >= 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbGold.png");
            }

            if (walkCount >= 5 && walkCount < 15)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkBronze.png");
            }
            else if (walkCount >= 15 && walkCount < 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkSilver.png");
            }
            else if (walkCount >= 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkGold.png");
            }

            if (applianceCount >= 5 && applianceCount < 15)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceBronze.png");
            }
            else if (applianceCount >= 15 && applianceCount < 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceSilver.png");
            }
            else if (applianceCount >= 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceGold.png");
            }

            if (foodCount>= 5 && foodCount < 15)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkBronze.png");
            }
            else if (foodCount >= 15 && foodCount < 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkSilver.png");
            }
            else if (foodCount >= 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkGold.png");
            }

            if (clothesCount >= 5 && clothesCount < 15)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalBronze.png");
            }
            else if (clothesCount >= 15 && clothesCount < 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalSilver.png");
            }
            else if (clothesCount >= 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalGold.png");
            }

            if (localCount >= 5 && localCount < 15)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localBronze.png");
            }
            else if (localCount >= 15 && localCount < 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localSilver.png");
            }
            else if (localCount >= 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localGold.png");
            }

            if (clothNapkinCount >= 5 && clothNapkinCount < 15)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinBronze.png");
            }
            else if (clothNapkinCount >= 15 && clothNapkinCount < 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinSilver.png");
            }
            else if (clothNapkinCount >= 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinGold.png");
            }

            if (productCount >= 5 && productCount < 15)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productBronze.png");
            }
            else if (productCount >= 15 && productCount < 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productSilver.png");
            }
            else if (productCount >= 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productGold.png");
            }

            if (reBagCount >= 5 && reBagCount < 15)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagBronze.png");
            }
            else if (reBagCount >= 15 && reBagCount < 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagSilver.png");
            }
            else if (reBagCount >= 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagGold.png");
            }

            if (looseLeafCount >= 5 && looseLeafCount < 15)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaBronze.png");
            }
            else if (looseLeafCount >= 15 && looseLeafCount < 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaSilver.png");
            }
            else if (looseLeafCount >= 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaGold.png");
            }

            if (toothbrushCount >= 5 && toothbrushCount < 15)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushBronze.png");
            }
            else if (toothbrushCount >= 15 && toothbrushCount < 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushSilver.png");
            }
            else if (toothbrushCount >= 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushGold.png");
            }

            if (clothTowelCount >= 5 && clothTowelCount < 15)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelBronze.png");
            }
            else if (clothTowelCount >= 15 && clothTowelCount < 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelSilver.png");
            }
            else if (clothTowelCount >= 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelGold.png");
            }

            if (reWaterCount >= 5 && reWaterCount < 15)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleBronze.png");
            }
            else if (reWaterCount >= 15 && reWaterCount < 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleSilver.png");
            }
            else if (reWaterCount >= 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleGold.png");
            }

            if (showerBucketCount >= 5 && showerBucketCount < 15)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketBronze.png");
            }
            else if (showerBucketCount >= 15 && showerBucketCount < 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketSilver.png");
            }
            else if (showerBucketCount >= 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketGold.png");
            }

            if (airOutCount >= 5 && airOutCount < 15)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airBronze.png");
            }
            else if (airOutCount >= 15 && airOutCount < 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airSilver.png");
            }
            else if (airOutCount >= 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airGold.png");
            }

            if (toiletFlushCount >= 5 && toiletFlushCount < 15)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushBronze.png");
            }
            else if (toiletFlushCount >= 15 && toiletFlushCount < 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushSilver.png");
            }
            else if (toiletFlushCount >= 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushGold.png");
            }

            if (nonHarmCount >= 5 && nonHarmCount < 15)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulBronze.png");
            }
            else if (nonHarmCount >= 15 && nonHarmCount < 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulSilver.png");
            }
            else if (nonHarmCount >= 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulGold.png");
            }

            if (outsideCount >= 5 && outsideCount < 15)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideBronze.png");
            }
            else if (outsideCount >= 15 && outsideCount < 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideSilver.png");
            }
            else if (outsideCount >= 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideGold.png");
            }

            if (plantIntoHomeCount >= 5 && plantIntoHomeCount < 15)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantBronze.png");
            }
            else if (plantIntoHomeCount >= 15 && plantIntoHomeCount < 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantSilver.png");
            }
            else if (plantIntoHomeCount >= 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantGold.png");
            }

            if (plantBushCount >= 5 && plantBushCount < 15)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushBronze.png");
            }
            else if (plantBushCount >= 15 && plantBushCount < 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushSilver.png");
            }
            else if (plantBushCount >= 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushGold.png");
            }

            if (campingCount >= 5 && campingCount < 15)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingBronze.png");
            }
            else if (campingCount >= 15 && campingCount < 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingSilver.png");
            }
            else if (campingCount >= 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingGold.png");
            }

            if (plantFlowerCount >= 5 && plantFlowerCount < 15)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerBronze.png");
            }
            else if (plantFlowerCount >= 15 && plantFlowerCount < 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerSilver.png");
            }
            else if (plantFlowerCount >= 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerGold.png");
            }

            if (picnicCount >= 5 && picnicCount < 15)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicBronze.png");
            }
            else if (picnicCount >= 15 && picnicCount < 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicSilver.png");
            }
            else if (picnicCount >= 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicGold.png");
            }

            if (scoopCount >= 5 && scoopCount < 15)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopBronze.png");
            }
            else if (scoopCount >= 15 && scoopCount < 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopSilver.png");
            }
            else if (scoopCount >= 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopGold.png");
            }

            if (plantTreeCount >= 5 && plantTreeCount < 15)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeBronze.png");
            }
            else if (plantTreeCount >= 15 && plantTreeCount < 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeSilver.png");
            }
            else if (plantTreeCount >= 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeGold.png");
            }

            if (communityCount >= 5 && communityCount < 15)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityBronze.png");
            }
            else if (communityCount >= 15 && communityCount < 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communitySilver.png");
            }
            else if (communityCount >= 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityGold.png");
            }

            if (donateCount >= 5 && donateCount < 15)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateBronze.png");
            }
            else if (donateCount >= 15 && donateCount < 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateSilver.png");
            }
            else if (donateCount >= 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateGold.png");
            }

            if (bioBinBagsCount >= 5 && bioBinBagsCount < 15)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsBronze.png");
            }
            else if (bioBinBagsCount >= 15 && bioBinBagsCount < 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsSilver.png");
            }
            else if (bioBinBagsCount >= 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsGold.png");
            }

            if (billsCount >= 5 && billsCount < 15)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsBronze.png");
            }
            else if (billsCount >= 15 && billsCount < 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsSilver.png");
            }
            else if (billsCount >= 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsGold.png");
            }

            if (recyclingBinCount >= 5 && recyclingBinCount < 15)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binBronze.png");
            }
            else if (recyclingBinCount >= 15 && recyclingBinCount < 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binSilver.png");
            }
            else if (recyclingBinCount >= 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binGold.png");
            }

            if (compostCount >= 5 && compostCount < 15)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostBronze.png");
            }
            else if (compostCount >= 15 && compostCount < 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostSilver.png");
            }
            else if (compostCount >= 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostGold.png");
            }

            if (offElectronicsCount >= 5 && offElectronicsCount < 15)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offBronze.png");
            }
            else if (offElectronicsCount >= 15 && offElectronicsCount < 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offSilver.png");
            }
            else if (offElectronicsCount >= 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offGold.png");
            }

            if (paperCount >= 5 && paperCount < 15)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperBronze.png");
            }
            else if (paperCount >= 15 && paperCount < 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperSilver.png");
            }
            else if (paperCount >= 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperGold.png");
            }

            if (fixCount >= 5 && fixCount < 15)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixBronze.png");
            }
            else if (fixCount >= 15 && fixCount < 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixSilver.png");
            }
            else if (fixCount >= 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixGold.png");
            }

            if (efficientThermostatCount >= 1)
            {
                a59.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.thermostat.png");
            }

            if (insulateWaterCount >= 1)
            {
                a60.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.waterTank.png");
            }

            if (isolateHomeCount >= 1)
            {
                a61.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.isolateHome.png");
            }

            if (ledLightBulbCount >= 1)
            {
                a62.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.ledBulb.png");
            }

            if (fridgeCount >= 1)
            {
                a63.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.turnDownFridge.png");
            }

            if (draftSealCount >= 1)
            {
                a64.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDraft.png");
            }

            if (ductSealCount >= 1)
            {
                a65.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDuct.png");
            }

            if (solarPanelCount >= 1)
            {
                a66.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.solar.png");
            }

            if (reusableCount >= 1)
            {
                a67.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reWaterBottle.png");
            }

            if (reBatCount >= 1)
            {
                a68.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reBatteries.png");
            }

            if (cisternCount >= 1)
            {
                a69.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.Cistern.png");
            }

            if (rainBarrelCount >= 1)
            {
                a70.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.rainBarrel.png");
            }

            if (wSShowerHeadCount >= 1)
            {
                a71.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.showerHead.png");
            }

            if (fruitGardenCount >= 1)
            {
                a72.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.fruit.png");
            }

            if (herbGardenCount >= 1)
            {
                a73.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.herb.png");
            }

            if (vegetableGardenCount >= 1)
            {
                a74.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.veg.png");
            }

            if (birdFeederCount >= 1)
            {
                a75.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.birdFeeder.png");
            }

            if (createGroupCount >= 1)
            {
                a76.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.create.png");
            }

            if (groupCount >= 1)
            {
                a77.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.join.png");
            }

            if (shareCount >= 1)
            {
                a78.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.share.png");
            }

            if (awarenessCount >= 1)
            {
                a79.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.spread.png");
            }

            if (setUpRecyclingBinCount >= 1)
            {
                a80.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Waste.bins.png");
            }

            if (remoteWorkCount >= 1)
            {
                a81.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Work.remote.png");
            }


        }


        private async void NavigateToBadgePopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BadgePopUp());
        }


    }
}