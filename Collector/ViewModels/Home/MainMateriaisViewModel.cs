using System;
using Collector.Services.Navigation;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainMateriaisViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MainMateriaisViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
