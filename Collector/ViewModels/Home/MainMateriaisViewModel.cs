using System.Windows.Input;
using Collector.Models.Home;
using Collector.Services.Home;
using Collector.Services.Navigation;
using Collector.Views.Home.PopUpMateriais;
using DLToolkit.Forms.Controls;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainMateriaisViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<MateriaisModel> ItensMenu { get; set; }

        public MainMateriaisViewModel(INavigationService serviceNavigation)
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
        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async (value) =>
                {
                    MateriaisModel item = value as MateriaisModel;
                    ShowPopup(item);
                    
                });
            }
        }

        public async void ShowPopup(MateriaisModel item)
        {
            var pop = new MaterialPopUp(item);

            await PopupNavigation.Instance.PushAsync(pop, true);
        }
    }
}