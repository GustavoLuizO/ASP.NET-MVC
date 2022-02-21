using Microsoft.AspNetCore.Mvc;

namespace SegundaAplicacaoMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
