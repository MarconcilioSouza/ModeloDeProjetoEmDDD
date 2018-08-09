using System.Collections.Generic;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Application.Interfaces;

namespace ProjetoModelo.Application.Services
{
    public class AppServiceProducts : AppServiceBase<Products>, IAppServiceProducts
    {
        private readonly IServiceProducts _repositorio;
        public AppServiceProducts(IServiceProducts repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Products> BuscarPorNome(string nome)
        {
            return _repositorio.BuscarPorNome(nome);
        }
    }
}