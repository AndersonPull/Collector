using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.Views.Login
{
    public partial class PopUpLoadingMessageView : PopupPage
    {
        public PopUpLoadingMessageView()
        {
            InitializeComponent();
        }

        public async Task Close()
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}