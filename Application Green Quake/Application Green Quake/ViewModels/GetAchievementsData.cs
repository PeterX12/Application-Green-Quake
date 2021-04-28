/*! \mainpage The GetAchievementsData ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the GetAchievementsData ViewModel Class. It gets data that is needed for Achievements from firebase.
 */
using System;
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class GetAchievementsData
    {
        IAuth auth;
        public static int fixCount = 0;
        public static int wSShowerHeadCount = 0;
        public static int waterOverFizzyCount = 0;
        public static int createGroupCount = 0;
        public static int communityCount = 0;
        public static int donateCount = 0;
        public static int groupCount = 0;
        public static int shareCount = 0;
        public static int awarenessCount = 0;
        public static int fullDryerCount = 0;
        public static int insulateWaterCount = 0;
        public static int efficientThermostatCount = 0;
        public static int isolateHomeCount = 0;
        public static int ledLightBulbCount = 0;
        public static int microwaveCount = 0;
        public static int offSocketCount = 0;
        public static int reBatteriesCount = 0;
        public static int reBatCount = 0;
        public static int fridgeCount = 0;
        public static int draftSealCount = 0;
        public static int ductSealCount = 0;
        public static int solarPanelCount = 0;
        public static int eatAllCount = 0;
        public static int foodDeliverCount = 0;
        public static int noMeatCount = 0;
        public static int ownCoffeeCount = 0;
        public static int reCoffeeMugCount = 0;
        public static int saveLeftOversCount = 0;
        public static int steelStrawCount = 0;
        public static int brushingCount = 0;
        public static int fullWasherCount = 0;
        public static int showerCount = 0;
        public static int timedShowerCount = 0;
        public static int offLigtsCount = 0;
        public static int matchesCount = 0;
        public static int airOutCount = 0;
        public static int nonHarmCount = 0;
        public static int outsideCount = 0;
        public static int plantIntoHomeCount = 0;
        public static int toiletFlushCount = 0;
        public static int campingCount = 0;
        public static int picnicCount = 0;
        public static int plantBushCount = 0;
        public static int plantFlowerCount = 0;
        public static int plantTreeCount = 0;
        public static int scoopCount = 0;
        public static int fruitGardenCount = 0;
        public static int herbGardenCount = 0;
        public static int vegetableGardenCount = 0;
        public static int birdFeederCount = 0;
        public static int clothNapkinCount = 0;
        public static int clothTowelCount = 0;
        public static int applianceCount = 0;
        public static int productCount = 0;
        public static int toothbrushCount = 0;
        public static int clothesCount = 0;
        public static int localCount = 0;
        public static int looseLeafCount = 0;
        public static int organicFoodCount = 0;
        public static int reusableCount = 0;
        public static int reBagCount = 0;
        public static int carpoolCount = 0;
        public static int cycleCount = 0;
        public static int ecoCarCount = 0;
        public static int transportCount = 0;
        public static int walkCount = 0;
        public static int billsCount = 0;
        public static int compostCount = 0;
        public static int setUpRecyclingBinCount = 0;
        public static int bioBinBagsCount = 0;
        public static int recyclingBinCount = 0;
        public static int cisternCount = 0;
        public static int rainBarrelCount = 0;
        public static int reWaterCount = 0;
        public static int showerBucketCount = 0;
        public static int paperCount = 0;
        public static int offElectronicsCount = 0;
        public static int remoteWorkCount = 0;
        public static int hangDryCount = 0;
        public static int foodCount = 0;

        /**
         * This function sets the data that is needed for the Achievements Screen
        */
        public async void SetAchievementsData()
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
        }
    }
}
