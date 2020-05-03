using System;
using System.Linq;
using System.Threading.Tasks;
using Collector._Datas;
using Collector.Models.Usuarios;
using Collector.Views.PopUpsAlerts;
using Rg.Plugins.Popup.Services;

namespace Collector.Services.Login
{
    public class AccessService
    {
        BaseData Data;
        public AccessService()
        {
            Data = new BaseData();
        }

        public async Task<UserModel> GetUser(string nickName, string password)
        {
            try
            {
                var users = Data.GetList<UserModel>(true);

                return users.Where(a => a.NickName == nickName && a.Password == password).FirstOrDefault();
            }
            catch(Exception e)
            {
                await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Algo de errado com a internet!",e.ToString()), true);
            }

            return null;
        }
    }
}
