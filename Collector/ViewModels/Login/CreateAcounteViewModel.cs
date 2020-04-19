using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.Login;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Services.Usuarios;
using Collector.Views;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class CreateAcounteViewModel : BaseVM
    {
        INavigationService _serviceNavigation;

        MessageRegistrationService _service;

        public static FlowObservableCollection<MessageRegistrationModel> _message1 { get; set; }

        public FlowObservableCollection<MessageRegistrationModel> _message { get; set; }


        public CreateAcounteViewModel(INavigationService serviceNavigation)
        {

            _serviceNavigation = serviceNavigation;
            _service = new MessageRegistrationService();
            _message = new FlowObservableCollection<MessageRegistrationModel>();
            _message1 = new FlowObservableCollection<MessageRegistrationModel>();
            _ = InitialMessage();

            _message.CollectionChanged += (sender, e) =>
            {
                _message1 = _message;
            };

        }

        private async Task InitialMessage()
        {
            var Messages = await _service.InitialsMessages();

            foreach(var message in Messages)
            {
                message.Id = _message.Count;
                _message.Add(message);
            }
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

        public ICommand SendCommand
        {
            get
            {
                return new Command(async () =>
                {
                    SendMessage(TextMenssage);
                });
            }
        }

        public async Task SendMessage( string message = null)
        {

            if (message != null)
            {
                _message.Add(new MessageRegistrationModel()
                {
                    Id = _message.Count,
                    Message = message,
                    Type1 = "false",
                    Type2 = "true",
                    Type3 = "false"
                });

                TextMenssage = null;
            }

            switch (_message.Count)
            {
                case 4:
                    var nameUser = _message[3].Message;
                    var teste = nameUser;
                    var termMessage = _service.MessageTerm();
                    termMessage.Id = _message.Count;
                    _message.Add(termMessage);
                    break;
                case 5:
                    
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            
        }

        private string textMenssage;
        public string TextMenssage { get { return textMenssage; } set { this.Set("TextMenssage", ref textMenssage, value); } }

        private FlowListView listMassage;
        public FlowListView ListMassage { get { return listMassage; } set { this.Set("ListMassage", ref listMassage, value); } }

    }
}