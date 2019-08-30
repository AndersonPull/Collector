using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home
{
    public class MainInfoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MainInfoViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
