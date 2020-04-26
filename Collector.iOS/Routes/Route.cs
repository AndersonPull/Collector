using System;
using System.IO;
using Collector._Datas;
using Collector.iOS.Routes;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(Route))]
namespace Collector.iOS.Routes
{
    public class Route : ISQLite
    {
        public SQLiteConnection GetConnection(string dbCollector)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, "..", "Library", dbCollector);
            return new SQLiteConnection(path);
        }
    }
}
