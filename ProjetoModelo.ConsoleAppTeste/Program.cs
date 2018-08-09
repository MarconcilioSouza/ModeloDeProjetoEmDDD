using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Infra.Data.Dapper.Contexto;
using ProjetoModelo.Infra.Data.Dapper.Repositorios;
using ProjetoModelo.Infra.Data.EF.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.ConsoleAppTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CreateDatabase();
            db.CreateDatabaseSqlite();

            var rep = new RepositorioCategories();
            //var cat = new Categories()
            //{
            //    CategoryName = "teste",
            //    Description = "teste",
            //};

            //for (int i = 0; i < 50; i++)
            //{
            //    cat.CategoryID = i;
            //    rep.Add(cat);
            //}

            for (int i = 1; i < 20; i = i + 5)
            {
                var result = rep.GetPagin(i, 5);

                foreach (var item in result)
                {
                    Console.WriteLine(item.CategoryID + " ... "+ item.CategoryName);
                }
            }

            //var db = new ProjetoModeloContext();

            //var cat = db.Categories.ToList();
        }
    }
}
