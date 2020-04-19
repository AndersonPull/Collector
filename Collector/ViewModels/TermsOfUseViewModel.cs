using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels
{
    public class TermsOfUseViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public TermsOfUseViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
