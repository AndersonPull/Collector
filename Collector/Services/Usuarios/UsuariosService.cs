using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.Models.Usuarios;

namespace Collector.Services.Usuarios
{
    public class UsuariosService
    {
        public async Task<List<UsuarioModel>> UsuariosProximos()
        {
            return  new  List<UsuarioModel>
            {
                new UsuarioModel { Id = 0 , Nome = "Marcia Silva Santos", Apelido = "Marcia Catadora", Resumo="", Historia="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Imagem="fotoPerfil.png", Telefone="(11) 947743829", Cidade = "Osasco" },
                new UsuarioModel { Id = 1 , Nome = "flavia Martins", Apelido = "Martins", Resumo="", Historia="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Imagem="fotoPerfil.png", Telefone="(11) 947743333", Cidade = "Osasco" },
                new UsuarioModel { Id = 2 , Nome = "Isis Oliveira", Apelido = "Isis", Resumo="", Historia="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Imagem="fotoPerfil.png", Telefone="(11) 947743825", Cidade = "São Paulo" },
            };
        }

        public async Task<List<UsuarioModel>> UsuariosProximos1()
        {
            return new List<UsuarioModel>
            {
                new UsuarioModel { Id = 0 },
                new UsuarioModel { Id = 1 },
                new UsuarioModel { Id = 2  },
            };
        }
    }
}