using Collector._Datas;
using Collector.Droid.Routes;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(Route))]
namespace Collector.Droid.Routes
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
                    directoryDB = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
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
                        new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return platform;
            }
        }
    }
}
