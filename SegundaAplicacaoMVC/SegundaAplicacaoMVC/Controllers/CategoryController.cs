using Microsoft.AspNetCore.Mvc;
using SegundaAplicacaoMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SegundaAplicacaoMVC.Controllers
{
    public class CategoryController : Controller
    {
        public static IList<Category> categorylist = new List<Category>()
        {
            new Category()
            {
                CategoryID = 1,
                Name = "Eletrodomésticos"
            },
            new Category()
            {
                CategoryID = 2,
                Name = "Celulares"
            },
            new Category()
            {
                CategoryID = 3,
                Name = "Notebooks"
            },
            new Category()
            {
                CategoryID = 4,
                Name = "Instrumentos musicais"
            },
            new Category()
            {
                CategoryID = 5,
                Name = "Materiais Esportivos"
            }
        };

        public IActionResult Index()
        {
            return View(categorylist);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Category category)
        {
            categorylist.Add(category);
            category.CategoryID = categorylist.Select(m => m.CategoryID).Max() + 1;
            return RedirectToAction("Index");
        }

        public IActionResult Edit(long id)
        {
            return View(categorylist.Where(m => m.CategoryID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Category category)
        {
            categorylist.Remove(categorylist.Where(c => c.CategoryID == category.CategoryID).First());
            categorylist.Add(category);
            return RedirectToAction("Index");
        }

        public IActionResult Details (long id)
        {
            return View(categorylist.Where(m=>m.CategoryID ==id).First());
        }


    }
}
