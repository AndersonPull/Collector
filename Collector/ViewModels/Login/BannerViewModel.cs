using System;
using System.Windows.Input;
using Collector.Services.Navigation;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class BannerViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public BannerViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<AccessViewModel>();
                });
            }
        }

        public ICommand CreateAcountCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<CreateAcounteViewModel>();

                });
            }
        }
    }
}