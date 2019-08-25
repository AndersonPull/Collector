using System;
using Collector.Services.Navigation;
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
            _container.RegisterType<LoginViewModel>();
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
