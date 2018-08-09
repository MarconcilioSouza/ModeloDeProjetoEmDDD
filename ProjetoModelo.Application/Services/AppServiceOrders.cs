using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceOrders : AppServiceBase<Orders>, IAppServiceOrders
    {
        private readonly IServiceOrders _repositorio;
        public AppServiceOrders(IServiceOrders repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}