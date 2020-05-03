using System;
using Collector.Models.Usuarios;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Collector.Models.Home
{
    public class MateriaisModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(UserModel))]
        public int IdUser { get; set; }

       [ManyToOne]
        public UserModel user { get; set; }

        public string Imagem { get; set; }

        public string Texto { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string IsAtived { get; set; }
    }
}