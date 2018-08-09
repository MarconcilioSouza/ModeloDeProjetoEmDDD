using ProjetoModelo.Domain.Entidades;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Repositorios
{
    public interface IRepositorioProducts : IRepositorioBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
