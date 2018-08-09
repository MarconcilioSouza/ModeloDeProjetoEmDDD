using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceEmployees : AppServiceBase<Employees>, IAppServiceEmployees
    {
        private readonly IServiceEmployees _repositorio;
        public AppServiceEmployees(IServiceEmployees repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
