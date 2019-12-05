using System;
using System.Collections.Generic;
using Collector.ViewModels.Home.Usuarios;
using Xamarin.Forms;

namespace Collector.Views.Home.Usuarios
{
    public partial class shimmer : ContentPage
    {
        public shimmer()
        {
            InitializeComponent();
            BindingContext = new shimmerViewModel();

        }
    }
}
