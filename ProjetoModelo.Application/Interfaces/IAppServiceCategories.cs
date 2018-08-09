using ProjetoModelo.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IAppServiceCategories : IDisposable
    {
        void Register(CategoriesViewModel customerViewModel);
        IEnumerable<CategoriesViewModel> GetAll();
        CategoriesViewModel GetById(int id);
        void Update(CategoriesViewModel customerViewModel);
        void Remove(int id);
        void Remove(CategoriesViewModel id);
    }
}
