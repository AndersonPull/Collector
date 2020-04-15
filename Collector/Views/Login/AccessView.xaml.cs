using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Collector.Views.Login
{
    public partial class AccessView : ContentPage
    {
        public AccessView()
        {
            InitializeComponent();
        }

        private void EmailFocus(Object sender, EventArgs args)
        {
            EmailEntry.Focus();
        }

        private void PasswordFocus(Object sender, EventArgs args)
        {
            PasswordEntry.Focus();
        }
    }
}
