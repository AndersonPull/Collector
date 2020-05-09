using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.Views.PopUpsAlerts
{
    public partial class PopUpSuccessView : PopupPage
    {
        public PopUpSuccessView(string title, string message)
        {
            InitializeComponent();
            Title.Text = title;
            Message.Text = message;
        }

        void Close(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}