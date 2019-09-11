using System;
namespace Collector.Models.Usuarios
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Imagem { get; set; }

        public string Cidade { get; set; }

        public string Resumo { get; set; }

        public string Historia { get; set; }

        public string Telefone { get; set; }

        public bool MaisDetalhes { get; set; }
    }
}