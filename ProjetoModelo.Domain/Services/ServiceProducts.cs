using System.Collections.Generic;
using ProjetoModelo.Domain.Entidades;
using ProjetoModelo.Domain.Interfaces.Repositorios;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ServiceProducts : ServiceBase<Products>, IServiceProducts
    {
        private readonly IRepositorioProducts _repositorio;
        public ServiceProducts(IRepositorioProducts repositorio)
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