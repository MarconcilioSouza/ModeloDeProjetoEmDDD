using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceRegion : AppServiceBase<Region>, IAppServiceRegion
    {
        private readonly IServiceRegion _repositorio;
        public AppServiceRegion(IServiceRegion repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}