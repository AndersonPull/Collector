using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home
{
    public class MainMapaViewModel: BaseVM
    {
        INavigationService _serviceNavigation;
        public MainMapaViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
