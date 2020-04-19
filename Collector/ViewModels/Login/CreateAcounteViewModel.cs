using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.Login;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Views;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class CreateAcounteViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public FlowObservableCollection<MessageRegistrationModel> _message { get; set; }
        public CreateAcounteViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
            _message = new FlowObservableCollection<MessageRegistrationModel>();
            _ = InitialMessage();
        }

        private async Task InitialMessage()
        {
            MessageRegistrationModel mesageTeste = new MessageRegistrationModel();
            mesageTeste.Message = "Olá 1😄";
            mesageTeste.Type1 = "true";
            mesageTeste.Type2 = "false";
            mesageTeste.Type3 = "false";

            MessageRegistrationModel mesageTeste1 = new MessageRegistrationModel();
            mesageTeste1.Message = "Que bom ter você aqui, vamos criar sua conta?";
            mesageTeste1.Type1 = "true";
            mesageTeste1.Type2 = "false";
            mesageTeste1.Type3 = "false";

            MessageRegistrationModel mesageTeste2 = new MessageRegistrationModel();
            mesageTeste2.Message = "Anderson Oliveira Bezerra";
            mesageTeste2.Type1 = "false";
            mesageTeste2.Type2 = "true";
            mesageTeste2.Type3 = "false";

            MessageRegistrationModel mesageTeste3 = new MessageRegistrationModel();
            mesageTeste3.Message = "Para continuar você poderia ler e aceitar nossos termos de uso e politicas de privacidade?";
            mesageTeste3.Type1 = "false";
            mesageTeste3.Type2 = "false";
            mesageTeste3.Type3 = "true";

            _message.Add(mesageTeste);

            _message.Add(mesageTeste1);

            _message.Add(mesageTeste2);

            _message.Add(mesageTeste3);

        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<BannerViewModel>();
                });
            }
        }

        public ICommand TermsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<TermsOfUseViewModel>();
                });
            }
        }
    }
}