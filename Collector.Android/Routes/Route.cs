using System;
using System.IO;
using Collector._Datas;
using Collector.Droid.Routes;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(Route))]
namespace Collector.Droid.Routes
{
    public class Route : ISQLite
    {
        public SQLiteConnection GetConnection(string dbCollector)
        {
            var documents = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, dbCollector);
            return new SQLiteConnection(path);
        }
    }
}
