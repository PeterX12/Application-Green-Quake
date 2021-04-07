using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class EnergyPointsUpdate
    {
        int points2 = 0;
        int numberOfLogs2 = 0;
        int hangDry2 = 0;
        int fullDryerCount2 = 0;
        int draftSealCount2 = 0;
        int ductSealCount2 = 0;
        int efficientThermostatCount2 = 0;
        int fridgeCount2 = 0;
        int fullMachineCount2 = 0;
        int insulateWaterCount2 = 0;
        int isolateHomeCount2 = 0;
        int ledLightBulbCount2 = 0;
        int microwaveCount2 = 0;
        int solarPanelCount2 = 0;
        int offSocketCount2 = 0;
        int reBatteriesCount2 = 0;


        string username = "";

        IAuth auth;
        public async void HangDryPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                hangDry2++;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() 
                {
                     username = username, 
                     points = points2, 
                     numberOfLogs = numberOfLogs2,
                     hangDryCount = hangDry2, 
                     draftSealCount = draftSealCount2, 
                     ductSealCount = ductSealCount2,
                     efficientThermostatCount = efficientThermostatCount2, 
                     fridgeCount = fridgeCount2,
                     fullDryerCount = fullDryerCount2, 
                     insulateWaterCount = insulateWaterCount2, 
                     isolateHomeCount = isolateHomeCount2, 
                     ledLightBulbCount =ledLightBulbCount2,
                     microwaveCount = microwaveCount2, 
                     offSocketCount = offSocketCount2, 
                     reBatteriesCount = reBatteriesCount2,
                     solarPanelCount = solarPanelCount2,
                     fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, hangDryCount = 1});;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, hangDryCount = 1 });
            }
        }

        public async void DryerFullPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullDryerCount2++;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fullDryerCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fullDryerCount = 1 });
            }
        }

        public async void EfficientThermostatPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                efficientThermostatCount2++;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, efficientThermostatCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, efficientThermostatCount = 1 });
            }
        }

        public async void InsulateWaterPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                insulateWaterCount2++;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, insulateWaterCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, insulateWaterCount = 1 });
            }
        }

        public async void IsolateHomePoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                isolateHomeCount2++;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, isolateHomeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, isolateHomeCount = 1 });
            }
        }

        public async void LedLightsPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                ledLightBulbCount2++;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, ledLightBulbCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, ledLightBulbCount = 1 });
            }
        }

        public async void MachineFullPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                fullMachineCount2++;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fullMachineCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fullMachineCount = 1 });
            }
        }

        public async void MicrowavePoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                microwaveCount2++;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, microwaveCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, microwaveCount = 1 });
            }
        }

        public async void SocketPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.fourPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                offSocketCount2++;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, offSocketCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, offSocketCount = 1 });
            }
        }

        public async void ReBatteriesPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.sixPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                reBatteriesCount2++;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, reBatteriesCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.fourPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, reBatteriesCount = 1 });
            }
        }

        public async void FridgePoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fridgeCount2++;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fridgeCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, fridgeCount = 1 });
            }
        }

        public async void SealDraftsPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                draftSealCount2++;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, draftSealCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, draftSealCount = 1 });
            }
        }

        public async void SealDuctsPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                ductSealCount2++;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, ductSealCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, ductSealCount = 1 });
            }
        }

        public async void SolarPanelPoints()
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).numberOfLogs;

                numberOfLogs2++;

                hangDry2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).hangDryCount;

                draftSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).draftSealCount;

                ductSealCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ductSealCount;

                efficientThermostatCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).efficientThermostatCount;

                fridgeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fridgeCount;

                fullDryerCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullDryerCount;

                fullMachineCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).fullMachineCount;

                insulateWaterCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).insulateWaterCount;

                ledLightBulbCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).ledLightBulbCount;

                microwaveCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).microwaveCount;

                offSocketCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).offSocketCount;

                reBatteriesCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).reBatteriesCount;

                solarPanelCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).solarPanelCount;

                solarPanelCount2++;

                isolateHomeCount2 = (await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<EnergyPoints>()).isolateHomeCount;

                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    hangDryCount = hangDry2,
                    draftSealCount = draftSealCount2,
                    ductSealCount = ductSealCount2,
                    efficientThermostatCount = efficientThermostatCount2,
                    fridgeCount = fridgeCount2,
                    fullDryerCount = fullDryerCount2,
                    insulateWaterCount = insulateWaterCount2,
                    isolateHomeCount = isolateHomeCount2,
                    ledLightBulbCount = ledLightBulbCount2,
                    microwaveCount = microwaveCount2,
                    offSocketCount = offSocketCount2,
                    reBatteriesCount = reBatteriesCount2,
                    solarPanelCount = solarPanelCount2,
                    fullMachineCount = fullMachineCount2
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
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, solarPanelCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("EnergyPoints")
                .Child(auth.GetUid())
                .PutAsync(new EnergyPoints() { username = username, points = points2, numberOfLogs = 1, solarPanelCount = 1 });
            }
        }
    }
}
