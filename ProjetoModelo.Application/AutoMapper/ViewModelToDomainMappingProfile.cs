using AutoMapper;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entidades;

namespace ProjetoModelo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriesViewModel, Categories>();
        }
    }
}
