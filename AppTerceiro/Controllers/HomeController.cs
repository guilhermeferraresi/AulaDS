using AppTerceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppTerceiro.Controllers
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
            Fisica fisica = new Fisica
            {
                Id=12,
                Nome = "Martin Luther King Jr",
                Sexo = 'F',
                CPF = 1945,
                RG = 69696969,
                Dig_RG = '9'    
            };
            ViewData["id"] = fisica.Id;
            ViewData["Nome"] = fisica.Nome;
            ViewData["Sexo"] = fisica.Sexo;
            ViewData["CPF"] = fisica.CPF;
            ViewData["RG"] = fisica.RG;
            ViewData["NoDig_RG"] = fisica.Dig_RG;
            return View(fisica); ;
        }

        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12; 
            pessoa.Nome = "Martin";
            pessoa.Sexo = 'M';

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;

            return View(pessoa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Juridica()
       
        { 
            Juridica juridica = new Juridica();
            juridica.Id = 69696969;
            juridica.Nome = "Infinity System";
            juridica.CNPJ = 23333666668888888;
            juridica.IE = 0987654321;
            return View(juridica);
        }


    }
}
