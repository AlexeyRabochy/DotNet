using System.Collections.Generic;
using System.Data.Common;

namespace FilmLibrary.DbWorkers
{
    internal interface IFilmDbWorker
    {
        void SetConnectionString(string connectionString);
        List<DbDataRecord> ExecuteQuery(string query);
    }
}
