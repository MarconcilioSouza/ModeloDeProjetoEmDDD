using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceTerritories : AppServiceBase<Territories>, IAppServiceTerritories
    {
        private readonly IServiceTerritories _repositorio;
        public AppServiceTerritories(IServiceTerritories repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
