using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjetoModelo.API.Controllers
{
    public class CategoriasController : ApiController
    {
        private readonly IAppServiceCategories _AppServiceCategories;

        public CategoriasController(IAppServiceCategories appService)
        {
            _AppServiceCategories = appService;
        }

        // GET: api/Categorias
        public IEnumerable<CategoriesViewModel> Get()
        {
            return  _AppServiceCategories.GetAll();
        }

        // GET: api/Categorias/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categorias
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categorias/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categorias/5
        public void Delete(int id)
        {
        }
    }
}
