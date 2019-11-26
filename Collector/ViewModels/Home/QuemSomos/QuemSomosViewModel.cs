using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.QuemSomos
{
    public class QuemSomosViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public QuemSomosViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
