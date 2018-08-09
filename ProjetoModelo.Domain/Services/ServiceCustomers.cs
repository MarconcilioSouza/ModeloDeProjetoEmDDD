using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceCustomers : ServiceBase<Customers>, IServiceCustomers
    {
        private readonly IRepositorioCustomers _repositorio;
        public ServiceCustomers(IRepositorioCustomers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
