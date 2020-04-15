using System;
using Collector.Services.Navigation;
using Collector.ViewModels.Home;
using Collector.ViewModels.Home.PopUpMateriais;
using Collector.ViewModels.Home.QuemSomos;
using Collector.ViewModels.Home.Usuarios;
using Collector.ViewModels.Login;
using Unity;

namespace Collector.ViewModels.ViewModelLocator
{
    public class Locator
    {
        private readonly IUnityContainer _container;

        private static readonly Locator _instance = new Locator();

        public static Locator Instance
        {
            get { return _instance; }
        }

        public Locator()
        {
            _container = new UnityContainer();

            //Registro de Interfaces
            _container.RegisterType<INavigationService, NavigationService>();

            //registro de ViewModel
            _container.RegisterType<AccessViewModel>();
            _container.RegisterType<MainTabbedPageViewModel>();
            _container.RegisterType<MainInfoViewModel>();
            _container.RegisterType<MainMapaViewModel>();
            _container.RegisterType<MainMateriaisViewModel>();
            _container.RegisterType<ListaDeUsuariosViewModel>();
            _container.RegisterType<MaterialPopUpViewModel>();
            _container.RegisterType<DetalhesDosUsuarioViewModel>();
            _container.RegisterType<QuemSomosViewModel>();
            _container.RegisterType<ParaOndeVAmosViewModel>();
            _container.RegisterType<ColaboreViewModel>();
            _container.RegisterType<BannerViewModel>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
