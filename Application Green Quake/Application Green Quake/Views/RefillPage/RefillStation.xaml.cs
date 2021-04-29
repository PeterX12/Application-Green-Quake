/*! \mainpage The RefillStation View Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the RefillStation View Class. This page contains the map and loads data from firebase and then uses this data to display the pins.
 *
 */
using Application_Green_Quake.Models;
using Firebase.Database;
using System;
using System.Diagnostics;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;
namespace Application_Green_Quake.Views.RefillPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefillStation : ContentPage
    {
        public RefillStation()
        {
            InitializeComponent();
            OnAppearing();
        }
        /** This function is called before the page is displayed.
        */
        protected override async void OnAppearing()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });


                }
                else
                {
                    Pin currentLocation = new Pin()
                    {
                        Type = PinType.SavedPin,
                        Label = "Me",
                        Address = "Here",
                        Position = new Position(location.Latitude, location.Longitude),
                        Tag = "id_Me",

                    };
                    // Add the pin and load the map at this location
                    map.Pins.Add(currentLocation);
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(currentLocation.Position, Distance.FromMeters(5000)));
                    
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine($"Something is wrong: {e.Message}");
            }


            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            //Load the pin data into a list
            var list = (await firebaseClient
           .Child("Stations")
           .OnceAsync<Station>()).Select(item => new Station
           {
               description = item.Object.description,
               label = item.Object.label,
               latitude = item.Object.latitude,
               longitude = item.Object.longitude,

           }).ToList();

            // For each entry in the data create and place a pin.
            foreach (var obj in list)
            {
                Pin stationLocations = new Pin()
                {
                    Type = PinType.SavedPin,
                    Label = obj.label,
                    Address = obj.description,
                    Position = new Position(obj.latitude, obj.longitude),

                };
                map.Pins.Add(stationLocations);
            }
        }
    }
}