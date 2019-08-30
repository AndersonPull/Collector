using System;
using System.Windows.Input;
using Collector.Services.Navigation;
using Collector.ViewModels.Home;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class LoginViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public LoginViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<MainTabbedPageViewModel>();
                });
            }
        }

    }
}