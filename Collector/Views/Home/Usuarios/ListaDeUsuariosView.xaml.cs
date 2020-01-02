using System;
using System.Collections.Generic;
using Collector.ViewModels.Home.Usuarios;
using Xamarin.Forms;

namespace Collector.Views.Home.Usuarios
{
    public partial class ListaDeUsuariosView : ContentPage
    {
        public ListaDeUsuariosView()
        {
            NavigationPage.SetBackButtonTitle(this, "");
            InitializeComponent();
            BindingContext = new ListaDeUsuariosViewModel();
        }
    }
}
