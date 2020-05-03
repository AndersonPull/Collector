using System;
using System.IO;
using Collector._Datas;
using Collector.iOS.Routes;
using SQLite;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(Route))]
namespace Collector.iOS.Routes
{
    public class Route : ISQLite
    {
        string directoryDB;
        ISQLitePlatform platform;

        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    var directory = System.Environment.GetFolderPath(
                        Environment.SpecialFolder.Personal);
                    directoryDB = System.IO.Path.Combine(
                        directory,
                        "..",
                        "Library");
                }

                return directoryDB;
            }
        }

        public ISQLitePlatform Platform
        {
            get
            {
                if (platform == null)
                {
                    platform =
                        new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }

                return platform;
            }
        }
    }
}
