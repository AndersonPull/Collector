using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.QuemSomos
{
    public class ParaOndeVAmosViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public ParaOndeVAmosViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}

