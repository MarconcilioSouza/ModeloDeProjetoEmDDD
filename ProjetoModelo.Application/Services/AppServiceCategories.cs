using System;
using System.Collections.Generic;
using AutoMapper;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Application.AutoMapper;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceCategories : IAppServiceCategories
    {
        private readonly IServiceCategories _repositorio;
        private readonly IMapper _mapper;

        public AppServiceCategories(IServiceCategories repositorio)
        {
            _repositorio = repositorio;
            _mapper = AutoMapperConfig.Mapper;
        }
        
        public IEnumerable<CategoriesViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoriesViewModel>>(_repositorio.GetAll());
        }

        public CategoriesViewModel GetById(int id)
        {
            return _mapper.Map<CategoriesViewModel>(_repositorio.GetById(id));
        }

        public void Register(CategoriesViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categories>(customerViewModel);
            _repositorio.Add(categoria);
        }

        public void Update(CategoriesViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categories>(customerViewModel);
            _repositorio.Update(categoria);
        }

        public void Remove(CategoriesViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categories>(customerViewModel);
            _repositorio.Remove(categoria);
        }

        public void Remove(int id)
        {
            _repositorio.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }        
    }
}
