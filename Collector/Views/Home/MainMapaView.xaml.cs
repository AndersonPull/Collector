using System;
using System.Collections.Generic;
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
            Position = new Position(35.71d, 139.81d)
        };

        readonly Pin _pinTokyo2 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_car.png"),
            Type = PinType.Place,
            Label = "Second Pin",
            Position = new Position(35.71d, 139.815d),
            ZIndex = 5
        };

        readonly Pin _pinTokyo3 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_coperativa.png"),
            Type = PinType.Place,
            Label = "Second Pin",
            Position = new Position(35.71d, 139.818d),
            ZIndex = 5
        };

        public MainMapaView()
        {
            InitializeComponent();
            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;
           
            map.Pins.Add(_pinTokyo);
            map.Pins.Add(_pinTokyo2);

            map.Pins.Add(_pinTokyo3);

            var locator = CrossGeolocator.Current;
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(35.71d, 139.815d),
                                                         Distance.FromMiles(2)));
            
                        BindingContext = Locator.Instance.Resolve<MainMapaViewModel>();
        }
    }
}
