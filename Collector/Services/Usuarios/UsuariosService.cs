using System.Collections.Generic;
using System.Threading.Tasks;
using Collector._Datas;
using Collector.Models.Usuarios;

namespace Collector.Services.Usuarios
{
    public class UsuariosService
    {

        BaseData Data;
        public UsuariosService()
        {
            Data = new BaseData();
        }

        public async Task<List<UserModel>> UsuariosProximos()
        {
            return  Data.GetList<UserModel>(true);
        }
    }
}