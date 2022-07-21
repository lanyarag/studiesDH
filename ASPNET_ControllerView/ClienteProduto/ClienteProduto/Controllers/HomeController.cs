using System.Diagnostics;
using ClienteProduto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClienteProduto.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            List<String> nomes = new List<String>();
            nomes.Add("Microsoft");
            nomes.Add("Adobe");
            nomes.Add("Apple");
            ViewBag.Nome = nomes[1];
            ViewBag.Cliente = nomes[2];
            ViewBag.TodosClientes = nomes;
            return View();
        }

        public IActionResult Produto()
        {
            List<string> Produtos = new List<string>();
            Produtos.Add("Computador");
            Produtos.Add("Mouse");
            Produtos.Add("Teclado");
            ViewBag.TodosProdutos = Produtos;
            ViewBag.BestSeller = Produtos[1];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}