using System;

using Xamarin.Forms;

namespace Collector.Views.Home.Usuarios
{
    public class DetalhesUsuarioView : ContentPage
    {
        public DetalhesUsuarioView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

