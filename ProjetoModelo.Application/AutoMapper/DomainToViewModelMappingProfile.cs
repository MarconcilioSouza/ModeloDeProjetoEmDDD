using AutoMapper;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entidades;

namespace ProjetoModelo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           CreateMap<Categories, CategoriesViewModel>();
        }
    }
}
