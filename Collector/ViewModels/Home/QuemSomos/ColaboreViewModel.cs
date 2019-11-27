using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.QuemSomos
{
    public class ColaboreViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public ColaboreViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
