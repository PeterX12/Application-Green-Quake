using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class ShoppingPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int clothNapkinCount2 = 0;
        int clothTowelCount2 = 0;
        int applianceCount2 = 0;
        int productCount2 = 0;
        int toothbrushCount2 = 0;
        int clothesCount2 = 0;
        int foodCount2 = 0;
        int localCount2 = 0;
        int looseLeafCount2 = 0;
        int organicFoodCount2 = 0;
        int reusableCount2 = 0;
        int reBatCount2 = 0;
        int reBagCount2 = 0;

        string username = "";

        IAuth auth;
        public async void ClothNapkinsPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothNapkinCount2++;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothNapkinCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothNapkinCount = 1 });
            }
        }

        public async void ClothTowelsPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                clothTowelCount2++;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothTowelCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.twoPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothTowelCount = 1 });
            }
        }

        public async void AppliancePoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.twoPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                applianceCount2++;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, applianceCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, applianceCount = 1 });
            }
        }

        public async void ProductPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                productCount2++;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, productCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, productCount = 1 });
            }
        }

        public async void EcoToothbrushPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                toothbrushCount2++;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, toothbrushCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, toothbrushCount = 1 });
            }
        }

        public async void ClothesPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                clothesCount2++;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothesCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, clothesCount = 1 });
            }
        }

        public async void FoodInBulkPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                foodCount2++;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, foodCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, foodCount = 1 });
            }
        }

        public async void LocalProductPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                localCount2++;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, productCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, productCount = 1 });
            }
        }

        public async void TeaPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                looseLeafCount2++;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, looseLeafCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, looseLeafCount = 1 });
            }
        }

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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                organicFoodCount2++;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, organicFoodCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, organicFoodCount = 1 });
            }
        }

        public async void ReWaterPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reusableCount2++;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reusableCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reusableCount = 1 });
            }
        }

        public async void ReBattereisPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBatCount2++;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reBatCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reBatCount = 1 });
            }
        }

        public async void ReBagPoints()
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).numberOfLogs;

                numberOfLogs2++;

                clothNapkinCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothNapkinCount;

                clothTowelCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothTowelCount;

                applianceCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).applianceCount;

                productCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).productCount;

                toothbrushCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).toothbrushCount;

                clothesCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).clothesCount;

                foodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).foodCount;

                localCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).localCount;

                looseLeafCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).looseLeafCount;

                organicFoodCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).organicFoodCount;

                reusableCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reusableCount;

                reBatCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBatCount;

                reBagCount2 = (await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<ShoppingPoints>()).reBagCount;

                reBagCount2++;

                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    clothNapkinCount = clothNapkinCount2,
                    clothTowelCount = clothTowelCount2,
                    applianceCount = applianceCount2,
                    productCount = productCount2,
                    toothbrushCount = toothbrushCount2,
                    clothesCount = clothesCount2,
                    foodCount = foodCount2,
                    localCount = localCount2,
                    looseLeafCount = looseLeafCount2,
                    organicFoodCount = organicFoodCount2,
                    reusableCount = reusableCount2,
                    reBatCount = reBatCount2,
                    reBagCount = reBagCount2,
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
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reBagCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("ShoppingPoints")
                .Child(auth.GetUid())
                .PutAsync(new ShoppingPoints() { username = username, points = points2, numberOfLogs = 1, reBagCount = 1 });
            }
        }
    }
}
