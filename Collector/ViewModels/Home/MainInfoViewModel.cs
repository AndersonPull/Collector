using System;
using System.Windows.Input;
using Collector.Services.Navigation;
using Collector.ViewModels.Login;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainInfoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MainInfoViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public ICommand SairCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<LoginViewModel>();
                });
            }
        }
    }
}
