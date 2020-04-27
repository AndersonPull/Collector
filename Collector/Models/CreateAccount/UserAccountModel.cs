using System;
namespace Collector.Models.CreateAccount
{
    public class UserAccountModel
    {
        //Basic registrationsic

        public int Id { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Cep { get; set; }

        public string HouseNumber { get; set; }

        public bool Term { get; set; }
    }
}