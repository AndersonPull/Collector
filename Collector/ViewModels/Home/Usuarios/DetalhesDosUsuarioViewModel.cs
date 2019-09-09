using System;
using System.Windows.Input;
using Collector.Models.Home;
using Collector.Services.Home;
using Collector.Services.Navigation;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class DetalhesDosUsuarioViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<MateriaisModel> ItensMenu { get; set; }
        public DetalhesDosUsuarioViewModel(INavigationService serviceNavigation)
        {
            ItensMenu = new FlowObservableCollection<MateriaisModel>();
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
