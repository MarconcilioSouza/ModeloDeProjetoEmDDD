using ProjetoModelo.Domain.Entidades;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IServiceProducts : IServiceBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
