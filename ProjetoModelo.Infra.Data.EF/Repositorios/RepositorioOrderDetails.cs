using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;

namespace ProjetoModelo.Infra.Data.EF.Repositorios
{
    public class RepositorioOrderDetails : RepositorioBase<OrderDetails>, IRepositorioOrderDetails
    {
    }
}
