/*! \class The TopTabLeaderBoard View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the TopTabLeaderBoard View Class. This is the class for the leaderboard screen.
 *
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Acr.UserDialogs;
using Application_Green_Quake.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SelectionChangedEventArgs = Syncfusion.SfPicker.XForms.SelectionChangedEventArgs;

namespace Application_Green_Quake.Views.LeaderboardPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopTabLeaderBoard : ContentPage
    {
        private string selectedNation = "All";
        private int min = 0;
        private int count = 10;
        IAuth auth;
        public TopTabLeaderBoard()
        {
            InitializeComponent();
            ObservableCollection<object> countryNameCollection = new ObservableCollection<object>();

            // Add al the options into the filter
            countryNameCollection.Add("All");
            countryNameCollection.Add("Me");
            countryNameCollection.Add("Albania");
            countryNameCollection.Add("Andorra");
            countryNameCollection.Add("Armenia");
            countryNameCollection.Add("Austria");
            countryNameCollection.Add("Azerbaijan");
            countryNameCollection.Add("Belarus");
            countryNameCollection.Add("Belgium");
            countryNameCollection.Add("Bosnia and Herzegovina");
            countryNameCollection.Add("Bulgaria");
            countryNameCollection.Add("Croatia");
            countryNameCollection.Add("Cyprus");
            countryNameCollection.Add("Czech Republic");
            countryNameCollection.Add("Denmark");
            countryNameCollection.Add("Estonia");
            countryNameCollection.Add("Finland");
            countryNameCollection.Add("France");
            countryNameCollection.Add("Georgia");
            countryNameCollection.Add("Germany");
            countryNameCollection.Add("Greece");
            countryNameCollection.Add("Hungary");
            countryNameCollection.Add("Iceland");
            countryNameCollection.Add("Ireland");
            countryNameCollection.Add("Italy");
            countryNameCollection.Add("Kazakhstan");
            countryNameCollection.Add("Kosovo");
            countryNameCollection.Add("Latvia");
            countryNameCollection.Add("Liechtenstein");
            countryNameCollection.Add("Lithuania");
            countryNameCollection.Add("Luxembourg");
            countryNameCollection.Add("Malta");
            countryNameCollection.Add("Moldova");
            countryNameCollection.Add("Monaco");
            countryNameCollection.Add("Montenegro");
            countryNameCollection.Add("Netherlands");
            countryNameCollection.Add("North Macedonia");
            countryNameCollection.Add("Norway");
            countryNameCollection.Add("Poland");
            countryNameCollection.Add("Portugal");
            countryNameCollection.Add("Romania");
            countryNameCollection.Add("Russia");
            countryNameCollection.Add("San Marino");
            countryNameCollection.Add("Serbia");
            countryNameCollection.Add("Slovakia");
            countryNameCollection.Add("Slovenia");
            countryNameCollection.Add("Spain");
            countryNameCollection.Add("Sweden");
            countryNameCollection.Add("Switzerland");
            countryNameCollection.Add("Turkey");
            countryNameCollection.Add("Ukraine");
            countryNameCollection.Add("United Kingdom");
            countryNameCollection.Add("Vatican City");

            picker.ItemsSource = countryNameCollection;
            auth = DependencyService.Get<IAuth>();
            OnAppearing();
        }
        /** This function is called before the page is displayed.
        */
        protected override async void OnAppearing()
        {
            //If All gets selected from the filter then display all the profiles
            if (selectedNation == "All")
            {
                UserDialogs.Instance.ShowLoading();
                FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                //Save the data into a list and order it by points
                var list = (await firebaseClient
                      .Child("Points")
                      .OnceAsync<Points>()).Select(item => new Points
                      {
                          username = item.Object.username,
                          points = item.Object.points,
                      }).ToList().OrderByDescending(s => s.points);

                //Save that data to a second list
                var list2 = list.Select(item => new LeaderBoard
                {
                    username = item.username,
                    points = item.points,
                }).ToList();

                int index = 0;
                string rankIndex = "";
                // Create a new list and assign an image and the rank based on the index
                foreach (var i in list2)
                {
                    index++;
                    rankIndex = "Rank: " + index.ToString();
                    i.rank = rankIndex;
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.image = await new FirebaseStorage("application-green-quake.appspot.com")
                        .Child(uid)
                        .Child("Profile.jpg")
                        .GetDownloadUrlAsync();
                    }
                    catch (Exception e)
                    {
                        i.image = ImageSource.FromResource("Application_Green_Quake.Images.user.png");
                        Console.Write(e);
                    }
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.bio = (await firebaseClient
                        .Child("users")
                        .Child(uid)
                        .OnceSingleAsync<Users>()).bio;

                        i.nation = (await firebaseClient
                            .Child("users")
                            .Child(uid)
                            .OnceSingleAsync<Users>()).nation;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
                    }
                }

                try
                {   //Get entries between specified indexes and dsave them into a list and then display them in the leaderboard.
                    var list3 = list2.Select(item => new LeaderBoard
                    {
                        username = item.username,
                        points = item.points,
                        nation = item.nation,
                        bio = item.bio,
                        rank = item.rank,
                        image = item.image
                    }).ToList().GetRange(min, count);
                    LeaderBoard.ItemsSource = list3;

                }
                catch (Exception e)
                {
                    try
                    {   //Get entries between specified indexes and dsave them into a list and then display them in the leaderboard.
                        var list3 = list2.Select(item => new LeaderBoard
                        {
                            username = item.username,
                            points = item.points,
                            nation = item.nation,
                            bio = item.bio,
                            rank = item.rank,
                            image = item.image
                        }).ToList().GetRange(min, list2.Count - min);
                        LeaderBoard.ItemsSource = list3;
                    }
                    catch (Exception exception)
                    {
                        min = 0;
                        await DisplayAlert("Last Page", "You have reached the last leader board page.", "Ok");
                    }
                }
                UserDialogs.Instance.HideLoading();
            }
            //If Me gets selected from the filter then only display the users profile
            else if (selectedNation == "Me")
            {
                UserDialogs.Instance.ShowLoading();
                FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                var list = (await firebaseClient
                      .Child("Points")
                      .OnceAsync<Points>()).Select(item => new Points
                      {
                          username = item.Object.username,
                          points = item.Object.points,
                      }).ToList().OrderByDescending(s => s.points);

                var list2 = list.Select(item => new LeaderBoard
                {
                    username = item.username,
                    points = item.points,
                }).ToList();

                int index = 0;
                string rankIndex = "";
                foreach (var i in list2)
                {
                    index++;
                    rankIndex = "Rank: " + index.ToString();
                    i.rank = rankIndex;
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.uid = uid;

                        i.image = await new FirebaseStorage("application-green-quake.appspot.com")
                        .Child(uid)
                        .Child("Profile.jpg")
                        .GetDownloadUrlAsync();
                    }
                    catch (Exception e)
                    {
                        i.image = ImageSource.FromResource("Application_Green_Quake.Images.user.png");
                        Console.Write(e);
                    }
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.uid = uid;

                        i.bio = (await firebaseClient
                        .Child("users")
                        .Child(uid)
                        .OnceSingleAsync<Users>()).bio;

                        i.nation = (await firebaseClient
                            .Child("users")
                            .Child(uid)
                            .OnceSingleAsync<Users>()).nation;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
                    }
                }

                var list3 = list2.Select(item => new LeaderBoard
                {
                    username = item.username,
                    points = item.points,
                    nation = item.nation,
                    bio = item.bio,
                    rank = item.rank,
                    image = item.image,
                    uid = item.uid
                }).Where(x => x.uid == auth.GetUid()).ToList();
                
                LeaderBoard.ItemsSource = list3;
                UserDialogs.Instance.ShowLoading();
            }
            else
            {
                UserDialogs.Instance.ShowLoading();
                FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

                var list = (await firebaseClient
                      .Child("Points")
                      .OnceAsync<Points>()).Select(item => new Points
                      {
                          username = item.Object.username,
                          points = item.Object.points,
                      }).ToList().OrderByDescending(s => s.points);

                var list2 = list.Select(item => new LeaderBoard
                {
                    username = item.username,
                    points = item.points,
                }).ToList();

                int index = 0;
                string rankIndex = "";
                foreach (var i in list2)
                {
                    index++;
                    rankIndex = "Rank: " + index.ToString();
                    i.rank = rankIndex;
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.image = await new FirebaseStorage("application-green-quake.appspot.com")
                        .Child(uid)
                        .Child("Profile.jpg")
                        .GetDownloadUrlAsync();
                    }
                    catch (Exception e)
                    {
                        i.image = ImageSource.FromResource("Application_Green_Quake.Images.user.png");
                        Console.Write(e);
                    }
                    try
                    {
                        var uid = (await firebaseClient
                        .Child("usernames")
                        .Child(i.username)
                        .OnceSingleAsync<Usernames>()).Uid;

                        i.bio = (await firebaseClient
                        .Child("users")
                        .Child(uid)
                        .OnceSingleAsync<Users>()).bio;

                        i.nation = (await firebaseClient
                            .Child("users")
                            .Child(uid)
                            .OnceSingleAsync<Users>()).nation;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
                    }
                }

                var list3 = list2.Select(item => new LeaderBoard
                {
                    username = item.username,
                    points = item.points,
                    nation = item.nation,
                    bio = item.bio,
                    rank = item.rank,
                    image = item.image
                }).Where(n => n.nation == selectedNation).ToList();

                index = 0; 
                rankIndex = "";
                foreach (var p in list3)
                {
                    index++;
                    rankIndex = "Rank: " + index.ToString();
                    p.rank = rankIndex;
                }

                LeaderBoard.ItemsSource = list3;
            }
            //Stop the loading spinner and set the data.
            UserDialogs.Instance.HideLoading();
            GetData data = new GetData();
            data.SetLvl();
            min = 0;
            count = 10;
        }

        /** This function displays the correct popup when a profile on the leader board is tapped.
        */
        private void OnItemTapped (Object sender, ItemTappedEventArgs e)
        {
           
            var dataItem = e.Item as LeaderBoard;
            PopupNavigation.Instance.PushAsync(new LeaderBoardPopUp(dataItem.username, dataItem.points, dataItem.rank, dataItem.image, dataItem.bio));
        }
        /** This function displays the picker when the icon is pressed.
        */
        private async void ImageClicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }

        /** This function sets the selectedNation variable when a value is selected on the picker and ok is pressed..
        */
        private async void PickerOnOkButtonClicked(object sender, SelectionChangedEventArgs e)
        {
            if (picker.SelectedItem.ToString() == "All")
            {
                selectedNation = "All";
            }
            else if (picker.SelectedItem.ToString() == "Me")
            {
                selectedNation = "Me";
            }
            else if (picker.SelectedItem.ToString() == "Albania")
            {
                selectedNation = "Albania";
            }
            else if (picker.SelectedItem.ToString() == "Andorra")
            {
                selectedNation = "Andorra";
            }
            else if (picker.SelectedItem.ToString() == "Armenia")
            {
                selectedNation = "Armenia";
            }
            else if (picker.SelectedItem.ToString() == "Austria")
            {
                selectedNation = "Austria";
            }
            else if (picker.SelectedItem.ToString() == "Azerbaijan")
            {
                selectedNation = "Azerbaijan";
            }
            else if (picker.SelectedItem.ToString() == "Belarus")
            {
                selectedNation = "Belarus";
            }
            else if (picker.SelectedItem.ToString() == "Belgium")
            {
                selectedNation = "Belgium";
            }
            else if (picker.SelectedItem.ToString() == "Bosnia and Herzegovina")
            {
                selectedNation = "Bosnia and Herzegovina";
            }
            else if (picker.SelectedItem.ToString() == "Bulgaria")
            {
                selectedNation = "Bulgaria";
            }
            else if (picker.SelectedItem.ToString() == "Cyprus")
            {
                selectedNation = "Cyprus";
            }
            else if (picker.SelectedItem.ToString() == "Czech Republic")
            {
                selectedNation = "Czech Republic";
            }
            else if (picker.SelectedItem.ToString() == "Denmark")
            {
                selectedNation = "Denmark";
            }
            else if (picker.SelectedItem.ToString() == "Estonia")
            {
                selectedNation = "Estonia";
            }
            else if (picker.SelectedItem.ToString() == "Finland")
            {
                selectedNation = "Finland";
            }
            else if (picker.SelectedItem.ToString() == "France")
            {
                selectedNation = "France";
            }
            else if (picker.SelectedItem.ToString() == "Georgia")
            {
                selectedNation = "Georgia";
            }
            else if (picker.SelectedItem.ToString() == "Germany")
            {
                selectedNation = "Germany";
            }
            else if (picker.SelectedItem.ToString() == "Greece")
            {
                selectedNation = "Greece";
            }
            else if (picker.SelectedItem.ToString() == "Hungary")
            {
                selectedNation = "Hungary";
            }
            else if (picker.SelectedItem.ToString() == "Iceland")
            {
                selectedNation = "Iceland";
            }
            else if (picker.SelectedItem.ToString() == "Ireland")
            {
                selectedNation = "Ireland";
            }
            else if (picker.SelectedItem.ToString() == "Italy")
            {
                selectedNation = "Italy";
            }
            else if (picker.SelectedItem.ToString() == "Kazakhstan")
            {
                selectedNation = "Kazakhstan";
            }
            else if (picker.SelectedItem.ToString() == "Kosovo")
            {
                selectedNation = "Kosovo";
            }
            else if (picker.SelectedItem.ToString() == "Latvia")
            {
                selectedNation = "Latvia";
            }
            else if (picker.SelectedItem.ToString() == "Liechtenstein")
            {
                selectedNation = "Liechtenstein";
            }
            else if (picker.SelectedItem.ToString() == "Lithuania")
            {
                selectedNation = "Lithuania";
            }
            else if (picker.SelectedItem.ToString() == "Luxembourg")
            {
                selectedNation = "Luxembourg";
            }
            else if (picker.SelectedItem.ToString() == "Malta")
            {
                selectedNation = "Malta";
            }
            else if (picker.SelectedItem.ToString() == "Moldova")
            {
                selectedNation = "Moldova";
            }
            else if (picker.SelectedItem.ToString() == "Monaco")
            {
                selectedNation = "Monaco";
            }
            else if (picker.SelectedItem.ToString() == "Montenegro")
            {
                selectedNation = "Montenegro";
            }
            else if (picker.SelectedItem.ToString() == "Netherlands")
            {
                selectedNation = "Netherlands";
            }
            else if (picker.SelectedItem.ToString() == "North Macedonia")
            {
                selectedNation = "North Macedonia";
            }
            else if (picker.SelectedItem.ToString() == "Norway")
            {
                selectedNation = "Norway";
            }
            else if (picker.SelectedItem.ToString() == "Poland")
            {
                selectedNation = "Poland";
            }
            else if (picker.SelectedItem.ToString() == "Portugal")
            {
                selectedNation = "Portugal";
            }
            else if (picker.SelectedItem.ToString() == "Romania")
            {
                selectedNation = "Romania";
            }
            else if (picker.SelectedItem.ToString() == "Russia")
            {
                selectedNation = "Russia";
            }
            else if (picker.SelectedItem.ToString() == "San Marino")
            {
                selectedNation = "San Marino";
            }
            else if (picker.SelectedItem.ToString() == "Serbia")
            {
                selectedNation = "Serbia";
            }
            else if (picker.SelectedItem.ToString() == "Slovakia")
            {
                selectedNation = "Slovakia";
            }
            else if (picker.SelectedItem.ToString() == "Slovenia")
            {
                selectedNation = "Albania";
            }
            else if (picker.SelectedItem.ToString() == "Spain")
            {
                selectedNation = "Spain";
            }
            else if (picker.SelectedItem.ToString() == "Sweden")
            {
                selectedNation = "Sweden";
            }
            else if (picker.SelectedItem.ToString() == "Switzerland")
            {
                selectedNation = "Switzerland";
            }
            else if (picker.SelectedItem.ToString() == "Turkey")
            {
                selectedNation = "Turkey";
            }
            else if (picker.SelectedItem.ToString() == "Ukraine")
            {
                selectedNation = "Ukraine";
            }
            else if (picker.SelectedItem.ToString() == "United Kingdom")
            {
                selectedNation = "United Kingdom";
            }
            else if (picker.SelectedItem.ToString() == "Vatican City")
            {
                selectedNation = "Vatican City";
            }

            OnAppearing();
        }

        /** This function displays the next ten items on the leader board.
        */
        private void NextPageClicked(object sender, EventArgs e)
        {
            min = min + 10;
            OnAppearing();
        }

        /** This function displays the first page of the leader board again.
        */
        private void FirstPageClicked(object sender, EventArgs e)
        {
            min = 0;
            OnAppearing();
        }
    }
}