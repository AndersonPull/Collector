using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Collector.Models.Usuarios
{
    [Table("Users")]
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public string Image { get; set; }

        public string Cep { get; set; }

        public string City { get; set; }

        public string Road { get; set; }

        public string HouseNumber { get; set; }

        public string Summary { get; set; }

        public string History { get; set; }

        public string Phone { get; set; }

        public bool Details { get; set; }

        public bool IsCollector { get; set; }

        public bool Term { get; set; }
    }
}
