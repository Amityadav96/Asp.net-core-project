using Microsoft.AspNetCore.Mvc;
using SimpleProjects.DAL.Infrastructure;
using SimpleProjects.Data;
using SimpleProjects.Models;

namespace SimpleProjects.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitofWork _unit;

        public CategoryController(IUnitofWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _unit.CategoryRepository.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _unit.CategoryRepository.Add(category);
                _unit.Save();
                return RedirectToAction("Index");

            }

            return View(category);
        }
    }
}
