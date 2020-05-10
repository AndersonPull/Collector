using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.Home;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Services.Usuarios;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class ListaDeUsuariosViewModel : BaseVM
    {
        UsuariosService _service;
        public FlowObservableCollection<UserModel> Usuarios { get; set; }
        INavigationService _serviceNavigation;
        public ListaDeUsuariosViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
            Usuarios = new FlowObservableCollection<UserModel>();
            _service = new UsuariosService();
            _ = CarregarListaUsuarios();
        }

        public async Task CarregarListaUsuarios()
        {
            var users = await _service.UsuariosProximos();


            foreach (var user in users)
            {
                if (user.IsCollector)
                {
                    user.CollectorItemsView.AddRange(user.CollectorItens);
                    Usuarios.Add(user);
                }
                    
                    
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
                    UserModel user = value as UserModel;

                    if (user.Details == false)
                        user.Details = true;
                    else
                        user.Details = false;

                    Animar(user);
                });
            }
        }

        public void Animar(UserModel user)
        {
            var index = Usuarios.IndexOf(user);
            Usuarios.Remove(user);
            Usuarios.Insert(index, user);
        }
    }
}