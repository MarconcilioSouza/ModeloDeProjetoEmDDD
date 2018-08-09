using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceShippers : AppServiceBase<Shippers>, IAppServiceShippers
    {
        private readonly IServiceShippers _repositorio;
        public AppServiceShippers(IServiceShippers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}