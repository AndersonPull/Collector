using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
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
    }
}
