using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace Collector.Views.shared
{
    public partial class LoadingView : PopupPage
    {
        public LoadingView()
        {
            InitializeComponent();
        }

        public async Task Close()
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}
