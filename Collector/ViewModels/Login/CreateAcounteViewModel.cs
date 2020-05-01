using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector._Datas;
using Collector.Models.CreateAccount;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.Services.Usuarios;
using Collector.Views.Login;
using DLToolkit.Forms.Controls;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class CreateAcounteViewModel : BaseVM
    {
         INavigationService _serviceNavigation;
         MessageRegistrationService _service;

        public static FlowObservableCollection<MessageRegistrationModel> Message1 { get; set; }

        public FlowObservableCollection<MessageRegistrationModel> Message { get; set; }

        private UserModel User;

        private BaseData Data;

        public CreateAcounteViewModel(INavigationService serviceNavigation)
        {

            _serviceNavigation = serviceNavigation;
            _service = new MessageRegistrationService();
            Message = new FlowObservableCollection<MessageRegistrationModel>();
            Message1 = new FlowObservableCollection<MessageRegistrationModel>();
            User = new UserModel();
            Data = new BaseData();

            IsEntry = "true";
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
           // await ShowPopup();

            var message1 = await _service.InitialsMessages1();
            Message.Add(message1);

            var message2 = await _service.InitialsMessages2();
            Message.Add(message2);

            var message3 = await _service.InitialsMessages3();
            Message.Add(message3);

            IsEntry = "true";

          //  await RemovePopup();
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
                  //  await ShowPopup();
                    IsEntry = "false";
                    User.Name = message;
                    var termMessage = await _service.MessageTerm();
                    termMessage.Id = Message.Count;
                    Message.Add(termMessage);
                    IsButtonTerm = "true";
                 //   await RemovePopup();
                    break;

                case 8:
                    //  await ShowPopup();
                    User.NickName = message;
                    var passwordMessage = await _service.PasswordMessage();
                    passwordMessage.Id = Message.Count;
                    Message.Add(passwordMessage);
                  //  await RemovePopup();
                    break;

                case 10:
                    //    await ShowPopup();
                    User.Password = message;
                    var cepMessage = await _service.CepMessage();
                    cepMessage.Id = Message.Count;
                    Message.Add(cepMessage);
                //    await RemovePopup();
                    break;

                case 12:
                    //    await ShowPopup();
                    var address = await _service.GetAdrress(message);

                    User.Cep = address.Cep;
                    User.City = address.City;
                    User.Uf = address.Uf;
                    User.Road = address.Road;

                    var roadMessage = await _service.HomeNumberMessage();
                    roadMessage.Id = Message.Count;
                    Message.Add(roadMessage);
                    //    await RemovePopup();
                    break;
                case 14:
                    //    await ShowPopup();
                    User.HouseNumber = message;
                    IsEntry = "false";
                    IsButtonConfirm = "true";
                    //    await RemovePopup();
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

          //  await ShowPopup();
            var ConfirmedTermMessage = await _service.ConfirmedTerm();
            ConfirmedTermMessage.Id = Message.Count;
            Message.Add(ConfirmedTermMessage);

            IsEntry = "true";
          //  await RemovePopup();

        }

        public ICommand AcceptCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Data.Save(User);
                    await _serviceNavigation.NavigateToAsync<AccessViewModel>();
                });
            }
        }

        public async Task ShowPopup()
        { 
            await PopupNavigation.Instance.PushAsync(new PopUpLoadingMessageView());
        }

        public async Task RemovePopup()
        {
            await PopupNavigation.Instance.PopAsync();
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