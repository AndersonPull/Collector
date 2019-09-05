using System;
using System.Windows.Input;
using Collector.Services.Navigation;
using Collector.ViewModels.Home.Usuarios;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainMapaViewModel: BaseVM
    {
        INavigationService _serviceNavigation;
        public MainMapaViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public ICommand NavegarLista
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<ListaDeUsuariosViewModel>();
                });
            }
        }
    }
}