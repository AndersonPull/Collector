using System;
using Collector.Models.Home;
using Collector.Services.Home;
using Collector.Services.Navigation;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainMateriaisViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<BotoesMateriaisModel> ItensMenu { get; set; }

        public MainMateriaisViewModel(INavigationService serviceNavigation)
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
    }
}
