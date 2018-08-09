using System;
using System.Data.SQLite;

namespace ProjetoModelo.Infra.Data.Dapper.Contexto
{
    public class SqliteContext
    {
        public static string DbFile = Environment.CurrentDirectory + @"\\ProjetoModelo.sqlite";
        
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
