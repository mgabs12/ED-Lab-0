using Microsoft.AspNetCore.Mvc;
using Lab0.Models;

namespace Lab0.Controllers
{
    public class ClientesController : Controller
    {
        Cliente scripts = new Cliente();
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/defaultList")]
        public string showList()
        {
            return "";
        }

        [Route("api/sortedList/name")]
        public string showListSortedByName()
        {
            return "";
        }

        [Route("api/sortedList/lastName")]
        public string showListSortedByLastName()
        {
            return "";
        }
    }
}
