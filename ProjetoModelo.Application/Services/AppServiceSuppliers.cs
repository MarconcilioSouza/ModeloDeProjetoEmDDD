using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceSuppliers : AppServiceBase<Suppliers>, IAppServiceSuppliers
    {
        private readonly IServiceSuppliers _repositorio;
        public AppServiceSuppliers(IServiceSuppliers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
