using Microsoft.AspNetCore.Mvc;
using PruebaAjax1.Models;
using System.Diagnostics;

namespace PruebaAjax1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public  PartialViewResult MuestraTexto()
        {
            string comentario = "Empleando Ajax, JQuery y JS";

            return PartialView("_partial", comentario);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}