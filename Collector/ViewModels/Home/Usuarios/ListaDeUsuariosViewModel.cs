using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Services.Usuarios;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class ListaDeUsuariosViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        UsuariosService _service;
        public FlowObservableCollection<UsuarioModel> Usuarios { get; set; }
        public ListaDeUsuariosViewModel(INavigationService serviceNavigation)
        {
            Usuarios = new FlowObservableCollection<UsuarioModel>();
            _service = new UsuariosService();
            _serviceNavigation = serviceNavigation;
            CarregarListaUsuarios();
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
                return new Command(async (value) =>
                {
                    UsuarioModel _usuario = value as UsuarioModel;

                    if (_usuario.MaisDetalhes == false)
                    {
                        _usuario.MaisDetalhes = true;
                    }
                    else
                    {
                        _usuario.MaisDetalhes = false;
                    }

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
    }
}