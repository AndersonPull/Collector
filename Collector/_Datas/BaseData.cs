using System;
using System.Collections.Generic;
using System.Linq;
using Collector.Models.Home;
using Collector.Models.Usuarios;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace Collector._Datas
{
    public class BaseData : IDisposable
    {
        protected SQLiteConnection _conexao;

        public BaseData()
        {
            var config = DependencyService.Get<ISQLite>();
            this._conexao = new SQLiteConnection(config.Platform,
                System.IO.Path.Combine(config.DirectoryDB, "Collector.db3"));
            this._conexao.CreateTable<UserModel>();
            this._conexao.CreateTable<MateriaisModel>();
        }

        public void Insert<T>(T model)
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

        public T First<T>(bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return _conexao.GetAllWithChildren<T>().FirstOrDefault();
            }
            else
            {
                return _conexao.Table<T>().FirstOrDefault();
            }
        }

        public List<T> GetList<T>(bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return _conexao.GetAllWithChildren<T>().ToList();
            }
            else
            {
                return _conexao.Table<T>().ToList();
            }
        }

        public T Find<T>(int pk, bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return _conexao.GetAllWithChildren<T>()
                                 .FirstOrDefault(m => m.GetHashCode() == pk);
            }
            else
            {
                return _conexao.Table<T>().FirstOrDefault(m => m.GetHashCode() == pk);
            }
        }

        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}
