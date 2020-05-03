using System.Threading.Tasks;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home
{
    public class MainTabbedPageViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MainTabbedPageViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}