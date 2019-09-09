using System;
using System.Collections.Generic;
using Collector.ViewModels.Home;
using Collector.ViewModels.ViewModelLocator;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Collector.Views.Home
{
    public partial class MainInfoView : ContentPage
    {
        public MainInfoView()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(false);
            BindingContext = Locator.Instance.Resolve<MainInfoViewModel>();

        }
    }
}
