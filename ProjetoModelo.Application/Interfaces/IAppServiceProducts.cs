using ProjetoModelo.Domain.Entidades;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IAppServiceProducts : IAppServiceBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
