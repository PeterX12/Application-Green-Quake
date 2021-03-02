using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
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
                    Pin pinTokyo = new Pin()
                    {
                        Type = PinType.Place,
                        Label = "Me",
                        Position = new Position(location.Latitude, location.Longitude),
                        Tag = "id_Me",

                    };

                    map.Pins.Add(pinTokyo);
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(pinTokyo.Position, Distance.FromMeters(5000)));
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine($"Something is wrong: {e.Message}");
            }
        }
    }
}