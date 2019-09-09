using System;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.Usuarios
{
    public class DetalhesDosUsuarioViewModel : BaseVM
    {
        INavigationService _serviceNavigation;

        public DetalhesDosUsuarioViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;

        }
    }
}
