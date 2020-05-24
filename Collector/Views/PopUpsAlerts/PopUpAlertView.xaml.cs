using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.Views.PopUpsAlerts
{
    public partial class PopUpAlertView : PopupPage
    {
        public PopUpAlertView(string title, string message)
        {
            InitializeComponent();
            Title.Text = title;
            Message.Text = message;
        }

        void Close(object sender, EventArgs args)
        {
             PopupNavigation.Instance.PopAsync();
        }
    }
}
