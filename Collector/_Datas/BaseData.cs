using System;
using System.Collections.Generic;
using Collector.Models.Usuarios;
using SQLite;
using Xamarin.Forms;

namespace Collector._Datas
{
    public class BaseData
    {
        protected SQLiteConnection _conexao;
        private string dbCollector = "Collector.db3";

        public BaseData()
        {
            this._conexao = DependencyService.Get<ISQLite>().GetConnection(this.dbCollector);
            this._conexao.CreateTable<UserModel>();
        }

        public void Save(UserModel user)
        {
            _conexao.Insert(user);
        }

        public UserModel GetById(int id)
        {
            return _conexao.Table<UserModel>().Where(a => a.Id == id).FirstOrDefault();
        }

        public UserModel GetUser(string nickName, string password)
        {
            return _conexao.Table<UserModel>().Where(a => a.NickName == nickName && a.Password == password).FirstOrDefault();
        }

        public List<UserModel> GetCollectors()
        {
            return _conexao.Table<UserModel>().Where(a => a.IsCollector).ToList();
        }

        public List<UserModel> GetAll()
        {
            return _conexao.Table<UserModel>().ToList();
        }

        public void Update(UserModel user)
        {
            _conexao.Update(user);
        }

        public void Delete(UserModel user)
        {
            _conexao.Delete(user);
        }
    }
}
