﻿using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceCategories : ServiceBase<Categories>, IServiceCategories
    {
        private readonly IRepositorioCategories _repositorio;
        public ServiceCategories(IRepositorioCategories repositorio) 
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}