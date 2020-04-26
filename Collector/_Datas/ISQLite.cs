using SQLite;

namespace Collector._Datas
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(string dbCollector);
    }
}
