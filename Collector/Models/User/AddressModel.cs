using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Collector.Models.Usuarios
{
    [Table("Address")]
    public class AddressModel 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public string Cep { get; set; }

        public string City { get; set; }

        public string Road { get; set; }

        public string HouseNumber { get; set; }
    }
}

