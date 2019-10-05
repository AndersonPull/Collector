using System;
using System.Collections.Generic;
using Collector.ViewModels.Home;
using Collector.ViewModels.ViewModelLocator;
using Xamarin.Forms;

namespace Collector.Views.Home
{
    public partial class MainMapaView : ContentPage
    {
        public MainMapaView()
        {
            InitializeComponent();
            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;
            BindingContext = Locator.Instance.Resolve<MainMapaViewModel>();
        }
    }
}
