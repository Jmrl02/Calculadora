using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet] 
        public IActionResult index() {
            return View();
        }
        [HttpPost]
        public IActionResult index(string botao, string visor)
        {
            switch (botao)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    if (visor == "0") { visor = botao }
                    else { visor = visor + botao; }
                    break;

                case ",":
                    if (!visor.Contains(",")) visor += botao;
                    break;

                case "+/-":
                    if (visor.StartsWith('-')) visor = visor.Substring(1);
                    else visor = "-" + visor;

                    
                    
                    break;

                case ",":
                case "-":
                case "*":
                case ":":
                    ViewBag.primeiroOperando =(visor == "0");
                    operador = botao 
                    break;


            }

        }
        public IActionResult Index()
        {
            return View();
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