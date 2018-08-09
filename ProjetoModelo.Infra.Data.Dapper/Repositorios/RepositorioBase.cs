using System;
using System.Data.SQLite;

namespace ProjetoModelo.Infra.Data.Dapper.Repositorios
{
    public class RepositorioBase
    {
        public static string DbFile = Environment.CurrentDirectory + @"\\ProjetoModelo.sqlite";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
