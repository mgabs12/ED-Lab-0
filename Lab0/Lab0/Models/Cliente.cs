using System.Collections.Generic;

namespace Lab0.Models
{
    public class DatosCliente
    {
        public string name = "Mario";
        public string lastName;
        public int phoneNumber;
        public string description;

        public DatosCliente(string _name, string _lastName, int _phoneNumber, string _description)
        {
            name = _name;
            lastName = _lastName;
            phoneNumber = _phoneNumber;
            description = _description;
        }
    }

    public class Cliente
    {
        public List<DatosCliente> listaClientes = new List<DatosCliente>()
        {
            new DatosCliente("Juan", "Gutierrez", 11111111, "Venta de zapatos"),
            new DatosCliente("Pedro", "Lopez", 55555555, "Pendiente de pago"),
            new DatosCliente("Ana", "Garcia", 22229999, "Delivery de sushi"),
            new DatosCliente("Elisa", "Martinez", 88855555, "Entrega de utiles"),
            new DatosCliente("Santiago", "Chavez", 12345678, "Venta de ropa"),
            new DatosCliente("Flor", "Rojas", 87654321, "Venta de baterias"),
            new DatosCliente("Enrique", "Moreno", 12312312, "Pendiente de pago"),
            new DatosCliente("Abril", "Dominguez", 78978978, "Entrega de pastel"),
            new DatosCliente("Guillermo", "Blanco", 01010101, "Venta de zapatos"),
            new DatosCliente("Michael", "Vargas", 99999999, "Venta de ropa"),
        };

        public string showClientes()
        {
            string text = "";
            // 1. add all the data from the list to the string
            // 2. use sort function by name (just call the function)
            // 3. add all the data from the list to the string
            // 4. use sort function by last name (just call the function)
            // 5. add all the data from the list to the string
            // *** format the text as you want but make sure that is readeble, each sort separated and with a "title" that indicates wich sort it is

            return text;
        }

        public void sortClientes(bool byName = false)
        {
            int n = listaClientes.Count;
            for (int interval = n/2; interval > 0; interval /= 2)
            {
                for(int i = interval; i < n; i += 1)
                {
                    string temp = listaClientes[i].name;
                    int j;
                    for(j = i; j>= interval && listaClientes[j-interval].name> temp; j -= interval)
                    {
                        listaClientes[j].name = listaClientes[j - interval].name;
                    }
                    listaClientes[j].name = temp;
                }
            }
        }

        public void sortClientes(bool byLastName = false) //Shell sort
        {
            int n = listaClientes.Count;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i += 1)
                {
                    string temp = listaClientes[i].lastName;
                    int j;
                    for (j = i; j >= interval && listaClientes[j - interval].lastName > temp; j -= interval)
                    {
                        listaClientes[j].lastName = listaClientes[j - interval].lastName;
                    }
                    listaClientes[j].lastName = temp;
                }
            }
        }
    }
}
