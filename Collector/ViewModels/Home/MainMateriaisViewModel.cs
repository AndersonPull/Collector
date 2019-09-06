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
        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async (value) =>
                {
                    BotoesMateriaisModel item = value as BotoesMateriaisModel;
                    switch (item.Id)
                    {
                        case 1:
                            PopupNavigation.Instance.PushAsync(new MaterialPopUp(), true);
                            break;
                        case 2:
                            PopupNavigation.Instance.PushAsync(new MaterialPopUp(), true);
                            break;
                        case 3:
                            PopupNavigation.Instance.PushAsync(new MaterialPopUp(), true);
                            break;
                        case 4:
                            PopupNavigation.Instance.PushAsync(new MaterialPopUp(), true);
                            break;
                        case 5:
                            PopupNavigation.Instance.PushAsync(new MaterialPopUp(), true);
                            break;
                        default:
                            break;
                    }
                });
            }
        }
    }
}
