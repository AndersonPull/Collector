using System.Windows.Input;
using Collector.Models.Home;
using Collector.Services.Home;
using Collector.Services.Navigation;
using Collector.ViewModels.Home.QuemSomos;
using Collector.ViewModels.Login;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainInfoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<MateriaisModel> ItensMenu { get; set; }
        public MainInfoViewModel(INavigationService serviceNavigation)
        {
            ItensMenu = new FlowObservableCollection<MateriaisModel>();
            _service = new MenuService();
            _serviceNavigation = serviceNavigation;
            CarregarMenu();
        }

        public void CarregarMenu()
        {
            var collection = _service.ItensMenu();
            ItensMenu.AddRange(collection);
        }

        public ICommand SairCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<AccessViewModel>();
                });
            }
        }

        public ICommand QuemSomosCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<QuemSomosViewModel>();
                });
            }
        }

        public ICommand ParaOndeVamosCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<ParaOndeVAmosViewModel>();
                });
            }
        }

        public ICommand ColaboreCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<ColaboreViewModel>();
                });
            }
        }
    }
}