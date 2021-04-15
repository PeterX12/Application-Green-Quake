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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
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
                Console.Write(e);
            }

            if (brushingCount >= 5 && brushingCount < 15)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingBronze.png");
                a1Txt.Text = "Brushing Bronze";
            }
            else if (brushingCount >= 15 && brushingCount < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingSilver.png");
                a1Txt.Text = "Brushing Silver";
            }
            else if (brushingCount >= 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingGold.png");
                a1Txt.Text = "Brushing Gold";
            }

            if (fullWasherCount >= 5 && fullWasherCount < 15)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterBronze.png");
                a2Txt.Text = "Dish Washer Bronze";
            }
            else if (fullWasherCount >= 15 && fullWasherCount < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterSilver.png");
                a2Txt.Text = "Dish Washer Silver";
            }
            else if (fullWasherCount >= 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterGold.png");
                a2Txt.Text = "Dish Washer Gold";
            }

            if (showerCount >= 5 && showerCount < 15)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerBronze.png");
                a3Txt.Text = "Shower Bronze";
            }
            else if (showerCount >= 15 && showerCount < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerSilver.png");
                a3Txt.Text = "Shower Silver";
            }
            else if (showerCount >= 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerGold.png");
                a3Txt.Text = "Shower Gold";
            }

            if (timedShowerCount >= 5 && timedShowerCount < 15)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerBronze.png");
                a4Txt.Text = "Timed Shower Bronze";
            }
            else if (timedShowerCount >= 15 && timedShowerCount < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerSilver.png");
                a4Txt.Text = "Timed Shower Silver";
            }
            else if (timedShowerCount >= 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerGold.png");
                a4Txt.Text = "Timed Shower Gold";
            }

            if (offLigtsCount >= 5 && offLigtsCount < 15)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightBronze.png");
                a5Txt.Text = "Off Lights Bronze";
            }
            else if (offLigtsCount >= 15 && offLigtsCount < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightSilver.png");
                a5Txt.Text = "Off Lights Silver";
            }
            else if (offLigtsCount >= 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightGold.png");
                a5Txt.Text = "Off Lights Gold";
            }

            if (matchesCount >= 5 && matchesCount < 15)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchBronze.png");
                a6Txt.Text = "Matches Bronze";
            }
            else if (matchesCount >= 15 && matchesCount < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchSilver.png");
                a6Txt.Text = "Matches Silver";
            }
            else if (matchesCount >= 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchGold.png");
                a6Txt.Text = "Matches Gold";
            }

            if (foodDeliverCount >= 5 && foodDeliverCount < 15)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverBronze.png");
                a7Txt.Text = "Food Delivered Bronze";
            }
            else if (foodDeliverCount >= 15 && foodDeliverCount < 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverSilver.png");
                a7Txt.Text = "Food Delivered Silver";
            }
            else if (foodDeliverCount >= 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverGold.png");
                a7Txt.Text = "Food Delivered Gold";
            }

            if (eatAllCount >= 5 && eatAllCount < 15)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllBronze.png");
                a8Txt.Text = "Eat All Bronze";
            }
            else if (eatAllCount >= 15 && eatAllCount < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllSilver.png");
                a8Txt.Text = "Eat All Silver";
            }
            else if (eatAllCount >= 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllGold.png");
                a8Txt.Text = "Eat All Gold";
            }

            if (saveLeftOversCount >= 5 && saveLeftOversCount < 15)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversBronze.png");
                a9Txt.Text = "Save Leftovers Bronze";
            }
            else if (saveLeftOversCount >= 15 && saveLeftOversCount < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversSilver.png");
                a9Txt.Text = "Save Leftovers Silver";
            }
            else if (saveLeftOversCount >= 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversGold.png");
                a9Txt.Text = "Save Leftovers Gold";
            }

            if (noMeatCount >= 5 && noMeatCount < 15)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatBronze.png");
                a10Txt.Text = "No Meat Bronze";
            }
            else if (noMeatCount >= 15 && noMeatCount < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatSilver.png");
                a10Txt.Text = "No Meat Silver";
            }
            else if (noMeatCount >= 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatGold.png");
                a10Txt.Text = "No Meat Gold";
            }

            if (organicFoodCount >= 5 && organicFoodCount < 15)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicBronze.png");
                a11Txt.Text = "Organic Food Bronze";
            }
            else if (organicFoodCount >= 15 && organicFoodCount < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicSilver.png");
                a11Txt.Text = "Organic Food Silver";
            }
            else if (organicFoodCount >= 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicGold.png");
                a11Txt.Text = "Organic Food Gold";
            }

            if (ownCoffeeCount >= 5 && ownCoffeeCount < 15)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeBronze.png");
                a12Txt.Text = "Own Coffee Bronze";
            }
            else if (ownCoffeeCount >= 15 && ownCoffeeCount < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeSilver.png");
                a12Txt.Text = "Own Coffee Silver";
            }
            else if (ownCoffeeCount >= 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeGold.png");
                a12Txt.Text = "Own Coffee Gold";
            }

            if (reCoffeeMugCount >= 5 && reCoffeeMugCount < 15)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupBronze.png");
                a13Txt.Text = "Reusable Mug Bronze";
            }
            else if (reCoffeeMugCount >= 15 && reCoffeeMugCount < 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupSilver.png");
                a13Txt.Text = "Reusable Mug Silver";
            }
            else if (reCoffeeMugCount >= 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupGold.png");
                a13Txt.Text = "Reusable Mug Gold";
            }

            if (steelStrawCount >= 5 && steelStrawCount < 15)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawBronze.png");
                a14Txt.Text = "Steel Straw Bronze";
            }
            else if (steelStrawCount >= 15 && steelStrawCount < 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawSilver.png");
                a14Txt.Text = "Steel Straw Silver";
            }
            else if (steelStrawCount >= 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawGold.png");
                a14Txt.Text = "Steel Straw Gold";
            }

            if (waterOverFizzyCount >= 5 && waterOverFizzyCount < 15)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterBronze.png");
                a15Txt.Text = "Water Bronze";
            }
            else if (waterOverFizzyCount >= 15 && waterOverFizzyCount < 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterSilver.png");
                a15Txt.Text = "Water Silver";
            }
            else if (waterOverFizzyCount >= 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterGold.png");
                a15Txt.Text = "Water Gold";
            }

            if (fullDryerCount >= 5 && fullDryerCount < 15)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerBronze.png");
                a16Txt.Text = "Dryer Bronze";
            }
            else if (fullDryerCount >= 15 && fullDryerCount < 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerSilver.png");
                a16Txt.Text = "Dryer Silver";
            }
            else if (fullDryerCount >= 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerGold.png");
                a16Txt.Text = "Dryer Gold";
            }

            if (hangDryCount >= 5 && hangDryCount < 15)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangBronze.png");
                a17Txt.Text = "Hang Dry Bronze";
            }
            else if (hangDryCount >= 15 && hangDryCount < 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangSilver.png");
                a17Txt.Text = "Hang Dry Silver";
            }
            else if (hangDryCount >= 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangGold.png");
                a17Txt.Text = "Hang Dry Gold";
            }

            if (microwaveCount >= 5 && microwaveCount < 15)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveBronze.png");
                a18Txt.Text = "Microwave Bronze";
            }
            else if (microwaveCount >= 15 && microwaveCount < 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveSilver.png");
                a18Txt.Text = "Microwave Silver";
            }
            else if (microwaveCount >= 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveGold.png");
                a18Txt.Text = "Microwave Gold";
            }

            if (reBatteriesCount >= 5 && reBatteriesCount < 15)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesBronze.png");
                a19Txt.Text = "Reusable Battereies Bronze";
            }
            else if (reBatteriesCount >= 15 && reBatteriesCount < 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesSilver.png");
                a19Txt.Text = "Reusable Battereies Silver";
            }
            else if (reBatteriesCount >= 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesGold.png");
                a19Txt.Text = "Reusable Battereies Gold";
            }

            if (offSocketCount >= 5 && offSocketCount < 15)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketBronze.png");
                a20Txt.Text = "Socket Off Bronze";
            }
            else if (offSocketCount >= 15 && offSocketCount < 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketSilver.png");
                a20Txt.Text = "Socket Off Silver";
            }
            else if (offSocketCount >= 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketGold.png");
                a20Txt.Text = "Socket Off Gold";
            }

            if (fullWasherCount >= 5 && fullWasherCount < 15)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineBronze.png");
                a21Txt.Text = "Washing Machine Bronze";
            }
            else if (fullWasherCount >= 15 && fullWasherCount < 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineSilver.png");
                a21Txt.Text = "Washing Machine Silver";
            }
            else if (fullWasherCount >= 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineGold.png");
                a21Txt.Text = "Washing Machine Gold";
            }

            if (carpoolCount >= 5 && carpoolCount < 15)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolBronze.png");
                a22Txt.Text = "Carpool Bronze";
            }
            else if (carpoolCount >= 15 && carpoolCount < 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolSilver.png");
                a22Txt.Text = "Carpool Silver";
            }
            else if (carpoolCount >= 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolGold.png");
                a22Txt.Text = "Carpool Gold";
            }

            if (cycleCount >= 5 && cycleCount < 15)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleBronze.png");
                a23Txt.Text = "Cycle Bronze";
            }
            else if (cycleCount >= 15 && cycleCount < 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleSilver.png");
                a23Txt.Text = "Cycle Silver";
            }
            else if (cycleCount >= 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleGold.png");
                a23Txt.Text = "Cycle Gold";
            }

            if (ecoCarCount >= 5 && ecoCarCount < 15)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarBronze.png");
                a24Txt.Text = "Eco Car Bronze";
            }
            else if (ecoCarCount >= 15 && ecoCarCount < 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarSilver.png");
                a24Txt.Text = "Eco Car Silver";
            }
            else if (ecoCarCount >= 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarGold.png");
                a24Txt.Text = "Eco Car Gold";
            }

            if (transportCount >= 5 && transportCount < 15)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbBronze.png");
                a25Txt.Text = "Public Transport Bronze";
            }
            else if (transportCount >= 15 && transportCount < 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbSilver.png");
                a25Txt.Text = "Public Transport Silver";
            }
            else if (transportCount >= 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbGold.png");
                a25Txt.Text = "Public Transport Gold";
            }

            if (walkCount >= 5 && walkCount < 15)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkBronze.png");
                a26Txt.Text = "Walk Bronze";
            }
            else if (walkCount >= 15 && walkCount < 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkSilver.png");
                a26Txt.Text = "Walk Silver";
            }
            else if (walkCount >= 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkGold.png");
                a26Txt.Text = "Walk Gold";
            }

            if (applianceCount >= 5 && applianceCount < 15)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceBronze.png");
                a27Txt.Text = "Eco Appliance Bronze";
            }
            else if (applianceCount >= 15 && applianceCount < 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceSilver.png");
                a27Txt.Text = "Eco Appliance Silver";
            }
            else if (applianceCount >= 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceGold.png");
                a27Txt.Text = "Eco Appliance Gold";
            }

            if (foodCount>= 5 && foodCount < 15)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkBronze.png");
                a28Txt.Text = "Food In Bulk Bronze";
            }
            else if (foodCount >= 15 && foodCount < 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkSilver.png");
                a28Txt.Text = "Food In Bulk Silver";
            }
            else if (foodCount >= 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkGold.png");
                a28Txt.Text = "Food In Bulk Gold";
            }

            if (clothesCount >= 5 && clothesCount < 15)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalBronze.png");
                a29Txt.Text = "Ethical Clothing Bronze";
            }
            else if (clothesCount >= 15 && clothesCount < 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalSilver.png");
                a29Txt.Text = "Ethical Clothing Silver";
            }
            else if (clothesCount >= 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalGold.png");
                a29Txt.Text = "Ethical Clothing Gold";
            }

            if (localCount >= 5 && localCount < 15)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localBronze.png");
                a30Txt.Text = "Buy Local Bronze";
            }
            else if (localCount >= 15 && localCount < 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localSilver.png");
                a30Txt.Text = "Buy Local Silver";
            }
            else if (localCount >= 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localGold.png");
                a30Txt.Text = "Buy Local Gold";
            }

            if (clothNapkinCount >= 5 && clothNapkinCount < 15)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinBronze.png");
                a31Txt.Text = "Napkin Bronze";
            }
            else if (clothNapkinCount >= 15 && clothNapkinCount < 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinSilver.png");
                a31Txt.Text = "Napkin Silver";
            }
            else if (clothNapkinCount >= 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinGold.png");
                a31Txt.Text = "Napkin Gold";
            }

            if (productCount >= 5 && productCount < 15)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productBronze.png");
                a32Txt.Text = "Eco Product Bronze";
            }
            else if (productCount >= 15 && productCount < 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productSilver.png");
                a32Txt.Text = "Eco Product Silver";
            }
            else if (productCount >= 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productGold.png");
                a32Txt.Text = "Eco Product Gold";
            }

            if (reBagCount >= 5 && reBagCount < 15)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagBronze.png");
                a33Txt.Text = "Reusable Bag Bronze";
            }
            else if (reBagCount >= 15 && reBagCount < 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagSilver.png");
                a33Txt.Text = "Reusable Bag Silver";
            }
            else if (reBagCount >= 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagGold.png");
                a33Txt.Text = "Reusable Bag Gold";
            }

            if (looseLeafCount >= 5 && looseLeafCount < 15)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaBronze.png");
                a34Txt.Text = "Loose Leaf Bronze";
            }
            else if (looseLeafCount >= 15 && looseLeafCount < 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaSilver.png");
                a34Txt.Text = "Loose Leaf Silver";
            }
            else if (looseLeafCount >= 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaGold.png");
                a34Txt.Text = "Loose Leaf Gold";
            }

            if (toothbrushCount >= 5 && toothbrushCount < 15)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushBronze.png");
                a35Txt.Text = "Eco Brush Bronze";
            }
            else if (toothbrushCount >= 15 && toothbrushCount < 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushSilver.png");
                a35Txt.Text = "Eco Brush Silver";
            }
            else if (toothbrushCount >= 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushGold.png");
                a35Txt.Text = "Eco Brush Gold";
            }

            if (clothTowelCount >= 5 && clothTowelCount < 15)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelBronze.png");
                a36Txt.Text = "Towel Bronze";
            }
            else if (clothTowelCount >= 15 && clothTowelCount < 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelSilver.png");
                a36Txt.Text = "Towel Silver";
            }
            else if (clothTowelCount >= 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelGold.png");
                a36Txt.Text = "Towel Gold";
            }

            if (reWaterCount >= 5 && reWaterCount < 15)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleBronze.png");
                a37Txt.Text = "Reusable Bottle Bronze";
            }
            else if (reWaterCount >= 15 && reWaterCount < 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleSilver.png");
                a37Txt.Text = "Reusable Bottle Silver";
            }
            else if (reWaterCount >= 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleGold.png");
                a37Txt.Text = "Reusable Bottle Gold";
            }

            if (showerBucketCount >= 5 && showerBucketCount < 15)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketBronze.png");
                a38Txt.Text = "Shower Bucket Bronze";
            }
            else if (showerBucketCount >= 15 && showerBucketCount < 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketSilver.png");
                a38Txt.Text = "Shower Bucket Silver";
            }
            else if (showerBucketCount >= 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketGold.png");
                a38Txt.Text = "Shower Bucket Gold";
            }

            if (airOutCount >= 5 && airOutCount < 15)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airBronze.png");
                a39Txt.Text = "Ait Out Bronze";
            }
            else if (airOutCount >= 15 && airOutCount < 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airSilver.png");
                a39Txt.Text = "Ait Out Silver";
            }
            else if (airOutCount >= 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airGold.png");
                a39Txt.Text = "Ait Out Gold";
            }

            if (toiletFlushCount >= 5 && toiletFlushCount < 15)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushBronze.png");
                a40Txt.Text = "Save Flush Bronze";
            }
            else if (toiletFlushCount >= 15 && toiletFlushCount < 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushSilver.png");
                a40Txt.Text = "Save Flush Silver";
            }
            else if (toiletFlushCount >= 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushGold.png");
                a40Txt.Text = "Save Flush Gold";
            }

            if (nonHarmCount >= 5 && nonHarmCount < 15)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulBronze.png");
                a41Txt.Text = "Non Harmful Bronze";
            }
            else if (nonHarmCount >= 15 && nonHarmCount < 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulSilver.png");
                a41Txt.Text = "Non Harmful Silver";
            }
            else if (nonHarmCount >= 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulGold.png");
                a41Txt.Text = "Non Harmful Gold";
            }

            if (outsideCount >= 5 && outsideCount < 15)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideBronze.png");
                a42Txt.Text = "Go Outside Bronze";
            }
            else if (outsideCount >= 15 && outsideCount < 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideSilver.png");
                a42Txt.Text = "Go Outside Silver";
            }
            else if (outsideCount >= 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideGold.png");
                a42Txt.Text = "Go Outside Gold";
            }

            if (plantIntoHomeCount >= 5 && plantIntoHomeCount < 15)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantBronze.png");
                a43Txt.Text = "Home Plant Bronze";
            }
            else if (plantIntoHomeCount >= 15 && plantIntoHomeCount < 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantSilver.png");
                a43Txt.Text = "Home Plant Silver";
            }
            else if (plantIntoHomeCount >= 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantGold.png");
                a43Txt.Text = "Home Plant Gold";
            }

            if (plantBushCount >= 5 && plantBushCount < 15)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushBronze.png");
                a41Txt.Text = "Bush Planting Bronze";
            }
            else if (plantBushCount >= 15 && plantBushCount < 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushSilver.png");
                a41Txt.Text = "Bush Planting Silver";
            }
            else if (plantBushCount >= 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushGold.png");
                a41Txt.Text = "Bush Planting Gold";
            }

            if (campingCount >= 5 && campingCount < 15)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingBronze.png");
                a45Txt.Text = "Camping Bronze";
            }
            else if (campingCount >= 15 && campingCount < 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingSilver.png");
                a45Txt.Text = "Camping Silver";
            }
            else if (campingCount >= 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingGold.png");
                a45Txt.Text = "Camping Gold";
            }

            if (plantFlowerCount >= 5 && plantFlowerCount < 15)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerBronze.png");
                a46Txt.Text = "Flower Planting Bronze";
            }
            else if (plantFlowerCount >= 15 && plantFlowerCount < 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerSilver.png");
                a46Txt.Text = "Flower Planting Silver";
            }
            else if (plantFlowerCount >= 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerGold.png");
                a46Txt.Text = "Flower Planting Gold";
            }

            if (picnicCount >= 5 && picnicCount < 15)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicBronze.png");
                a47Txt.Text = "Picninc Bronze";
            }
            else if (picnicCount >= 15 && picnicCount < 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicSilver.png");
                a47Txt.Text = "Picninc Silver";
            }
            else if (picnicCount >= 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicGold.png");
                a47Txt.Text = "Picninc Gold";
            }

            if (scoopCount >= 5 && scoopCount < 15)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopBronze.png");
                a48Txt.Text = "Scoop Poop Bronze";
            }
            else if (scoopCount >= 15 && scoopCount < 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopSilver.png");
                a48Txt.Text = "Scoop Poop Silver";
            }
            else if (scoopCount >= 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopGold.png");
                a48Txt.Text = "Scoop Poop Gold";
            }

            if (plantTreeCount >= 5 && plantTreeCount < 15)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeBronze.png");
                a49Txt.Text = "Tree Planting Bronze";
            }
            else if (plantTreeCount >= 15 && plantTreeCount < 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeSilver.png");
                a49Txt.Text = "Tree Planting Silver";
            }
            else if (plantTreeCount >= 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeGold.png");
                a49Txt.Text = "Tree Planting Gold";
            }

            if (communityCount >= 5 && communityCount < 15)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityBronze.png");
                a50Txt.Text = "Community Bronze";
            }
            else if (communityCount >= 15 && communityCount < 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communitySilver.png");
                a50Txt.Text = "Community Silver";
            }
            else if (communityCount >= 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityGold.png");
                a50Txt.Text = "Community Gold";
            }

            if (donateCount >= 5 && donateCount < 15)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateBronze.png");
                a51Txt.Text = "Donations Bronze";
            }
            else if (donateCount >= 15 && donateCount < 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateSilver.png");
                a51Txt.Text = "Donations Silver";
            }
            else if (donateCount >= 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateGold.png");
                a51Txt.Text = "Donations Gold";
            }

            if (bioBinBagsCount >= 5 && bioBinBagsCount < 15)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsBronze.png");
                a52Txt.Text = "Bio Bin Bag Bronze";
            }
            else if (bioBinBagsCount >= 15 && bioBinBagsCount < 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsSilver.png");
                a52Txt.Text = "Bio Bin Bag Silver";
            }
            else if (bioBinBagsCount >= 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsGold.png");
                a52Txt.Text = "Bio Bin Bag Gold";
            }

            if (billsCount >= 5 && billsCount < 15)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsBronze.png");
                a53Txt.Text = "Online Bills Bronze";
            }
            else if (billsCount >= 15 && billsCount < 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsSilver.png");
                a53Txt.Text = "Online Bills Silver";
            }
            else if (billsCount >= 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsGold.png");
                a53Txt.Text = "Online Bills Gold";
            }

            if (recyclingBinCount >= 5 && recyclingBinCount < 15)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binBronze.png");
                a54Txt.Text = "Recycling Bronze";
            }
            else if (recyclingBinCount >= 15 && recyclingBinCount < 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binSilver.png");
                a54Txt.Text = "Recycling Silver";
            }
            else if (recyclingBinCount >= 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binGold.png");
                a54Txt.Text = "Recycling Gold";
            }

            if (compostCount >= 5 && compostCount < 15)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostBronze.png");
                a55Txt.Text = "Composting Bronze";
            }
            else if (compostCount >= 15 && compostCount < 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostSilver.png");
                a55Txt.Text = "Composting Silver";
            }
            else if (compostCount >= 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostGold.png");
                a55Txt.Text = "Composting Gold";
            }

            if (offElectronicsCount >= 5 && offElectronicsCount < 15)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offBronze.png");
                a56Txt.Text = "Electonics Off Bronze";
            }
            else if (offElectronicsCount >= 15 && offElectronicsCount < 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offSilver.png");
                a56Txt.Text = "Electonics Off Silver";
            }
            else if (offElectronicsCount >= 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offGold.png");
                a56Txt.Text = "Electonics Off Gold";
            }

            if (paperCount >= 5 && paperCount < 15)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperBronze.png");
                a57Txt.Text = " Paper Bronze";
            }
            else if (paperCount >= 15 && paperCount < 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperSilver.png");
                a57Txt.Text = " Paper Silver";
            }
            else if (paperCount >= 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperGold.png");
                a57Txt.Text = " Paper Gold";
            }

            if (fixCount >= 5 && fixCount < 15)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixBronze.png");
                a58Txt.Text = "Fixed Bronze";
            }
            else if (fixCount >= 15 && fixCount < 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixSilver.png");
                a58Txt.Text = "Fixed Silver";
            }
            else if (fixCount >= 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixGold.png");
                a58Txt.Text = "Fixed Gold";
            }

            if (efficientThermostatCount >= 1)
            {
                a59.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.thermostat.png");
                a59Txt.Text = "Efficient Thermostat Set";
            }

            if (insulateWaterCount >= 1)
            {
                a60.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.waterTank.png");
                a60Txt.Text = "Insualted Water Tank";
            }

            if (isolateHomeCount >= 1)
            {
                a61.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.isolateHome.png");
                a61Txt.Text = "Insualted Home";
            }

            if (ledLightBulbCount >= 1)
            {
                a62.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.ledBulb.png");
                a62Txt.Text = "Led Lights Installed";
            }

            if (fridgeCount >= 1)
            {
                a63.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.turnDownFridge.png");
                a63Txt.Text = "Turnt Down The Fridge";
            }

            if (draftSealCount >= 1)
            {
                a64.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDraft.png");
                a64Txt.Text = "Dafts Sealed";
            }

            if (ductSealCount >= 1)
            {
                a65.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDuct.png");
                a65Txt.Text = "Ducts Sealed";
            }

            if (solarPanelCount >= 1)
            {
                a66.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.solar.png");
                a66Txt.Text = "Installed Solar Panel";
            }

            if (reusableCount >= 1)
            {
                a67.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reWaterBottle.png");
                a67Txt.Text = "Purchased Reusable Bottle";
            }

            if (reBatCount >= 1)
            {
                a68.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reBatteries.png");
                a68Txt.Text = "Purchased Rusable Batteries";
            }

            if (cisternCount >= 1)
            {
                a69.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.Cistern.png");
                a69Txt.Text = "Cistern Displacement System Installed";
            }

            if (rainBarrelCount >= 1)
            {
                a70.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.rainBarrel.png");
                a70Txt.Text = "Rain Barell Set Up";
            }

            if (wSShowerHeadCount >= 1)
            {
                a71.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.showerHead.png");
                a71Txt.Text = "Water Saving Shower Head Installed";
            }

            if (fruitGardenCount >= 1)
            {
                a72.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.fruit.png");
                a72Txt.Text = "Fruit Garden Set Up";
            }

            if (herbGardenCount >= 1)
            {
                a73.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.herb.png");
                a73Txt.Text = "Herb Garden Set Up";
            }

            if (vegetableGardenCount >= 1)
            {
                a74.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.veg.png");
                a74Txt.Text = "Vegetable Garden Set Up";
            }

            if (birdFeederCount >= 1)
            {
                a75.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.birdFeeder.png");
                a75Txt.Text = "Bird Feeder Set Up";
            }

            if (createGroupCount >= 1)
            {
                a76.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.create.png");
                a76Txt.Text = "Community Set Up";
            }

            if (groupCount >= 1)
            {
                a77.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.join.png");
                a77Txt.Text = "Joined A Community";
            }

            if (shareCount >= 1)
            {
                a78.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.share.png");
                a78Txt.Text = "App Shared";
            }

            if (awarenessCount >= 1)
            {
                a79.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.spread.png");
                a79Txt.Text = "Awereness Spread";
            }

            if (setUpRecyclingBinCount >= 1)
            {
                a80.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Waste.bins.png");
                a80Txt.Text = "Recycling Bins Set Up";
            }

            if (remoteWorkCount >= 1)
            {
                a81.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Work.remote.png");
                a81Txt.Text = "Working Remotely";
            }
        }
    }
}