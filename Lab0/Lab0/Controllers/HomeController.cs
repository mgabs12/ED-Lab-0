using Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab0.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            Cliente scripts = new Cliente();
            scripts.addCliente("Juan", "Gutierrez", 11111111, "Venta de zapatos");
            scripts.addCliente("Pedro", "Lopez", 55555555, "Pendiente de pago");
            scripts.addCliente("Ana", "Garcia", 22229999, "Delivery de sushi");
            scripts.addCliente("Elisa", "Martinez", 88855555, "Entrega de utiles");
            scripts.addCliente("Santiago", "Chavez", 12345678, "Venta de ropa");
            scripts.addCliente("Flor", "Rojas", 87654321, "Venta de baterias");
            scripts.addCliente("Enrique", "Moreno", 12312312, "Pendiente de pago");
            scripts.addCliente("Abril", "Dominguez", 78978978, "Entrega de pastel");
            scripts.addCliente("Guillermo", "Blanco", 01010101, "Venta de zapatos");
            scripts.addCliente("Michael", "Vargas", 99999999, "Venta de ropa");

            return scripts.showClientes();
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