using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceSuppliers : ServiceBase<Suppliers>, IServiceSuppliers
    {
        private readonly IRepositorioSuppliers _repositorio;
        public ServiceSuppliers(IRepositorioSuppliers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
