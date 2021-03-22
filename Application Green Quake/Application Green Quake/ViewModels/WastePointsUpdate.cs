using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class WastePointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int billsCount2 = 0;
        int compostCount2 = 0;
        int setUpRecyclingBinCount2 = 0;
        int bioBinBagsCount2 = 0;
        int recyclingBinCount2 = 0;


        string username = "";

        IAuth auth;
        public async void BillsPoints()
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).numberOfLogs;

                numberOfLogs2++;

                billsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).billsCount;

                billsCount2++;

                compostCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).compostCount;

                setUpRecyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;

                bioBinBagsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).bioBinBagsCount;

                recyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).recyclingBinCount;

                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    billsCount = billsCount2,
                    compostCount = compostCount2,
                    setUpRecyclingBinCount = setUpRecyclingBinCount2,
                    bioBinBagsCount = bioBinBagsCount2,
                    recyclingBinCount = recyclingBinCount2,
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, billsCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, billsCount = 1 });
            }
        }

        public async void CompostPoints()
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).numberOfLogs;

                numberOfLogs2++;

                billsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).billsCount;

                compostCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).compostCount;

                compostCount2++;

                setUpRecyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;

                bioBinBagsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).bioBinBagsCount;

                recyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).recyclingBinCount;

                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    billsCount = billsCount2,
                    compostCount = compostCount2,
                    setUpRecyclingBinCount = setUpRecyclingBinCount2,
                    bioBinBagsCount = bioBinBagsCount2,
                    recyclingBinCount = recyclingBinCount2,
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, compostCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, compostCount = 1 });
            }
        }

        public async void SetUpRecyclingBinPoints()
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).numberOfLogs;

                numberOfLogs2++;

                billsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).billsCount;

                compostCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).compostCount;

                setUpRecyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;

                setUpRecyclingBinCount2++;

                bioBinBagsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).bioBinBagsCount;

                recyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).recyclingBinCount;

                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    billsCount = billsCount2,
                    compostCount = compostCount2,
                    setUpRecyclingBinCount = setUpRecyclingBinCount2,
                    bioBinBagsCount = bioBinBagsCount2,
                    recyclingBinCount = recyclingBinCount2,
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, setUpRecyclingBinCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, setUpRecyclingBinCount = 1 });
            }
        }

        public async void BioBinBagPoints()
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).numberOfLogs;

                numberOfLogs2++;

                billsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).billsCount;

                compostCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).compostCount;

                setUpRecyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;

                bioBinBagsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).bioBinBagsCount;

                bioBinBagsCount2++;

                recyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).recyclingBinCount;

                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    billsCount = billsCount2,
                    compostCount = compostCount2,
                    setUpRecyclingBinCount = setUpRecyclingBinCount2,
                    bioBinBagsCount = bioBinBagsCount2,
                    recyclingBinCount = recyclingBinCount2,
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, bioBinBagsCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, bioBinBagsCount = 1 });
            }
        }

        public async void RecyclingBinPoints()
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).numberOfLogs;

                numberOfLogs2++;

                billsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).billsCount;

                compostCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).compostCount;

                compostCount2++;

                setUpRecyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).setUpRecyclingBinCount;

                bioBinBagsCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).bioBinBagsCount;

                recyclingBinCount2 = (await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<WastePoints>()).recyclingBinCount;

                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    billsCount = billsCount2,
                    compostCount = compostCount2,
                    setUpRecyclingBinCount = setUpRecyclingBinCount2,
                    bioBinBagsCount = bioBinBagsCount2,
                    recyclingBinCount = recyclingBinCount2,
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
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, recyclingBinCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.sixPoints;
                await firebaseClient
                .Child("WastePoints")
                .Child(auth.GetUid())
                .PutAsync(new WastePoints() { username = username, points = points2, numberOfLogs = 1, recyclingBinCount = 1 });
            }
        }
    }
}
