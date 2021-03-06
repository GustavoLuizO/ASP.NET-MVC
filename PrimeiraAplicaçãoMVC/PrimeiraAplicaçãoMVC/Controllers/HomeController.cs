using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicaçãoMVC.Models;
using System.Diagnostics;

namespace PrimeiraAplicaçãoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public string BoasVindas(string nome, int cont)
        {
            return "Olá " + nome + ", contador está valenda " + cont;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}