using System;
using System.Windows.Input;
using Collector.Models.Home;
using Collector.Services.Home;
using Collector.Services.Navigation;
using Collector.ViewModels.Login;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainInfoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<BotoesMateriaisModel> ItensMenu { get; set; }

        public MainInfoViewModel(INavigationService serviceNavigation)
        {

            ItensMenu = new FlowObservableCollection<BotoesMateriaisModel>();
            _service = new MenuService();
            _serviceNavigation = serviceNavigation;

            CarregarMenu();
        }

        public void CarregarMenu()
        {
            var collection = _service.ItensMenu();
            foreach (var item in collection)
            {
                ItensMenu.Add(item);
            }
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
