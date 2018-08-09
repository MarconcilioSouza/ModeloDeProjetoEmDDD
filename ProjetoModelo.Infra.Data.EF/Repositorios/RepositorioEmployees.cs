using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces;
using ProjetoModelo.Domain.Interfaces.Repositorios;

namespace ProjetoModelo.Infra.Data.EF.Repositorios
{
    public class RepositorioEmployees : RepositorioBase<Employees>, IRepositorioEmployees
    {
    }
}
