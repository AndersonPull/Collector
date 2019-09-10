using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Collector.Views.Home.Usuarios
{
    public partial class ListaDeUsuariosView : ContentPage
    {
        public ListaDeUsuariosView()
        {
            InitializeComponent();

        }
        public void DetalhesModal(object sender, EventArgs args)
        {
            if(ModalDetalhes.IsVisible == true)
            {
                ModalDetalhes.IsVisible = false;
            }
            else
            {
                ModalDetalhes.IsVisible = true;
            }
        }
    }
}
