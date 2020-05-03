using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector.Models.CreateAccount;
using Collector.Models.Usuarios;
using Collector.Services.Login;
using Collector.Services.Navigation;
using Collector.Views.Login;
using DLToolkit.Forms.Controls;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class CreateAcounteViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        PopUpLoadingMessageView loading;
        public static FlowObservableCollection<MessageRegistrationModel> Message1 { get; set; }
        public FlowObservableCollection<MessageRegistrationModel> Message { get; set; }
        private UserModel User;
        private CreateAccountService _service;
        public CreateAcounteViewModel(INavigationService serviceNavigation)
        {

            _serviceNavigation = serviceNavigation;
            _service = new CreateAccountService();
            Message = new FlowObservableCollection<MessageRegistrationModel>();
            Message1 = new FlowObservableCollection<MessageRegistrationModel>();
            User = new UserModel();

            IsEntry = "false";
            IsButtonTerm = "false";
            IsButtonConfirm = "false";

            _ = InitialMessage();

            Message.CollectionChanged += (sender, e) =>
            {
                Message1 = Message;
            };
        }

        private async Task InitialMessage()
        {
            loading = new PopUpLoadingMessageView();
            await PopupNavigation.Instance.PushAsync(loading);

            var message1 = await _service.InitialsMessages1();
            Message.Add(message1);

            var message2 = await _service.InitialsMessages2();
            Message.Add(message2);

            var message3 = await _service.InitialsMessages3();
            Message.Add(message3);

            IsEntry = "true";

            await loading.Close();
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

        public ICommand TermCommand
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
                   await  SendMessage(TextMenssage);
                });
            }
        }

        public async Task SendMessage( string message = null)
        {

            if (message != null)
            {
                Message.Add(new MessageRegistrationModel()
                {
                    Id = Message.Count,
                    Message = message,
                    Type1 = "false",
                    Type2 = "true",
                    Type3 = "false"
                });

                TextMenssage = null;
            }

            switch (Message.Count)
            {
                case 4:
                    loading = new PopUpLoadingMessageView();
                    await PopupNavigation.Instance.PushAsync(loading);

                    IsEntry = "false";
                    User.Name = message;
                    var termMessage = await _service.MessageTerm();
                    termMessage.Id = Message.Count;
                    Message.Add(termMessage);
                    IsButtonTerm = "true";

                    await loading.Close();

                    break;

                case 8:
                    loading = new PopUpLoadingMessageView();
                    await PopupNavigation.Instance.PushAsync(loading);

                    User.NickName = message;
                    var passwordMessage = await _service.PasswordMessage();
                    passwordMessage.Id = Message.Count;
                    Message.Add(passwordMessage);
                    await loading.Close();
                    break;

                case 10:
                    loading = new PopUpLoadingMessageView();
                    await PopupNavigation.Instance.PushAsync(loading);

                    User.Password = message;
                    var cepMessage = await _service.CepMessage();
                    cepMessage.Id = Message.Count;
                    Message.Add(cepMessage);

                    await loading.Close();
                    break;

                case 12:
                    loading = new PopUpLoadingMessageView();
                    await PopupNavigation.Instance.PushAsync(loading);

                    var address = await _service.GetAdrress(message);

                    User.Cep = address.Cep;
                    User.City = address.City;
                    User.Uf = address.Uf;
                    User.Road = address.Road;

                    var roadMessage = await _service.HomeNumberMessage();
                    roadMessage.Id = Message.Count;
                    Message.Add(roadMessage);

                    await loading.Close();
                    break;
                case 14:
                    loading = new PopUpLoadingMessageView();
                    await PopupNavigation.Instance.PushAsync(loading);

                    User.HouseNumber = message;
                    IsEntry = "false";
                    IsButtonConfirm = "true";

                    await loading.Close();
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
                   await AcceptTerm();
                });
            }
        }

        private async Task AcceptTerm()
        {
            IsButtonTerm = "false";

            User.Term = true;

            var ConfirmTermMessage = await _service.ConfirmTerm();
            ConfirmTermMessage.Id = Message.Count;
            Message.Add(ConfirmTermMessage);

            loading = new PopUpLoadingMessageView();
            await PopupNavigation.Instance.PushAsync(loading);

            var ConfirmedTermMessage = await _service.ConfirmedTerm();
            ConfirmedTermMessage.Id = Message.Count;
            Message.Add(ConfirmedTermMessage);

            IsEntry = "true";
            await loading.Close();

        }

        public ICommand AcceptCommand
        {
            get
            {
                return new Command(async () =>
                {
                    _ = SaveUSer();
                });
            }
        }

        private async Task SaveUSer()
        {
            var save = await _service.SaveUser(User);

            if (save)
                await _serviceNavigation.NavigateToAsync<AccessViewModel>();
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