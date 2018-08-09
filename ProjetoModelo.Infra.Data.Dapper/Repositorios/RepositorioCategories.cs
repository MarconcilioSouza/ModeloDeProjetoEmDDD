using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModelo.Domain.Entidades;
using System.Linq.Expressions;
using System.IO;
using Dapper;
using ProjetoModelo.Domain.Interfaces.Repositorios;

namespace ProjetoModelo.Infra.Data.Dapper.Repositorios
{
    public class RepositorioCategories : RepositorioBase, IRepositorioCategories
    {
        public Categories GetById(int CategoryID)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = GetConnection())
            {
                cnn.Open();
                Categories result = cnn.Query<Categories>(
                    @"SELECT CategoryID, CategoryName, Description, Picture
                        FROM Categories
                        WHERE CategoryID = @CategoryID", new { CategoryID }).FirstOrDefault();
                return result;
            }
        }

        public IEnumerable<Categories> Find(Expression<Func<Categories, bool>> predicate)
        {
            if (!File.Exists(DbFile)) return null;

            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<Categories>(@"SELECT * FROM Categories where @predicate", predicate);
            }
        }
        public IEnumerable<Categories> GetPagin(int pagina, int qtd)
        {
            if (!File.Exists(DbFile)) return null;

            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<Categories>(@"SELECT * FROM Categories
                    WHERE CategoryID >= @pagina 
                    ORDER BY CategoryID
                    LIMIT @qtd ", new { pagina, qtd });
            }
        }

        

        public IEnumerable<Categories> GetAll()
        {
            if (!File.Exists(DbFile)) return null;

            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<Categories>(@"SELECT * FROM Categories");
            }
        }
        public void Remove(int categoryID)
        {
            if (!File.Exists(DbFile))
                return;

            using (var conn = GetConnection())
            {
                conn.Open();
                conn.Execute(
                    @" Delete from Categories 
                       where CategoryID = @categoryID", categoryID);
            }
        }

        public void Add(Categories obj)
        {
            if (!File.Exists(DbFile))
                return;

            using (var conn = GetConnection())
            {
                conn.Open();
                obj.CategoryID = conn.Query<int>(
                    @"INSERT INTO Categories ( CategoryName, Description, Picture ) VALUES 
                    ( @CategoryName, @Description, @Picture );
                    select last_insert_rowid()", obj).First();
            }
        }

        public void Update(Categories obj)
        {
            if (!File.Exists(DbFile))
                return;

            using (var cnn = GetConnection())
            {
                cnn.Open();
                cnn.Execute(
                    @" Update Categories 
                       set CategoryName = @CategoryName, 
                           Description = @Description, 
                           Picture = @Picture 
                       where CategoryID = @CategoryID", obj);
            }
        }

        public void Dispose()
        {
            //cnn
        }

        public void Remove(Categories obj)
        {
            throw new NotImplementedException();
        }
    }
}
