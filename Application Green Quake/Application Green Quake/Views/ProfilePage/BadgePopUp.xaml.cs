using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.ProfilePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BadgePopUp
    {
        int num = 0;
        int  badgeState= 0;
        public BadgePopUp(int number, int stage)
        {
            num = number;
            badgeState = stage;
            InitializeComponent();
            OnAppearing();
        }

        protected override void OnAppearing()
        {
            
            if (num == 1 && badgeState == 1)
            {
                badgeHeading.Text = "Habit Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 1 && badgeState == 2)
            {
                badgeHeading.Text = "Habit Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 1 && badgeState == 3)
            {
                badgeHeading.Text = "Habit Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 1 && badgeState == 4)
            {
                badgeHeading.Text = "Habit Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 1 && badgeState == 5)
            {
                badgeHeading.Text = "Habit Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 1 && badgeState == 6)
            {
                badgeHeading.Text = "Habit Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Habits.habitsSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 2 && badgeState == 1)
            {
                badgeHeading.Text = "Advanced Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 2 && badgeState == 2)
            {
                badgeHeading.Text = "Advanced Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 2 && badgeState == 3)
            {
                badgeHeading.Text = "Advanced Habit Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 2 && badgeState == 4)
            {
                badgeHeading.Text = "Advanced Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 2 && badgeState == 5)
            {
                badgeHeading.Text = "Advanced Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 2 && badgeState == 6)
            {
                badgeHeading.Text = "Advanced Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Advanced.advancedSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 3 && badgeState == 1)
            {
                badgeHeading.Text = "Community Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 3 && badgeState == 2)
            {
                badgeHeading.Text = "Community Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 3 && badgeState == 3)
            {
                badgeHeading.Text = "Community Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 3 && badgeState == 4)
            {
                badgeHeading.Text = "Community Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 3 && badgeState == 5)
            {
                badgeHeading.Text = "Community Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communityFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 3 && badgeState == 6)
            {
                badgeHeading.Text = "Community Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Community.communitySix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 4 && badgeState == 1)
            {
                badgeHeading.Text = "Energy Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 4 && badgeState == 2)
            {
                badgeHeading.Text = "Energy Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 4 && badgeState == 3)
            {
                badgeHeading.Text = "Energy Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 4 && badgeState == 4)
            {
                badgeHeading.Text = "Energy Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 4 && badgeState == 5)
            {
                badgeHeading.Text = "Energy Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energyFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 4 && badgeState == 6)
            {
                badgeHeading.Text = "Energy Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Energy.energySix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 5 && badgeState == 1)
            {
                badgeHeading.Text = "Food And Drink Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 5 && badgeState == 2)
            {
                badgeHeading.Text = "Food And Drink Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 5 && badgeState == 3)
            {
                badgeHeading.Text = "Food And Drink Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 5 && badgeState == 4)
            {
                badgeHeading.Text = "Food And Drink Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 5 && badgeState == 5)
            {
                badgeHeading.Text = "Food And Drink Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 5 && badgeState == 6)
            {
                badgeHeading.Text = "Food And Drink Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.FD.fDSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 6 && badgeState == 1)
            {
                badgeHeading.Text = "Home Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 6 && badgeState == 2)
            {
                badgeHeading.Text = "Home Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 6 && badgeState == 3)
            {
                badgeHeading.Text = "Home Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 6 && badgeState == 4)
            {
                badgeHeading.Text = "Home Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 6 && badgeState == 5)
            {
                badgeHeading.Text = "Home Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 6 && badgeState == 6)
            {
                badgeHeading.Text = "Home Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Home.homeSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 7 && badgeState == 1)
            {
                badgeHeading.Text = "Outdoors Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 7 && badgeState == 2)
            {
                badgeHeading.Text = "Outdoors Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 7 && badgeState == 3)
            {
                badgeHeading.Text = "Outdoors Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 7 && badgeState == 4)
            {
                badgeHeading.Text = "Outdoors Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 7 && badgeState == 5)
            {
                badgeHeading.Text = "Outdoors Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 7 && badgeState == 6)
            {
                badgeHeading.Text = "Outdoors Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Outdoors.outdoorsSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 8 && badgeState == 1)
            {
                badgeHeading.Text = "Shopping Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 8 && badgeState == 2)
            {
                badgeHeading.Text = "Shopping Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 8 && badgeState == 3)
            {
                badgeHeading.Text = "Shopping Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 8 && badgeState == 4)
            {
                badgeHeading.Text = "Shopping Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 8 && badgeState == 5)
            {
                badgeHeading.Text = "Shopping Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 8 && badgeState == 6)
            {
                badgeHeading.Text = "Shopping Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Shopping.shoppingSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 9 && badgeState == 1)
            {
                badgeHeading.Text = "Travel Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 9 && badgeState == 2)
            {
                badgeHeading.Text = "Travel Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 9 && badgeState == 3)
            {
                badgeHeading.Text = "Travel Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 9 && badgeState == 4)
            {
                badgeHeading.Text = "Travel Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 9 && badgeState == 5)
            {
                badgeHeading.Text = "Travel Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 9 && badgeState == 6)
            {
                badgeHeading.Text = "Travel Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Travel.travelSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 10 && badgeState == 1)
            {
                badgeHeading.Text = "Waste Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 10 && badgeState == 2)
            {
                badgeHeading.Text = "Waste Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 10 && badgeState == 3)
            {
                badgeHeading.Text = "Waste Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 10 && badgeState == 4)
            {
                badgeHeading.Text = "Waste Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 10 && badgeState == 5)
            {
                badgeHeading.Text = "Waste Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 10 && badgeState == 6)
            {
                badgeHeading.Text = "Waste Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Waste.wasteSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 11 && badgeState == 1)
            {
                badgeHeading.Text = "Water Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 11 && badgeState == 2)
            {
                badgeHeading.Text = "Water Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 11 && badgeState == 3)
            {
                badgeHeading.Text = "Water Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 11 && badgeState == 4)
            {
                badgeHeading.Text = "Water Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 11 && badgeState == 5)
            {
                badgeHeading.Text = "Water Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 11 && badgeState == 6)
            {
                badgeHeading.Text = "Water Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Water.waterSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }

            if (num == 12 && badgeState == 1)
            {
                badgeHeading.Text = "Work Novice";
                badgeSubHeading.Text = "Badge awarded for loging 1 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workOne.png");
                badgeTxt.Text = "Next Rank: After 5 Action Logs";
            }
            else if (num == 12 && badgeState == 2)
            {
                badgeHeading.Text = "Work Apprentice";
                badgeSubHeading.Text = "Badge awarded for loging 5 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workTwo.png");
                badgeTxt.Text = "Next Rank: After 10 Action Logs";
            }
            else if (num == 12 && badgeState == 3)
            {
                badgeHeading.Text = "Work Adept";
                badgeSubHeading.Text = "Badge awarded for loging 10 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workThree.png");
                badgeTxt.Text = "Next Rank: After 25 Action Logs";
            }
            else if (num == 12 && badgeState == 4)
            {
                badgeHeading.Text = "Work Expert";
                badgeSubHeading.Text = "Badge awarded for loging 25 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFour.png");
                badgeTxt.Text = "Next Rank: After 50 Action Logs";
            }
            else if (num == 12 && badgeState == 5)
            {
                badgeHeading.Text = "Work Master";
                badgeSubHeading.Text = "Badge awarded for loging 50 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workFive.png");
                badgeTxt.Text = "Next Rank: After 100 Action Logs";
            }
            else if (num == 12 && badgeState == 6)
            {
                badgeHeading.Text = "Work Legend";
                badgeSubHeading.Text = "Badge awarded for loging 100 eco action!";
                badge.Source = ImageSource.FromResource("Application_Green_Quake.Images.Badges.Work.workSix.png");
                badgeTxt.Text = "Max Rank Reached!";
            }
        }
    }
}