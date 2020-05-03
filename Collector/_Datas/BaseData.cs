using System;
using System.Collections.Generic;
using Collector.Models.Home;
using Collector.Models.Usuarios;
using SQLite;
using SQLiteNetExtensions.Extensions;
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
            this._conexao.CreateTable<MateriaisModel>();
        }

        public void Save<T>(T model)
        {
            _conexao.Insert(model);;
        }

        public void Update<T>(T model)
        {
            _conexao.Update(model);
        }

        public void Delete<T>(T model)
        {
            _conexao.Delete(model);
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
    }
}
