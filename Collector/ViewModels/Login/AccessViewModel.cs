using System;
using System.Windows.Input;
using Collector.Services.Navigation;
using Collector.ViewModels.Home;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class AccessViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public AccessViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<BannerViewModel>();
                });
            }
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