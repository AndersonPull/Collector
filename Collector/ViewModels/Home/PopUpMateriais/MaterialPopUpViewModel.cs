using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.PopUpMateriais
{
    public class MaterialPopUpViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MaterialPopUpViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}