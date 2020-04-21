using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.CreateAccount;
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

            IsEntry = "true";
            IsButtonTerm = "false";
            IsButtonConfirm = "false";

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
            IsEntry = "true";
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
                    var termMessage = _service.MessageTerm();
                    termMessage.Id = _message.Count;
                    _message.Add(termMessage);

                    IsEntry = "false";

                    IsButtonTerm = "true";
                    break;

                case 8:
                    var passwordMessage = _service.PasswordMessage();
                    passwordMessage.Id = _message.Count;
                    _message.Add(passwordMessage);
                    break;

                case 10:
                    
                    var cepMessage = _service.CepMessage();
                    cepMessage.Id = _message.Count;
                    _message.Add(cepMessage);

                    break;

                case 12:

                    IsEntry = "false";
                    IsButtonConfirm = "true";
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }            
        }

        public ICommand AcceptTermCommand
        {
            get
            {
                return new Command(async () =>
                {
                    AcceptTerm();
                });
            }
        }

        private void AcceptTerm()
        {
            var ConfirmTermMessage = _service.ConfirmTerm();
            ConfirmTermMessage.Id = _message.Count;
            _message.Add(ConfirmTermMessage);


            var ConfirmedTermMessage = _service.ConfirmedTerm();
            ConfirmedTermMessage.Id = _message.Count;
            _message.Add(ConfirmedTermMessage);

            IsButtonTerm = "false";

            IsEntry = "true";

        }

        private string textMenssage;
        public string TextMenssage { get { return textMenssage; } set { this.Set("TextMenssage", ref textMenssage, value); } }

        private string isEntry;
        public string IsEntry { get { return isEntry; } set { this.Set("IsEntry", ref isEntry, value); } }

        private string isButtonTerm;
        public string IsButtonTerm { get { return isButtonTerm; } set { this.Set("IsButtonTerm", ref isButtonTerm, value); } }

        private string isButtonConfirm;
        public string IsButtonConfirm { get { return isButtonConfirm; } set { this.Set("IsButtonConfirm", ref isButtonConfirm, value); } }

    }
}