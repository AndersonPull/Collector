
using System;
using Collector.Models.Home;
using Collector.ViewModels.Home.PopUpMateriais;
using Collector.ViewModels.ViewModelLocator;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace Collector.Views.Home.PopUpMateriais
{
    public partial class MaterialPopUp : PopupPage
    {
        public MaterialPopUp(MateriaisModel item )
        {
            InitializeComponent();

            TituloPrincipal.Text = item.Texto;
            Imagem.Source = item.IconGreen;
            Titulo.Text = item.Titulo;
            Descricao.Text = item.Descricao;
        }

        public void FecharModal(object sender, EventArgs args)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}