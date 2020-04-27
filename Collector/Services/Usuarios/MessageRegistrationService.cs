using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.Models.CreateAccount;

namespace Collector.Services.Usuarios
{
    public class MessageRegistrationService
    {
        public async Task<bool> AddressUser()
        {
            return true;
        }

        public async Task<MessageRegistrationModel> InitialsMessages1()
        {
            await Task.Delay(1000);

            return new  MessageRegistrationModel
            {
                Message ="Olá! 😄",
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
                Message = "para finalizarmos digite o nnumero da sua casa.",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
            };
        }
    }
}
