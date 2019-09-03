using System;
using System.Collections.Generic;
using Collector.ViewModels.Home;
using Collector.ViewModels.ViewModelLocator;
using Xamarin.Forms;

namespace Collector.Views.Home
{
    public partial class MainMateriasView : ContentPage
    {
        public MainMateriasView()
        {
            InitializeComponent();
            BindingContext = Locator.Instance.Resolve<MainMateriaisViewModel>();

        }
    }
}
