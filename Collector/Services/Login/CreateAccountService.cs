using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Collector._Datas;
using Collector.Models.CreateAccount;
using Collector.Models.Usuarios;
using Collector.Views.PopUpsAlerts;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.Services.Login
{
    public class CreateAccountService
    {
        BaseData Data;
        public CreateAccountService()
        {
            Data = new BaseData();
        }

        public async Task<bool> SaveUser(UserModel user)
        {
            try
            {
                var users = Data.GetList<UserModel>(true);

                var ValidUser = users.Where(a => a.NickName == user.NickName).FirstOrDefault();

                if (ValidUser == null)
                {
                    Data.Insert(user);
                    return true;
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new PopUpAlertView("NickName Não está disponivel", "escolha outro nickname para sua conta"), true);
                    return false;
                }

            }
            catch (Exception e)
            {
                await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Algo de errado com a internet!", e.ToString()), true);
            }
            return false;
        }

        public async Task<MessageRegistrationModel> InitialsMessages1()
        {
            await Task.Delay(1000);

            return new MessageRegistrationModel
            {
                Message = "Olá! 😄",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false"
            };
        }

        public async Task<MessageRegistrationModel> InitialsMessages2()
        {
            await Task.Delay(2000);

            return new MessageRegistrationModel
            {
                Message = "Que bom ter você aqui, vamos criar sua conta?",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false"
            };
        }

        public async Task<MessageRegistrationModel> InitialsMessages3()
        {
            await Task.Delay(2000);

            return new MessageRegistrationModel
            {
                Message = "Escreva seu nome completo, para registrarmos.",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false"
            };
        }

        public async Task<MessageRegistrationModel> MessageTerm()
        {
            await Task.Delay(3000);

            return new MessageRegistrationModel()
            {
                Message = "Para continuar você poderia ler e aceitar nossos termos de uso e politicas de privacidade?",
                Type1 = "false",
                Type2 = "false",
                Type3 = "true"
            };
        }

        public async Task<MessageRegistrationModel> ConfirmTerm()
        {

            return new MessageRegistrationModel()
            {
                Message = "👍",
                Type1 = "false",
                Type2 = "true",
                Type3 = "false",
                EditButton = "false"
            };
        }

        public async Task<MessageRegistrationModel> ConfirmedTerm()
        {
            await Task.Delay(1000);

            return new MessageRegistrationModel()
            {
                Message = "Agora escolha um nome ou apelido para realizar o login no nosso app",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
            };
        }

        public async Task<MessageRegistrationModel> PasswordMessage()
        {
            await Task.Delay(1000);

            return new MessageRegistrationModel()
            {
                Message = "Agora escolha uma senha",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
            };
        }

        public async Task<MessageRegistrationModel> CepMessage()
        {
            await Task.Delay(2000);

            return new MessageRegistrationModel()
            {
                Message = "Para localizarmos os collectors mais proximos de você precisamos do seu cep, você pode digitalo",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
            };
        }

        public async Task<MessageRegistrationModel> HomeNumberMessage()
        {
            await Task.Delay(1000);

            return new MessageRegistrationModel()
            {
                Message = "para finalizarmos digite o numero da sua casa.",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
            };
        }

        public async Task<UserModel> GetAdrress(string cep)
        {
            try
            {
                var result = new UserModel();

                using (HttpClient client = new HttpClient())
                {
                    var oTaskPostAsync = await client.GetAsync("https://viacep.com.br/ws/" + cep + "/json");

                    if (oTaskPostAsync.IsSuccessStatusCode)
                    {
                        var ret = await oTaskPostAsync.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<UserModel>(ret);
                    }
                    else
                        await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Cep não encontrado", "Verifique o cep digitado"), true);
                }
            }
            catch (TimeoutException ex)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Algo de errado com a internet!", "Nao foi possivel conectar com o servidor."), true);
                });
            }

            catch (TaskCanceledException ex)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Algo de errado com a internet!", "Nao foi possivel conectar com o servidor."), true);
                });
            }
            catch (Exception ex)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Algo de errado com a internet!", "Nao foi possivel conectar com o servidor."), true);
                });
            }

            return null;
        }
    }
}
