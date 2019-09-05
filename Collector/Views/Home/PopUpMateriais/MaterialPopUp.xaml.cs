
using Collector.ViewModels.Home.PopUpMateriais;
using Collector.ViewModels.ViewModelLocator;
using Rg.Plugins.Popup.Pages;

namespace Collector.Views.Home.PopUpMateriais
{
    public partial class MaterialPopUp : PopupPage
    {
        public MaterialPopUp()
        {
            InitializeComponent();
            BindingContext = Locator.Instance.Resolve<MaterialPopUpViewModel>();

        }
    }
}
