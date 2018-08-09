using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceRegion : ServiceBase<Region>, IServiceRegion
    {
        private readonly IRepositorioRegion _repositorio;
        public ServiceRegion(IRepositorioRegion repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}