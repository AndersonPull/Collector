using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.ViewModels.Home;
using Collector.ViewModels.ViewModelLocator;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace Collector.Views.Home
{
    public partial class MainMapaView : ContentPage
    {
        readonly Pin _pinTokyo = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_carroça.png"),
            Type = PinType.Place,
            Label = "Tokyo SKYTREE",
            Address = "Sumida-ku, Tokyo, Japan",
            Position = new Position(-23.558419, -46.660071)
        };

        readonly Pin _pinTokyo2 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_car.png"),
            Type = PinType.Place,
            Label = "Second Pin",
            Position = new Position(-23.557969, -46.660549),
            ZIndex = 5
        };

        readonly Pin _pinTokyo3 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_coperativa.png"),
            Type = PinType.Place,
            Label = "Second Pin",
            Position = new Position(-23.559064, -46.661170),
            ZIndex = 5
        };

        public MainMapaView()
        {
            ObterPosicaoAtual();

            InitializeComponent();
            map.MyLocationEnabled = true;

            map.Pins.Add(_pinTokyo);
            map.Pins.Add(_pinTokyo2);
            map.Pins.Add(_pinTokyo3);

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;

            
            BindingContext = Locator.Instance.Resolve<MainMapaViewModel>();
        }

        public async Task ObterPosicaoAtual()
        {
            var userLocation = await Xamarin.Essentials.Geolocation.GetLocationAsync();

            var userPosition = new Position(userLocation.Latitude, userLocation.Longitude);

            map.MoveToRegion(MapSpan.FromCenterAndRadius(userPosition, Distance.FromMeters(100)));
            
        }
    }
}
