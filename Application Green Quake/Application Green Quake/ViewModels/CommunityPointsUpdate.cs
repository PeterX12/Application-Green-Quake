using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;

namespace Application_Green_Quake.ViewModels
{
    class CommunityPointsUpdate
    {
        int points2 = 0;
        int createGroupCount2 = 0;
        int communityCount2 = 0;
        int donateCount2 = 0;
        int groupCount2 = 0;
        int shareCount2 = 0;
        int awarenessCount2 = 0;
        int numberOfLogs2 = 0;


        string username = "";

        IAuth auth;
        public async void CreateGroupPoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                createGroupCount2++;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                groupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).groupCount;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, createGroupCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, createGroupCount = 1 });
            }
        }

        public async void CommunityPoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                communityCount2++;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                groupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).groupCount;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, communityCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, communityCount = 1 });
            }
        }

        public async void DonatePoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.tenPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                donateCount2++;

                groupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).groupCount;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, donateCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.tenPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, donateCount = 1 });
            }
        }

        public async void GroupPoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                 groupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).groupCount;

                groupCount2++;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, groupCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, groupCount = 1 });
            }
        }

        public async void SharePoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                groupCount2 = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).groupCount;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                shareCount2++;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, shareCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, shareCount = 1 });
            }
        }

        public async void awarenessPoints()
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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).points;

                points2 = points2 + AppConstants.eightPoints;

                numberOfLogs2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).numberOfLogs;

                numberOfLogs2++;

                createGroupCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).createGroupCount;

                communityCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).communityCount;

                donateCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).donateCount;

                groupCount2 = (await firebaseClient
               .Child("CommunityPoints")
               .Child(auth.GetUid())
               .OnceSingleAsync<CommunityPoints>()).groupCount;

                shareCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).shareCount;

                awarenessCount2 = (await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .OnceSingleAsync<CommunityPoints>()).awarenessCount;

                awarenessCount2++;

                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints()
                {
                    username = username,
                    points = points2,
                    numberOfLogs = numberOfLogs2,
                    communityCount = communityCount2,
                    createGroupCount = createGroupCount2,
                    donateCount = donateCount2,
                    groupCount = groupCount2,
                    shareCount = shareCount2,
                    awarenessCount = awarenessCount2,

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
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, awarenessCount = 1 }); ;

            }
            catch (NullReferenceException)
            {
                username = (await firebaseClient
                .Child("users")
                .Child(auth.GetUid())
                .OnceSingleAsync<Users>()).username;

                points2 = AppConstants.eightPoints;
                await firebaseClient
                .Child("CommunityPoints")
                .Child(auth.GetUid())
                .PutAsync(new CommunityPoints() { username = username, points = points2, numberOfLogs = 1, awarenessCount = 1 });
            }
        }
    }
}
