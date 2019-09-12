using System.Threading.Tasks;
using Collector.Models.Home;
using Collector.Services.Navigation;

namespace Collector.ViewModels.Home.PopUpMateriais
{
    public class MaterialPopUpViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public MaterialPopUpViewModel(object navigationData, INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is MateriaisModel)
            {
                TituloPrincipal = ((MateriaisModel)navigationData).Texto;
                Imagem = ((MateriaisModel)navigationData).Imagem;
                Titulo = ((MateriaisModel)navigationData).Titulo;
                Descricao = ((MateriaisModel)navigationData).Descricao;
            }
            return base.InitializeAsync(navigationData);
        }

        private string tituloPrincipal = string.Empty;
        public string TituloPrincipal { get { return tituloPrincipal; } set { this.Set("TituloPrincipal", ref tituloPrincipal, value); } }

        private string imagem;
        public string Imagem { get { return imagem; } set { this.Set("Imagem", ref imagem, value); } }

        private string titulo = string.Empty;
        public string Titulo { get { return titulo; } set { this.Set("Titulo", ref titulo, value); } }

        private string descricao = string.Empty;
        public string Descricao { get { return descricao; } set { this.Set("Descricao", ref descricao, value); } }
    }
}