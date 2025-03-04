﻿/*! \class The FoodAndDrinkPointsUpdate ViewModel Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the FoodAndDrinkPointsUpdate ViewModel Class. It updates the data for the Food And Drink Category of the application. The functions in this class
 * work by reading in all the chosen data and updating the selected fields and then sending this data to back firebase.
 *
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class FoodAndDrinkPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int organicCount2 = 0;
        int eatAllCount2 = 0;
        int foodDeliverCount2 = 0;
        int noMeatCount2 = 0;
        int ownCoffeeCount2 = 0;
        int reCoffeeMugCount2 = 0;
        int saveLeftOversCount2 = 0;
        int steelStrawCount2 = 0;
        int waterOverFizzyCount2 = 0;

        string username = "";

        IAuth auth;
        /** This function updates the points in the FoodAndDrink category by eight points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void OrganicPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                organicCount2++;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, organicCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, organicCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by four points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void EatAllPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                eatAllCount2++;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, eatAllCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, eatAllCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by six points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void FoodDelivredPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                foodDeliverCount2++;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, foodDeliverCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, foodDeliverCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by ten points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void NoMeatPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                noMeatCount2++;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, noMeatCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, noMeatCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by two points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void OwnCoffeePoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                ownCoffeeCount2++;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, ownCoffeeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, ownCoffeeCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by four points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void ReCoffeeMugPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                reCoffeeMugCount2++;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, reCoffeeMugCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, reCoffeeMugCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by six points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void SaveLeftOversPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                saveLeftOversCount2++;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, saveLeftOversCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, saveLeftOversCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by four points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void SteelStrawPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                steelStrawCount2++;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, steelStrawCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, steelStrawCount = 1 });
            }
        }
        /** This function updates the points in the FoodAndDrink category by six points. It also increments the number of logs logged in the FoodAndDrink
         * category by one and increments the number of times this particular action was logged by one and sends this data to Firebase. 
        */
        public async void WaterOverFizzyPoints()
        {

            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");
            auth = DependencyService.Get<IAuth>();

            try
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).numberOfLogs;

                numberOfLogs2++;

                organicCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).organicCount;

                eatAllCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).eatAllCount;

                foodDeliverCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).foodDeliverCount;

                noMeatCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).noMeatCount;

                ownCoffeeCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).ownCoffeeCount;

                reCoffeeMugCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).reCoffeeMugCount;

                saveLeftOversCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).saveLeftOversCount;

                steelStrawCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).steelStrawCount;

                waterOverFizzyCount2 = (await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<FoodAndDrinkPoints>()).waterOverFizzyCount;

                waterOverFizzyCount2++;

                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    organicCount = organicCount2,
                    eatAllCount = eatAllCount2,
                    foodDeliverCount = foodDeliverCount2,
                    noMeatCount = noMeatCount2,
                    ownCoffeeCount = ownCoffeeCount2,
                    reCoffeeMugCount = reCoffeeMugCount2,
                    saveLeftOversCount = saveLeftOversCount2,
                    steelStrawCount = steelStrawCount2,
                    waterOverFizzyCount = waterOverFizzyCount2,
                });
            }
            catch (FirebaseException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, waterOverFizzyCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("FoodAndDrinkPoints")
                .Child(auth.GetUid())
                .PutAsync(new FoodAndDrinkPoints() { username = username, points = points2, numberOfLogs = 1, waterOverFizzyCount = 1 });
            }
        }
    }
}
