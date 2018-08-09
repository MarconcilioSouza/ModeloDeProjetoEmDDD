using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceCustomers : AppServiceBase<Customers>, IAppServiceCustomers
    {
        private readonly IServiceCustomers _repositorio;
        public AppServiceCustomers(IServiceCustomers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
