using AppWorkWithDataAnnotations.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppWorkWithDataAnnotations.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Create"); 
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
