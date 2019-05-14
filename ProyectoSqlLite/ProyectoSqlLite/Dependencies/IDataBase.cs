using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSqlLite.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
