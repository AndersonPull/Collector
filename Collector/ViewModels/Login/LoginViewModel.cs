using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Login
{
    public class LoginViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public LoginViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}