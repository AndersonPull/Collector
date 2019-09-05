using System;
using Collector.Services.Navigation;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class ListaDeUsuariosViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        //_service = new UsuarioService();
        //public FlowObservableCollection<UsuarioModel> Usuarios { get; set; }
        public ListaDeUsuariosViewModel(INavigationService serviceNavigation)
        {
            //Usuarios = new FlowObservableCollection<UsuarioModel>();
            //_service = new UsuarioService();
            _serviceNavigation = serviceNavigation;

        }
    }
}

