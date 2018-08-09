using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceOrderDetails : ServiceBase<OrderDetails>, IServiceOrderDetails
    {
        private readonly IRepositorioOrderDetails _repositorio;
        public ServiceOrderDetails(IRepositorioOrderDetails repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}