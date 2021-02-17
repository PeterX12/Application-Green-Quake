using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NearMe : ContentPage
    {
        public NearMe()
        {
            InitializeComponent();
            Pin pinTokyo = new Pin()
            {
                Type = PinType.Place,
                Label = "Tokyo SKYTREE",
                Address = "Sumida-ku, Tokyo, Japan",
                Position = new Position(35.71d, 139.81d),
                Rotation = 33.3f,
                Tag = "id_tokyo",

            };

            map.Pins.Add(pinTokyo);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinTokyo.Position, Distance.FromMeters(5000)));
        }
    }
}