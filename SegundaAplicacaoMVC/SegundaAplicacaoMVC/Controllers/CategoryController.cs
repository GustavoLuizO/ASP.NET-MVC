using Microsoft.AspNetCore.Mvc;
using SegundaAplicacaoMVC.Models;

namespace SegundaAplicacaoMVC.Controllers
{
    public class CategoryController : Controller
    {
        public static IList<Category> listCategory = new List<Category>()
        {
            new Category
            {
                idCategory = 1,
                name = "Eletronics"
            },
            new Category
            {
                idCategory = 2,
                name = "Sports Materials"
            },
            new Category
            {
                idCategory = 3,
                name = "Only Family"
            },
        };
        public IActionResult Index()
        {
            return View(listCategory);
        }
    }
}
