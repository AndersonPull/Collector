using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.Models.Usuarios;

namespace Collector.Services.Usuarios
{
    public class UsuariosService
    {
        public async Task<List<UserModel>> UsuariosProximos()
        {
            return  new  List<UserModel>
            {
                new UserModel { Id = 0 , Name = "Marcia Silva Santos", NickName = "Marcia Catadora", Summary="", History="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Image="fotoPerfil.png", Phone="(11) 947743829", City = "Osasco" },
                new UserModel { Id = 1 , Name = "flavia Martins", NickName = "Martins", Summary="", History="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Image="fotoPerfil.png", Phone="(11) 947743333", City = "Osasco" },
                new UserModel { Id = 2 , Name = "Isis Oliveira", NickName = "Isis", Summary="", History="Sou catadora e amo o que faço, e não tem preço ajuda nosso mundo a melhorar", Image="fotoPerfil.png", Phone="(11) 947743825", City = "São Paulo" },
            };
        }
    }
}