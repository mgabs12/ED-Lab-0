using Microsoft.AspNetCore.Mvc;
using Lab0.Models;

namespace Lab0.Controllers
{
    public class ClientesController : Controller
    {
        public string DefaultList()
        {
            Cliente scripts = new Cliente();
            string text = "";
            for (int i = 0; i < scripts.Count(); i++)
            {
                text += listaClientes[i].name + ", ";
                text += listaClientes[i].lastName + ", ";
                text += listaClientes[i].phoneNumber.ToString() + ", ";
                text += listaClientes[i].description + "." + "\n";
            }
           
            return text;
        }

        public string SortByName()
        {
            Cliente scripts = new Cliente();
            scripts.sortClientes();
            text += "\n" + "Nombre";
            text += " " + "\n";
            for (int i = 0; i < scripts.Count(); i++)
            {
                text += listaClientes[i].name + ", ";
                text += listaClientes[i].lastName + ", ";
                text += listaClientes[i].phoneNumber.ToString() + ", ";
                text += listaClientes[i].description + "." + "\n";
            }
            return text;
        }

        public string SortByLastName()
        {
            Cliente scripts = new Cliente();
            scripts.sortClientes();
            text += "\n" + "Nombre";
            text += " " + "\n";
            for (int i = 0; i < scripts.Count(); i++)
            {
                text += listaClientes[i].name + ", ";
                text += listaClientes[i].lastName + ", ";
                text += listaClientes[i].phoneNumber.ToString() + ", ";
                text += listaClientes[i].description + "." + "\n";
            }
            return text;
        }
    }
}
