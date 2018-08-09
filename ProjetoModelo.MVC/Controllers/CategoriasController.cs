using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;
using System.Web.Mvc;

namespace ProjetoModelo.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly IAppServiceCategories _AppServiceCategories;

        public CategoriasController(IAppServiceCategories appService)
        {
            _AppServiceCategories = appService;
        }
        // GET: Categoria
        public ActionResult Index()
        {
            var categoriesViewModel = _AppServiceCategories.GetAll();
            return View(categoriesViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
            return View(categoriesViewModel);
        }

        // GET: Categoria/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                _AppServiceCategories.Register(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
            return View(categoriesViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                _AppServiceCategories.Update(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
            if (categoriesViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoriesViewModel);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _AppServiceCategories.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
