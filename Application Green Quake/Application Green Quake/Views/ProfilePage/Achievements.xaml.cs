/*! \mainpage The Achievements View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the Achievements View Class. This class is the class that displays all the Achievements on the Achievements page.
 *
 */
using Application_Green_Quake.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Achievements : ContentPage
    {
        IAuth auth;
        
        public Achievements()
        {
            InitializeComponent(); 
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }
        /** This function is called before the page is displayed. It displays the images as the criteria are met
        */
        protected override void OnAppearing()
        {
            if (GetAchievementsData.brushingCount >= 5 && GetAchievementsData.brushingCount < 15)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingBronze.png");
                a1Txt.Text = "Brushing Bronze";
            }
            else if (GetAchievementsData.brushingCount >= 15 && GetAchievementsData.brushingCount < 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingSilver.png");
                a1Txt.Text = "Brushing Silver";
            }
            else if (GetAchievementsData.brushingCount >= 25)
            {
                a1.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.brushingGold.png");
                a1Txt.Text = "Brushing Gold";
            }

            if (GetAchievementsData.fullWasherCount >= 5 && GetAchievementsData.fullWasherCount < 15)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterBronze.png");
                a2Txt.Text = "Dish Washer Bronze";
            }
            else if (GetAchievementsData.fullWasherCount >= 15 && GetAchievementsData.fullWasherCount < 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterSilver.png");
                a2Txt.Text = "Dish Washer Silver";
            }
            else if (GetAchievementsData.fullWasherCount >= 25)
            {
                a2.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.dishwasterGold.png");
                a2Txt.Text = "Dish Washer Gold";
            }

            if (GetAchievementsData.shareCount >= 5 && GetAchievementsData.shareCount < 15)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerBronze.png");
                a3Txt.Text = "Shower Bronze";
            }
            else if (GetAchievementsData.shareCount >= 15 && GetAchievementsData.shareCount < 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerSilver.png");
                a3Txt.Text = "Shower Silver";
            }
            else if (GetAchievementsData.shareCount >= 25)
            {
                a3.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.showerGold.png");
                a3Txt.Text = "Shower Gold";
            }

            if (GetAchievementsData.timedShowerCount >= 5 && GetAchievementsData.timedShowerCount < 15)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerBronze.png");
                a4Txt.Text = "Timed Shower Bronze";
            }
            else if (GetAchievementsData.timedShowerCount >= 15 && GetAchievementsData.timedShowerCount < 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerSilver.png");
                a4Txt.Text = "Timed Shower Silver";
            }
            else if (GetAchievementsData.timedShowerCount >= 25)
            {
                a4.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.timeShowerGold.png");
                a4Txt.Text = "Timed Shower Gold";
            }

            if (GetAchievementsData.offLigtsCount >= 5 && GetAchievementsData.offLigtsCount < 15)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightBronze.png");
                a5Txt.Text = "Off Lights Bronze";
            }
            else if (GetAchievementsData.offLigtsCount >= 15 && GetAchievementsData.offLigtsCount < 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightSilver.png");
                a5Txt.Text = "Off Lights Silver";
            }
            else if (GetAchievementsData.offLigtsCount >= 25)
            {
                a5.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.lightGold.png");
                a5Txt.Text = "Off Lights Gold";
            }

            if (GetAchievementsData.matchesCount >= 5 && GetAchievementsData.matchesCount < 15)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchBronze.png");
                a6Txt.Text = "Matches Bronze";
            }
            else if (GetAchievementsData.matchesCount >= 15 && GetAchievementsData.matchesCount < 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchSilver.png");
                a6Txt.Text = "Matches Silver";
            }
            else if (GetAchievementsData.matchesCount >= 25)
            {
                a6.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Habits.matchGold.png");
                a6Txt.Text = "Matches Gold";
            }

            if (GetAchievementsData.foodDeliverCount >= 5 && GetAchievementsData.foodDeliverCount < 15)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverBronze.png");
                a7Txt.Text = "Food Delivered Bronze";
            }
            else if (GetAchievementsData.foodDeliverCount >= 15 && GetAchievementsData.foodDeliverCount < 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverSilver.png");
                a7Txt.Text = "Food Delivered Silver";
            }
            else if (GetAchievementsData.foodDeliverCount >= 25)
            {
                a7.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.deliverGold.png");
                a7Txt.Text = "Food Delivered Gold";
            }

            if (GetAchievementsData.eatAllCount >= 5 && GetAchievementsData.eatAllCount < 15)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllBronze.png");
                a8Txt.Text = "Eat All Bronze";
            }
            else if (GetAchievementsData.eatAllCount >= 15 && GetAchievementsData.eatAllCount < 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllSilver.png");
                a8Txt.Text = "Eat All Silver";
            }
            else if (GetAchievementsData.eatAllCount >= 25)
            {
                a8.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.eatAllGold.png");
                a8Txt.Text = "Eat All Gold";
            }

            if (GetAchievementsData.saveLeftOversCount >= 5 && GetAchievementsData.saveLeftOversCount < 15)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversBronze.png");
                a9Txt.Text = "Save Leftovers Bronze";
            }
            else if (GetAchievementsData.saveLeftOversCount >= 15 && GetAchievementsData.saveLeftOversCount < 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversSilver.png");
                a9Txt.Text = "Save Leftovers Silver";
            }
            else if (GetAchievementsData.saveLeftOversCount >= 25)
            {
                a9.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.leftoversGold.png");
                a9Txt.Text = "Save Leftovers Gold";
            }

            if (GetAchievementsData.noMeatCount >= 5 && GetAchievementsData.noMeatCount < 15)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatBronze.png");
                a10Txt.Text = "No Meat Bronze";
            }
            else if (GetAchievementsData.noMeatCount >= 15 && GetAchievementsData.noMeatCount < 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatSilver.png");
                a10Txt.Text = "No Meat Silver";
            }
            else if (GetAchievementsData.noMeatCount >= 25)
            {
                a10.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.noMeatGold.png");
                a10Txt.Text = "No Meat Gold";
            }

            if (GetAchievementsData.organicFoodCount >= 5 && GetAchievementsData.organicFoodCount < 15)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicBronze.png");
                a11Txt.Text = "Organic Food Bronze";
            }
            else if (GetAchievementsData.organicFoodCount >= 15 && GetAchievementsData.organicFoodCount < 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicSilver.png");
                a11Txt.Text = "Organic Food Silver";
            }
            else if (GetAchievementsData.organicFoodCount >= 25)
            {
                a11.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.organicGold.png");
                a11Txt.Text = "Organic Food Gold";
            }

            if (GetAchievementsData.ownCoffeeCount >= 5 && GetAchievementsData.ownCoffeeCount < 15)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeBronze.png");
                a12Txt.Text = "Own Coffee Bronze";
            }
            else if (GetAchievementsData.ownCoffeeCount >= 15 && GetAchievementsData.ownCoffeeCount < 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeSilver.png");
                a12Txt.Text = "Own Coffee Silver";
            }
            else if (GetAchievementsData.ownCoffeeCount >= 25)
            {
                a12.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.ownCoffeeGold.png");
                a12Txt.Text = "Own Coffee Gold";
            }

            if (GetAchievementsData.reCoffeeMugCount >= 5 && GetAchievementsData.reCoffeeMugCount < 15)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupBronze.png");
                a13Txt.Text = "Reusable Mug Bronze";
            }
            else if (GetAchievementsData.reCoffeeMugCount >= 15 && GetAchievementsData.reCoffeeMugCount < 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupSilver.png");
                a13Txt.Text = "Reusable Mug Silver";
            }
            else if (GetAchievementsData.reCoffeeMugCount >= 25)
            {
                a13.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.reCupGold.png");
                a13Txt.Text = "Reusable Mug Gold";
            }

            if (GetAchievementsData.steelStrawCount >= 5 && GetAchievementsData.steelStrawCount < 15)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawBronze.png");
                a14Txt.Text = "Steel Straw Bronze";
            }
            else if (GetAchievementsData.steelStrawCount >= 15 && GetAchievementsData.steelStrawCount < 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawSilver.png");
                a14Txt.Text = "Steel Straw Silver";
            }
            else if (GetAchievementsData.steelStrawCount >= 25)
            {
                a14.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.strawGold.png");
                a14Txt.Text = "Steel Straw Gold";
            }

            if (GetAchievementsData.waterOverFizzyCount >= 5 && GetAchievementsData.waterOverFizzyCount < 15)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterBronze.png");
                a15Txt.Text = "Water Bronze";
            }
            else if (GetAchievementsData.waterOverFizzyCount >= 15 && GetAchievementsData.waterOverFizzyCount < 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterSilver.png");
                a15Txt.Text = "Water Silver";
            }
            else if (GetAchievementsData.waterOverFizzyCount >= 25)
            {
                a15.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.FD.waterGold.png");
                a15Txt.Text = "Water Gold";
            }

            if (GetAchievementsData.fullDryerCount >= 5 && GetAchievementsData.fullDryerCount < 15)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerBronze.png");
                a16Txt.Text = "Dryer Bronze";
            }
            else if (GetAchievementsData.fullDryerCount >= 15 && GetAchievementsData.fullDryerCount < 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerSilver.png");
                a16Txt.Text = "Dryer Silver";
            }
            else if (GetAchievementsData.fullDryerCount >= 25)
            {
                a16.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.dryerGold.png");
                a16Txt.Text = "Dryer Gold";
            }

            if (GetAchievementsData.hangDryCount >= 5 && GetAchievementsData.hangDryCount < 15)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangBronze.png");
                a17Txt.Text = "Hang Dry Bronze";
            }
            else if (GetAchievementsData.hangDryCount >= 15 && GetAchievementsData.hangDryCount < 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangSilver.png");
                a17Txt.Text = "Hang Dry Silver";
            }
            else if (GetAchievementsData.hangDryCount >= 25)
            {
                a17.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.hangGold.png");
                a17Txt.Text = "Hang Dry Gold";
            }

            if (GetAchievementsData.microwaveCount >= 5 && GetAchievementsData.microwaveCount < 15)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveBronze.png");
                a18Txt.Text = "Microwave Bronze";
            }
            else if (GetAchievementsData.microwaveCount >= 15 && GetAchievementsData.microwaveCount < 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveSilver.png");
                a18Txt.Text = "Microwave Silver";
            }
            else if (GetAchievementsData.microwaveCount >= 25)
            {
                a18.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.microwaveGold.png");
                a18Txt.Text = "Microwave Gold";
            }

            if (GetAchievementsData.reBatteriesCount >= 5 && GetAchievementsData.reBatteriesCount < 15)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesBronze.png");
                a19Txt.Text = "Reusable Batteries Bronze";
            }
            else if (GetAchievementsData.reBatteriesCount >= 15 && GetAchievementsData.reBatteriesCount < 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesSilver.png");
                a19Txt.Text = "Reusable Batteries Silver";
            }
            else if (GetAchievementsData.reBatteriesCount >= 25)
            {
                a19.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.reBatteriesGold.png");
                a19Txt.Text = "Reusable Batteries Gold";
            }

            if (GetAchievementsData.offSocketCount >= 5 && GetAchievementsData.offSocketCount < 15)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketBronze.png");
                a20Txt.Text = "Socket Off Bronze";
            }
            else if (GetAchievementsData.offSocketCount >= 15 && GetAchievementsData.offSocketCount < 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketSilver.png");
                a20Txt.Text = "Socket Off Silver";
            }
            else if (GetAchievementsData.offSocketCount >= 25)
            {
                a20.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.socketGold.png");
                a20Txt.Text = "Socket Off Gold";
            }

            if (GetAchievementsData.fullWasherCount >= 5 && GetAchievementsData.fullWasherCount < 15)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineBronze.png");
                a21Txt.Text = "Washing Machine Bronze";
            }
            else if (GetAchievementsData.fullWasherCount >= 15 && GetAchievementsData.fullWasherCount < 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineSilver.png");
                a21Txt.Text = "Washing Machine Silver";
            }
            else if (GetAchievementsData.fullWasherCount >= 25)
            {
                a21.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Energy.washingMachineGold.png");
                a21Txt.Text = "Washing Machine Gold";
            }

            if (GetAchievementsData.carpoolCount >= 5 && GetAchievementsData.carpoolCount < 15)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolBronze.png");
                a22Txt.Text = "Carpool Bronze";
            }
            else if (GetAchievementsData.carpoolCount >= 15 && GetAchievementsData.carpoolCount < 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolSilver.png");
                a22Txt.Text = "Carpool Silver";
            }
            else if (GetAchievementsData.carpoolCount >= 25)
            {
                a22.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.carpoolGold.png");
                a22Txt.Text = "Carpool Gold";
            }

            if (GetAchievementsData.cycleCount >= 5 && GetAchievementsData.cycleCount < 15)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleBronze.png");
                a23Txt.Text = "Cycle Bronze";
            }
            else if (GetAchievementsData.cycleCount >= 15 && GetAchievementsData.cycleCount < 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleSilver.png");
                a23Txt.Text = "Cycle Silver";
            }
            else if (GetAchievementsData.cycleCount >= 25)
            {
                a23.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.cycleGold.png");
                a23Txt.Text = "Cycle Gold";
            }

            if (GetAchievementsData.ecoCarCount >= 5 && GetAchievementsData.ecoCarCount < 15)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarBronze.png");
                a24Txt.Text = "Eco Car Bronze";
            }
            else if (GetAchievementsData.ecoCarCount >= 15 && GetAchievementsData.ecoCarCount < 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarSilver.png");
                a24Txt.Text = "Eco Car Silver";
            }
            else if (GetAchievementsData.ecoCarCount >= 25)
            {
                a24.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.eCarGold.png");
                a24Txt.Text = "Eco Car Gold";
            }

            if (GetAchievementsData.transportCount >= 5 && GetAchievementsData.transportCount < 15)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbBronze.png");
                a25Txt.Text = "Public Transport Bronze";
            }
            else if (GetAchievementsData.transportCount >= 15 && GetAchievementsData.transportCount < 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbSilver.png");
                a25Txt.Text = "Public Transport Silver";
            }
            else if (GetAchievementsData.transportCount >= 25)
            {
                a25.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.pbGold.png");
                a25Txt.Text = "Public Transport Gold";
            }

            if (GetAchievementsData.walkCount >= 5 && GetAchievementsData.walkCount < 15)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkBronze.png");
                a26Txt.Text = "Walk Bronze";
            }
            else if (GetAchievementsData.walkCount >= 15 && GetAchievementsData.walkCount < 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkSilver.png");
                a26Txt.Text = "Walk Silver";
            }
            else if (GetAchievementsData.walkCount >= 25)
            {
                a26.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Travel.walkGold.png");
                a26Txt.Text = "Walk Gold";
            }

            if (GetAchievementsData.applianceCount >= 5 && GetAchievementsData.applianceCount < 15)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceBronze.png");
                a27Txt.Text = "Eco Appliance Bronze";
            }
            else if (GetAchievementsData.applianceCount >= 15 && GetAchievementsData.applianceCount < 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceSilver.png");
                a27Txt.Text = "Eco Appliance Silver";
            }
            else if (GetAchievementsData.applianceCount >= 25)
            {
                a27.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.applianceGold.png");
                a27Txt.Text = "Eco Appliance Gold";
            }

            if (GetAchievementsData.foodCount >= 5 && GetAchievementsData.foodCount < 15)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkBronze.png");
                a28Txt.Text = "Food In Bulk Bronze";
            }
            else if (GetAchievementsData.foodCount >= 15 && GetAchievementsData.foodCount < 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkSilver.png");
                a28Txt.Text = "Food In Bulk Silver";
            }
            else if (GetAchievementsData.foodCount >= 25)
            {
                a28.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.bulkGold.png");
                a28Txt.Text = "Food In Bulk Gold";
            }

            if (GetAchievementsData.clothesCount >= 5 && GetAchievementsData.clothesCount < 15)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalBronze.png");
                a29Txt.Text = "Ethical Clothing Bronze";
            }
            else if (GetAchievementsData.clothesCount >= 15 && GetAchievementsData.clothesCount < 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalSilver.png");
                a29Txt.Text = "Ethical Clothing Silver";
            }
            else if (GetAchievementsData.clothesCount >= 25)
            {
                a29.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.ethicalGold.png");
                a29Txt.Text = "Ethical Clothing Gold";
            }

            if (GetAchievementsData.localCount >= 5 && GetAchievementsData.localCount < 15)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localBronze.png");
                a30Txt.Text = "Buy Local Bronze";
            }
            else if (GetAchievementsData.localCount >= 15 && GetAchievementsData.localCount < 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localSilver.png");
                a30Txt.Text = "Buy Local Silver";
            }
            else if (GetAchievementsData.localCount >= 25)
            {
                a30.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.localGold.png");
                a30Txt.Text = "Buy Local Gold";
            }

            if (GetAchievementsData.clothNapkinCount >= 5 && GetAchievementsData.clothNapkinCount < 15)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinBronze.png");
                a31Txt.Text = "Napkin Bronze";
            }
            else if (GetAchievementsData.clothNapkinCount >= 15 && GetAchievementsData.clothNapkinCount < 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinSilver.png");
                a31Txt.Text = "Napkin Silver";
            }
            else if (GetAchievementsData.clothNapkinCount >= 25)
            {
                a31.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.napkinGold.png");
                a31Txt.Text = "Napkin Gold";
            }

            if (GetAchievementsData.productCount >= 5 && GetAchievementsData.productCount < 15)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productBronze.png");
                a32Txt.Text = "Eco Product Bronze";
            }
            else if (GetAchievementsData.productCount >= 15 && GetAchievementsData.productCount < 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productSilver.png");
                a32Txt.Text = "Eco Product Silver";
            }
            else if (GetAchievementsData.productCount >= 25)
            {
                a32.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.productGold.png");
                a32Txt.Text = "Eco Product Gold";
            }

            if (GetAchievementsData.reBagCount >= 5 && GetAchievementsData.reBagCount < 15)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagBronze.png");
                a33Txt.Text = "Reusable Bag Bronze";
            }
            else if (GetAchievementsData.reBagCount >= 15 && GetAchievementsData.reBagCount < 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagSilver.png");
                a33Txt.Text = "Reusable Bag Silver";
            }
            else if (GetAchievementsData.reBagCount >= 25)
            {
                a33.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.reBagGold.png");
                a33Txt.Text = "Reusable Bag Gold";
            }

            if (GetAchievementsData.looseLeafCount >= 5 && GetAchievementsData.looseLeafCount < 15)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaBronze.png");
                a34Txt.Text = "Loose Leaf Bronze";
            }
            else if (GetAchievementsData.looseLeafCount >= 15 && GetAchievementsData.looseLeafCount < 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaSilver.png");
                a34Txt.Text = "Loose Leaf Silver";
            }
            else if (GetAchievementsData.looseLeafCount >= 25)
            {
                a34.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.teaGold.png");
                a34Txt.Text = "Loose Leaf Gold";
            }

            if (GetAchievementsData.toothbrushCount >= 5 && GetAchievementsData.toothbrushCount < 15)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushBronze.png");
                a35Txt.Text = "Eco Brush Bronze";
            }
            else if (GetAchievementsData.toothbrushCount >= 15 && GetAchievementsData.toothbrushCount < 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushSilver.png");
                a35Txt.Text = "Eco Brush Silver";
            }
            else if (GetAchievementsData.toothbrushCount >= 25)
            {
                a35.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.toothbrushGold.png");
                a35Txt.Text = "Eco Brush Gold";
            }

            if (GetAchievementsData.clothTowelCount >= 5 && GetAchievementsData.clothTowelCount < 15)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelBronze.png");
                a36Txt.Text = "Towel Bronze";
            }
            else if (GetAchievementsData.clothTowelCount >= 15 && GetAchievementsData.clothTowelCount < 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelSilver.png");
                a36Txt.Text = "Towel Silver";
            }
            else if (GetAchievementsData.clothTowelCount >= 25)
            {
                a36.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Shopping.towelGold.png");
                a36Txt.Text = "Towel Gold";
            }

            if (GetAchievementsData.reWaterCount >= 5 && GetAchievementsData.reWaterCount < 15)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleBronze.png");
                a37Txt.Text = "Reusable Bottle Bronze";
            }
            else if (GetAchievementsData.reWaterCount >= 15 && GetAchievementsData.reWaterCount < 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleSilver.png");
                a37Txt.Text = "Reusable Bottle Silver";
            }
            else if (GetAchievementsData.reWaterCount >= 25)
            {
                a37.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bottleGold.png");
                a37Txt.Text = "Reusable Bottle Gold";
            }

            if (GetAchievementsData.showerBucketCount >= 5 && GetAchievementsData.showerBucketCount < 15)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketBronze.png");
                a38Txt.Text = "Shower Bucket Bronze";
            }
            else if (GetAchievementsData.showerBucketCount >= 15 && GetAchievementsData.showerBucketCount < 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketSilver.png");
                a38Txt.Text = "Shower Bucket Silver";
            }
            else if (GetAchievementsData.showerBucketCount >= 25)
            {
                a38.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Water.bucketGold.png");
                a38Txt.Text = "Shower Bucket Gold";
            }

            if (GetAchievementsData.airOutCount >= 5 && GetAchievementsData.airOutCount < 15)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airBronze.png");
                a39Txt.Text = "Ait Out Bronze";
            }
            else if (GetAchievementsData.airOutCount >= 15 && GetAchievementsData.airOutCount < 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airSilver.png");
                a39Txt.Text = "Ait Out Silver";
            }
            else if (GetAchievementsData.airOutCount >= 25)
            {
                a39.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.airGold.png");
                a39Txt.Text = "Ait Out Gold";
            }

            if (GetAchievementsData.toiletFlushCount >= 5 && GetAchievementsData.toiletFlushCount < 15)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushBronze.png");
                a40Txt.Text = "Save Flush Bronze";
            }
            else if (GetAchievementsData.toiletFlushCount >= 15 && GetAchievementsData.toiletFlushCount < 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushSilver.png");
                a40Txt.Text = "Save Flush Silver";
            }
            else if (GetAchievementsData.toiletFlushCount >= 25)
            {
                a40.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.flushGold.png");
                a40Txt.Text = "Save Flush Gold";
            }

            if (GetAchievementsData.nonHarmCount >= 5 && GetAchievementsData.nonHarmCount < 15)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulBronze.png");
                a41Txt.Text = "Non Harmful Bronze";
            }
            else if (GetAchievementsData.nonHarmCount >= 15 && GetAchievementsData.nonHarmCount < 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulSilver.png");
                a41Txt.Text = "Non Harmful Silver";
            }
            else if (GetAchievementsData.nonHarmCount >= 25)
            {
                a41.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.nonHarmfulGold.png");
                a41Txt.Text = "Non Harmful Gold";
            }

            if (GetAchievementsData.outsideCount >= 5 && GetAchievementsData.outsideCount < 15)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideBronze.png");
                a42Txt.Text = "Go Outside Bronze";
            }
            else if (GetAchievementsData.outsideCount >= 15 && GetAchievementsData.outsideCount < 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideSilver.png");
                a42Txt.Text = "Go Outside Silver";
            }
            else if (GetAchievementsData.outsideCount >= 25)
            {
                a42.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.outsideGold.png");
                a42Txt.Text = "Go Outside Gold";
            }

            if (GetAchievementsData.plantIntoHomeCount >= 5 && GetAchievementsData.plantIntoHomeCount < 15)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantBronze.png");
                a43Txt.Text = "Home Plant Bronze";
            }
            else if (GetAchievementsData.plantIntoHomeCount >= 15 && GetAchievementsData.plantIntoHomeCount < 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantSilver.png");
                a43Txt.Text = "Home Plant Silver";
            }
            else if (GetAchievementsData.plantIntoHomeCount >= 25)
            {
                a43.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Home.plantGold.png");
                a43Txt.Text = "Home Plant Gold";
            }

            if (GetAchievementsData.plantBushCount >= 5 && GetAchievementsData.plantBushCount < 15)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushBronze.png");
                a41Txt.Text = "Bush Planting Bronze";
            }
            else if (GetAchievementsData.plantBushCount >= 15 && GetAchievementsData.plantBushCount < 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushSilver.png");
                a41Txt.Text = "Bush Planting Silver";
            }
            else if (GetAchievementsData.plantBushCount >= 25)
            {
                a44.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.bushGold.png");
                a41Txt.Text = "Bush Planting Gold";
            }

            if (GetAchievementsData.campingCount >= 5 && GetAchievementsData.campingCount < 15)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingBronze.png");
                a45Txt.Text = "Camping Bronze";
            }
            else if (GetAchievementsData.campingCount >= 15 && GetAchievementsData.campingCount < 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingSilver.png");
                a45Txt.Text = "Camping Silver";
            }
            else if (GetAchievementsData.campingCount >= 25)
            {
                a45.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.campingGold.png");
                a45Txt.Text = "Camping Gold";
            }

            if (GetAchievementsData.plantFlowerCount >= 5 && GetAchievementsData.plantFlowerCount < 15)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerBronze.png");
                a46Txt.Text = "Flower Planting Bronze";
            }
            else if (GetAchievementsData.plantFlowerCount >= 15 && GetAchievementsData.plantFlowerCount < 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerSilver.png");
                a46Txt.Text = "Flower Planting Silver";
            }
            else if (GetAchievementsData.plantFlowerCount >= 25)
            {
                a46.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.flowerGold.png");
                a46Txt.Text = "Flower Planting Gold";
            }

            if (GetAchievementsData.picnicCount >= 5 && GetAchievementsData.picnicCount < 15)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicBronze.png");
                a47Txt.Text = "Picnic Bronze";
            }
            else if (GetAchievementsData.picnicCount >= 15 && GetAchievementsData.picnicCount < 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicSilver.png");
                a47Txt.Text = "Picnic Silver";
            }
            else if (GetAchievementsData.picnicCount >= 25)
            {
                a47.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.picnicGold.png");
                a47Txt.Text = "Picnic Gold";
            }

            if (GetAchievementsData.scoopCount >= 5 && GetAchievementsData.scoopCount < 15)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopBronze.png");
                a48Txt.Text = "Scoop Poop Bronze";
            }
            else if (GetAchievementsData.scoopCount >= 15 && GetAchievementsData.scoopCount < 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopSilver.png");
                a48Txt.Text = "Scoop Poop Silver";
            }
            else if (GetAchievementsData.scoopCount >= 25)
            {
                a48.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.scoopGold.png");
                a48Txt.Text = "Scoop Poop Gold";
            }

            if (GetAchievementsData.plantTreeCount >= 5 && GetAchievementsData.plantTreeCount < 15)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeBronze.png");
                a49Txt.Text = "Tree Planting Bronze";
            }
            else if (GetAchievementsData.plantTreeCount >= 15 && GetAchievementsData.plantTreeCount < 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeSilver.png");
                a49Txt.Text = "Tree Planting Silver";
            }
            else if (GetAchievementsData.plantTreeCount >= 25)
            {
                a49.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Outdoors.treeGold.png");
                a49Txt.Text = "Tree Planting Gold";
            }

            if (GetAchievementsData.communityCount >= 5 && GetAchievementsData.communityCount < 15)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityBronze.png");
                a50Txt.Text = "Community Bronze";
            }
            else if (GetAchievementsData.communityCount >= 15 && GetAchievementsData.communityCount < 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communitySilver.png");
                a50Txt.Text = "Community Silver";
            }
            else if (GetAchievementsData.communityCount >= 25)
            {
                a50.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.communityGold.png");
                a50Txt.Text = "Community Gold";
            }

            if (GetAchievementsData.donateCount >= 5 && GetAchievementsData.donateCount < 15)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateBronze.png");
                a51Txt.Text = "Donations Bronze";
            }
            else if (GetAchievementsData.donateCount >= 15 && GetAchievementsData.donateCount < 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateSilver.png");
                a51Txt.Text = "Donations Silver";
            }
            else if (GetAchievementsData.donateCount >= 25)
            {
                a51.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Community.donateGold.png");
                a51Txt.Text = "Donations Gold";
            }

            if (GetAchievementsData.bioBinBagsCount >= 5 && GetAchievementsData.bioBinBagsCount < 15)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsBronze.png");
                a52Txt.Text = "Bio Bin Bag Bronze";
            }
            else if (GetAchievementsData.bioBinBagsCount >= 15 && GetAchievementsData.bioBinBagsCount < 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsSilver.png");
                a52Txt.Text = "Bio Bin Bag Silver";
            }
            else if (GetAchievementsData.bioBinBagsCount >= 25)
            {
                a52.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.bagsGold.png");
                a52Txt.Text = "Bio Bin Bag Gold";
            }

            if (GetAchievementsData.billsCount >= 5 && GetAchievementsData.billsCount < 15)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsBronze.png");
                a53Txt.Text = "Online Bills Bronze";
            }
            else if (GetAchievementsData.billsCount >= 15 && GetAchievementsData.billsCount < 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsSilver.png");
                a53Txt.Text = "Online Bills Silver";
            }
            else if (GetAchievementsData.billsCount >= 25)
            {
                a53.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.billsGold.png");
                a53Txt.Text = "Online Bills Gold";
            }

            if (GetAchievementsData.recyclingBinCount >= 5 && GetAchievementsData.recyclingBinCount < 15)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binBronze.png");
                a54Txt.Text = "Recycling Bronze";
            }
            else if (GetAchievementsData.recyclingBinCount >= 15 && GetAchievementsData.recyclingBinCount < 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binSilver.png");
                a54Txt.Text = "Recycling Silver";
            }
            else if (GetAchievementsData.recyclingBinCount >= 25)
            {
                a54.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.binGold.png");
                a54Txt.Text = "Recycling Gold";
            }

            if (GetAchievementsData.compostCount >= 5 && GetAchievementsData.compostCount < 15)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostBronze.png");
                a55Txt.Text = "Composting Bronze";
            }
            else if (GetAchievementsData.compostCount >= 15 && GetAchievementsData.compostCount < 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostSilver.png");
                a55Txt.Text = "Composting Silver";
            }
            else if (GetAchievementsData.compostCount >= 25)
            {
                a55.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Waste.compostGold.png");
                a55Txt.Text = "Composting Gold";
            }

            if (GetAchievementsData.offElectronicsCount >= 5 && GetAchievementsData.offElectronicsCount < 15)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offBronze.png");
                a56Txt.Text = "Electronics Off Bronze";
            }
            else if (GetAchievementsData.offElectronicsCount >= 15 && GetAchievementsData.offElectronicsCount < 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offSilver.png");
                a56Txt.Text = "Electronics Off Silver";
            }
            else if (GetAchievementsData.offElectronicsCount >= 25)
            {
                a56.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.offGold.png");
                a56Txt.Text = "Electronics Off Gold";
            }

            if (GetAchievementsData.paperCount >= 5 && GetAchievementsData.paperCount < 15)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperBronze.png");
                a57Txt.Text = " Paper Bronze";
            }
            else if (GetAchievementsData.paperCount >= 15 && GetAchievementsData.paperCount < 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperSilver.png");
                a57Txt.Text = " Paper Silver";
            }
            else if (GetAchievementsData.paperCount >= 25)
            {
                a57.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Work.paperGold.png");
                a57Txt.Text = " Paper Gold";
            }

            if (GetAchievementsData.fixCount >= 5 && GetAchievementsData.fixCount < 15)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixBronze.png");
                a58Txt.Text = "Fixed Bronze";
            }
            else if (GetAchievementsData.fixCount >= 15 && GetAchievementsData.fixCount < 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixSilver.png");
                a58Txt.Text = "Fixed Silver";
            }
            else if (GetAchievementsData.fixCount >= 25)
            {
                a58.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.Advanced.fixGold.png");
                a58Txt.Text = "Fixed Gold";
            }

            if (GetAchievementsData.efficientThermostatCount >= 1)
            {
                a59.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.thermostat.png");
                a59Txt.Text = "Efficient Thermostat Set";
            }

            if (GetAchievementsData.insulateWaterCount >= 1)
            {
                a60.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.waterTank.png");
                a60Txt.Text = "Insulated Water Tank";
            }

            if (GetAchievementsData.isolateHomeCount >= 1)
            {
                a61.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.isolateHome.png");
                a61Txt.Text = "Insulated Home";
            }

            if (GetAchievementsData.ledLightBulbCount >= 1)
            {
                a62.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.ledBulb.png");
                a62Txt.Text = "Led Lights Installed";
            }

            if (GetAchievementsData.fridgeCount >= 1)
            {
                a63.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.turnDownFridge.png");
                a63Txt.Text = "Turn Down The Fridge";
            }

            if (GetAchievementsData.draftSealCount >= 1)
            {
                a64.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDraft.png");
                a64Txt.Text = "Drafts Sealed";
            }

            if (GetAchievementsData.ductSealCount >= 1)
            {
                a65.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.sealDuct.png");
                a65Txt.Text = "Ducts Sealed";
            }

            if (GetAchievementsData.solarPanelCount >= 1)
            {
                a66.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Energy.solar.png");
                a66Txt.Text = "Installed Solar Panel";
            }

            if (GetAchievementsData.reusableCount >= 1)
            {
                a67.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reWaterBottle.png");
                a67Txt.Text = "Purchased Reusable Bottle";
            }

            if (GetAchievementsData.reBatCount >= 1)
            {
                a68.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Shopping.reBatteries.png");
                a68Txt.Text = "Purchased Reusable Batteries";
            }

            if (GetAchievementsData.cisternCount >= 1)
            {
                a69.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.Cistern.png");
                a69Txt.Text = "Cistern Displacement System Installed";
            }

            if (GetAchievementsData.rainBarrelCount >= 1)
            {
                a70.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.rainBarrel.png");
                a70Txt.Text = "Rain Barrel Set Up";
            }

            if (GetAchievementsData.wSShowerHeadCount >= 1)
            {
                a71.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Water.showerHead.png");
                a71Txt.Text = "Water Saving Shower Head Installed";
            }

            if (GetAchievementsData.fruitGardenCount >= 1)
            {
                a72.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.fruit.png");
                a72Txt.Text = "Fruit Garden Set Up";
            }

            if (GetAchievementsData.herbGardenCount >= 1)
            {
                a73.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.herb.png");
                a73Txt.Text = "Herb Garden Set Up";
            }

            if (GetAchievementsData.vegetableGardenCount >= 1)
            {
                a74.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.veg.png");
                a74Txt.Text = "Vegetable Garden Set Up";
            }

            if (GetAchievementsData.birdFeederCount >= 1)
            {
                a75.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Outdoors.birdFeeder.png");
                a75Txt.Text = "Bird Feeder Set Up";
            }

            if (GetAchievementsData.createGroupCount >= 1)
            {
                a76.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.create.png");
                a76Txt.Text = "Community Set Up";
            }

            if (GetAchievementsData.groupCount >= 1)
            {
                a77.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.join.png");
                a77Txt.Text = "Joined A Community";
            }

            if (GetAchievementsData.shareCount >= 1)
            {
                a78.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.share.png");
                a78Txt.Text = "App Shared";
            }

            if (GetAchievementsData.awarenessCount >= 1)
            {
                a79.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Community.spread.png");
                a79Txt.Text = "Awareness Spread";
            }

            if (GetAchievementsData.setUpRecyclingBinCount >= 1)
            {
                a80.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Waste.bins.png");
                a80Txt.Text = "Recycling Bins Set Up";
            }

            if (GetAchievementsData.remoteWorkCount >= 1)
            {
                a81.Source = ImageSource.FromResource("Application_Green_Quake.Images.Achievements.OnceOff.Work.remote.png");
                a81Txt.Text = "Working Remotely";
            }
        }
    }
}