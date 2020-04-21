using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.Models.CreateAccount;

namespace Collector.Services.Usuarios
{
    public class MessageRegistrationService
    {
        public async Task<List<MessageRegistrationModel>> InitialsMessages()
        {

            return new  List<MessageRegistrationModel>
            {
                new MessageRegistrationModel { Message ="Olá 1😄", Type1 = "true", Type2 = "false", Type3 = "false"},
                new MessageRegistrationModel { Message ="Que bom ter você aqui, vamos criar sua conta?", Type1 = "true", Type2 = "false", Type3 = "false"},
                new MessageRegistrationModel { Message ="Escreva seu nome completo, para registrarmos.", Type1 = "true", Type2 = "false", Type3 = "false"}
            };

        }

        public MessageRegistrationModel MessageTerm()
        {
            return new MessageRegistrationModel()
            {
                Message = "Para continuar você poderia ler e aceitar nossos termos de uso e politicas de privacidade?",
                Type1 = "false",
                Type2 = "false",
                Type3 = "true"
            };
        }

        public MessageRegistrationModel ConfirmTerm()
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

        public MessageRegistrationModel ConfirmedTerm()
        {
            return new MessageRegistrationModel()
            {
                Message = "Agora escolha um nome ou apelido para realizar o login no nosso app",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
                EditButton = "false"
            };
        }

        public MessageRegistrationModel PasswordMessage()
        {
            return new MessageRegistrationModel()
            {
                Message = "Agora escolha uma senha",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
                EditButton = "false"
            };
        }

        public MessageRegistrationModel CepMessage()
        {
            return new MessageRegistrationModel()
            {
                Message = "Para localizarmos os collectors mais proximos de você precisamos do seu cep, você pode digitalo",
                Type1 = "true",
                Type2 = "false",
                Type3 = "false",
                EditButton = "false"
            };
        }
    }
}
