using SQLite.Net.Interop;

namespace Collector._Datas
{
    public interface ISQLite
    {
        string DirectoryDB { get; }

        ISQLitePlatform Platform { get; }
    }
}
