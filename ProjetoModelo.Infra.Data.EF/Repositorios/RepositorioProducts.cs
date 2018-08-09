using System.Collections.Generic;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces;
using System.Linq;
using ProjetoModelo.Domain.Interfaces.Repositorios;

namespace ProjetoModelo.Infra.Data.EF.Repositorios
{
    public class RepositorioProducts : RepositorioBase<Products>, IRepositorioProducts
    {
        public IEnumerable<Products> BuscarPorNome(string nome)
        {
            return db.Products.Where(p => p.ProductName == nome);
        }
    }
}
