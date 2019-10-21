using System.Threading.Tasks;
using Collector.ViewModels.Home;
using Collector.ViewModels.ViewModelLocator;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace Collector.Views.Home
{
    public partial class MainMapaView : ContentPage
    {


        readonly Pin _pin1 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_carroca.png"),
            Type = PinType.Place,
            Label = "pin 1",
            Position = new Position(-23.558419, -46.660071)
        };

        readonly Pin _pin2 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_car.png"),
            Type = PinType.Place,
            Label = "pin 2",
            Position = new Position(-23.557969, -46.660549),
            ZIndex = 5
        };

        readonly Pin _pin3 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_coperativa.png"),
            Type = PinType.Place,
            Label = "pin 3",
            Position = new Position(-23.559064, -46.661170),
            ZIndex = 5
        };

        readonly Pin _pin4 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_PEV.png"),
            Type = PinType.Place,
            Label = "pin 4",
            Position = new Position(-23.558139, -46.661651),
            ZIndex = 5
        };

        readonly Pin _pin5 = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("pin_ferroVelho.png"),
            Type = PinType.Place,
            Label = "pin 5",
            Position = new Position(-23.559831, -46.658623),
            ZIndex = 5
        };

        public MainMapaView()
        {
            ObterPosicaoAtual();

            InitializeComponent();
            map.MyLocationEnabled = true;

            map.Pins.Add(_pin1);
            map.Pins.Add(_pin2);
            map.Pins.Add(_pin3);
            map.Pins.Add(_pin4);
            map.Pins.Add(_pin5);

            BindingContext = Locator.Instance.Resolve<MainMapaViewModel>();
        }

        public async Task ObterPosicaoAtual()
        {

            var userLocation = await Xamarin.Essentials.Geolocation.GetLocationAsync();

            var userPosition = new Position(userLocation.Latitude, userLocation.Longitude);

            map.MoveToRegion(MapSpan.FromCenterAndRadius(userPosition, Distance.FromMeters(300)));
            
        }
    }
}
