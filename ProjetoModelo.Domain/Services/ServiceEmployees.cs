using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceEmployees : ServiceBase<Employees>, IServiceEmployees
    {
        private readonly IRepositorioEmployees _repositorio;
        public ServiceEmployees(IRepositorioEmployees repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
