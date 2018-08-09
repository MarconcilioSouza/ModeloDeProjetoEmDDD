using Ninject.Modules;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.Services;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Services;
using ProjetoModelo.Infra.Data.EF.Repositorios;

namespace ProjetoModelo.Infra.CrossCutting.IoC.Modulos
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IAppServiceCategories>().To<AppServiceCategories>();
            Bind<IAppServiceCustomerDemographics>().To<AppServiceCustomerDemographics>();
            Bind<IAppServiceCustomers>().To<AppServiceCustomers>();
            Bind<IAppServiceEmployees>().To<AppServiceEmployees>();
            Bind<IAppServiceOrderDetails>().To<AppServiceOrderDetails>();
            Bind<IAppServiceOrders>().To<AppServiceOrders>();
            Bind<IAppServiceProducts>().To<AppServiceProducts>();
            Bind<IAppServiceRegion>().To<AppServiceRegion>();
            Bind<IAppServiceShippers>().To<AppServiceShippers>();
            Bind<IAppServiceSuppliers>().To<AppServiceSuppliers>();
            Bind<IAppServiceTerritories>().To<AppServiceTerritories>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IServiceCategories>().To<ServiceCategories>();
            Bind<IServiceCustomerDemographics>().To<ServiceCustomerDemographics>();
            Bind<IServiceCustomers>().To<ServiceCustomers>();
            Bind<IServiceEmployees>().To<ServiceEmployees>();
            Bind<IServiceOrderDetails>().To<ServiceOrderDetails>();
            Bind<IServiceOrders>().To<ServiceOrders>();
            Bind<IServiceProducts>().To<ServiceProducts>();
            Bind<IServiceRegion>().To<ServiceRegion>();
            Bind<IServiceShippers>().To<ServiceShippers>();
            Bind<IServiceSuppliers>().To<ServiceSuppliers>();
            Bind<IServiceTerritories>().To<ServiceTerritories>();

            Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            Bind<IRepositorioCategories>().To<RepositorioCategories>();
            Bind<IRepositorioCustomerDemographics>().To<RepositorioCustomerDemographics>();
            Bind<IRepositorioCustomers>().To<RepositorioCustomers>();
            Bind<IRepositorioEmployees>().To<RepositorioEmployees>();
            Bind<IRepositorioOrderDetails>().To<RepositorioOrderDetails>();
            Bind<IRepositorioOrders>().To<RepositorioOrders>();
            Bind<IRepositorioProducts>().To<RepositorioProducts>();
            Bind<IRepositorioRegion>().To<RepositorioRegion>();
            Bind<IRepositorioShippers>().To<RepositorioShippers>();
            Bind<IRepositorioSuppliers>().To<RepositorioSuppliers>();
            Bind<IRepositorioTerritories>().To<RepositorioTerritories>();
        }
    }
}
