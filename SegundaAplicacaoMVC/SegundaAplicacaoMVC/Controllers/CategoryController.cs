using Microsoft.AspNetCore.Mvc;
using SegundaAplicacaoMVC.Models;
using System.Collections.Generic;

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
            return RedirectToAction("Index");
        }
    }
}
