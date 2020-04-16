using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Login
{
    public class CreateAcounteViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public CreateAcounteViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}