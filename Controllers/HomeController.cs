using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMVC.Models;

namespace MinhaDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id, string categoria)
        {
            var filme = new Filme
            {
                Titulo = "Piratas do Caribe",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };
            //return RedirectToAction("Privacy", filme);
            return View();
        }

        public IActionResult Privacy(Filme filme)
        {
            if(ModelState.IsValid)
            {

            }

            foreach(var erros in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(erros.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
