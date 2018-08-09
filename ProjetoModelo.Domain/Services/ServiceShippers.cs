using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceShippers : ServiceBase<Shippers>, IServiceShippers
    {
        private readonly IRepositorioShippers _repositorio;
        public ServiceShippers(IRepositorioShippers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}