using Application_Green_Quake.Models;
using Application_Green_Quake.ViewModels;
using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefillStation : ContentPage
    {
        public RefillStation()
        {
            InitializeComponent();
            OnAppearing();
        }

        protected async override void OnAppearing()
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
                    map.Pins.Add(currentLocation);
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(currentLocation.Position, Distance.FromMeters(5000)));
                    
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine($"Something is wrong: {e.Message}");
            }


            FirebaseClient firebaseClient = new FirebaseClient("https://application-green-quake-default-rtdb.firebaseio.com/");

            var list = (await firebaseClient
           .Child("Stations")
           .OnceAsync<Station>()).Select(item => new Station
           {
               description = item.Object.description,
               label = item.Object.label,
               latitude = item.Object.latitude,
               longitude = item.Object.longitude,

           }).ToList();

            
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