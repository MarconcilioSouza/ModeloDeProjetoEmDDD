using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _repositorio;

        public AppServiceBase(IServiceBase<TEntity> repositorio)
        {
            this._repositorio = repositorio;
        }

        public void Add(TEntity obj)
        {
            _repositorio.Add(obj);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorio.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Remove(int id)
        {
            _repositorio.Remove(id);
        }

        public void Remove(TEntity obj)
        {
            _repositorio.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositorio.Update(obj);
        }
    }
}
