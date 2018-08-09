using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceCustomerDemographics : ServiceBase<CustomerDemographics>, IServiceCustomerDemographics
    {
        private readonly IRepositorioCustomerDemographics _repositorio;
        public ServiceCustomerDemographics(IRepositorioCustomerDemographics repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
