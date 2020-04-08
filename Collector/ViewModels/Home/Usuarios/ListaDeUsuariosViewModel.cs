using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Services.Usuarios;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class ListaDeUsuariosViewModel : BindableObject
    {
        NavigationService _serviceNavigation;
        UsuariosService _service;
        public FlowObservableCollection<UsuarioModel> Usuarios { get; set; }
        public ListaDeUsuariosViewModel()
        {
            Usuarios = new FlowObservableCollection<UsuarioModel>();
            _serviceNavigation = new NavigationService();
            _service = new UsuariosService();
            PerformShimmerTaskAsync();
        }

        public async Task CarregarListaUsuarios()
        {
            var usuariosProximos = await _service.UsuariosProximos();
            foreach (var usuario in usuariosProximos)
            {
                Usuarios.Add(usuario);
            }
        }

        public ICommand NavegarParaDetalhes => new Command(async (value) =>
        {
            await _serviceNavigation.NavigateToAsync<DetalhesDosUsuarioViewModel>();
        });

        public ICommand UsuarioSelecionado
        {
            get
            {
                return new Command( (value) =>
                {
                    UsuarioModel _usuario = value as UsuarioModel;

                    if (_usuario.MaisDetalhes == false)
                        _usuario.MaisDetalhes = true;
                    else
                        _usuario.MaisDetalhes = false;

                    Animar(_usuario);
                });
            }
        }

        public void Animar(UsuarioModel usuario)
        {
            var index = Usuarios.IndexOf(usuario);
            Usuarios.Remove(usuario);
            Usuarios.Insert(index, usuario);
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }        

        private async Task PerformShimmerTaskAsync()
        {

            var usuariosProximos = await _service.UsuariosProximos();
            foreach (var usuario in usuariosProximos)
            {
                usuario.IsBusy = true;
                Usuarios.Add(usuario);
            }

            this.IsBusy = true;

            await Task.Delay(3000);

            this.IsBusy = false;

            var usuariosProximos1 = await _service.UsuariosProximos();

            Usuarios.Clear();

            foreach (var usuario in usuariosProximos1)
                Usuarios.Add(usuario);
        }
    }
}