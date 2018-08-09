using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceOrders : ServiceBase<Orders>, IServiceOrders
    {
        private readonly IRepositorioOrders _repositorio;
        public ServiceOrders(IRepositorioOrders repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}