using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceOrderDetails : AppServiceBase<OrderDetails>, IAppServiceOrderDetails
    {
        private readonly IServiceOrderDetails _repositorio;
        public AppServiceOrderDetails(IServiceOrderDetails repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}