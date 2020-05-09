using System;
using Collector.Models.Usuarios;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Collector.Models.Home
{
    public class MateriaisModel
    {
        [PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(UserModel))]
        public int IdUser { get; set; }

       [ManyToOne]
        public UserModel User { get; set; }

        public string IconGreen { get; set; }

        public string IconWhite { get; set; }

        public string Texto { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public bool IsAtived { get; set; }

        public bool NoAtived { get; set; }
    }
}