using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceCustomerDemographics : AppServiceBase<CustomerDemographics>, IAppServiceCustomerDemographics
    {
        private readonly IServiceCustomerDemographics _repositorio;
        public AppServiceCustomerDemographics(IServiceCustomerDemographics repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
