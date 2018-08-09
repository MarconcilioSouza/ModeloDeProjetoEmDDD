using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceTerritories : ServiceBase<Territories>, IServiceTerritories
    {
        private readonly IRepositorioTerritories _repositorio;
        public ServiceTerritories(IRepositorioTerritories repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
