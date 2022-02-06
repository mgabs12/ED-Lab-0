using Microsoft.AspNetCore.Mvc;
using Lab0.Models;

namespace Lab0.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult DefaultList()
        {
            return View();
        }

        public IActionResult SortByName()
        {
            return View();
        }

        public IActionResult SortByLastName()
        {
            return View();
        }
    }
}
