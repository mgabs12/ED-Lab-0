using System.Collections.Generic;

namespace Lab0.Models
{
    public class DatosCliente
    {
        public string name;
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
        public static List<DatosCliente> listaClientes = new List<DatosCliente>()
        {
            new DatosCliente("Juan", "Gutierrez", 11111111, "Venta de zapatos"),
            new DatosCliente("Pedro", "Lopez", 55555555, "Pendiente de pago"),
            new DatosCliente("Ana", "Garcia", 22229999, "Delivery de sushi"),
            new DatosCliente("Elisa", "Martinez", 88855555, "Entrega de utiles"),
            new DatosCliente("Santiago", "Chavez", 12345678, "Venta de ropa"),
            new DatosCliente("Flor", "Rojas", 87654321, "Venta de baterias"),
            new DatosCliente("Enrique", "Moreno", 12312312, "Pendiente de pago"),
            new DatosCliente("Abril", "Dominguez", 78978978, "Entrega de pastel"),
            new DatosCliente("Guillermo", "Blanco", 10101010, "Venta de zapatos"),
            new DatosCliente("Michael", "Vargas", 99999999, "Venta de ropa"),
        };

        public static List<DatosCliente> sortByName()
        {
            List<DatosCliente> newList = new List<DatosCliente>();
            for(int i = 0; i < listaClientes.Count(); i++)
            {
                newList.Add(listaClientes[i]);
            }
            //newList.sortClientesN();
            listaClientes.sortClientesN(newList);
            return newList;
        }

        public static List<DatosCliente> sortByLastName()
        {
            List<DatosCliente> newList = new List<DatosCliente>();
            for (int i = 0; i < listaClientes.Count(); i++)
            {
                newList.Add(listaClientes[i]);
            }
            //newList.sortClientesL();
            listaClientes.sortClientesL(newList);
            return newList;            
        }

        public void sortClientesN(bool byName = false, List<DatosCliente> Nuevo)
        {
            int n = Nuevo.Count;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i += 1)
                {
                    string temp = Nuevo[i].name;
                    int j;
                    for (j = i; j >= interval && Nuevo[j - interval].name > temp; j -= interval)
                    {
                        Nuevo[j].name = Nuevo[j - interval].name;
                    }
                    Nuevo[j].name = temp;
                }
            }
        }

        public void sortClientesL(bool byLastName = false, List<DatosCliente> Nuevo) //Shell sort
        {
            int n = Nuevo.Count;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i += 1)
                {
                    string temp = Nuevo[i].lastName;
                    int j;
                    for (j = i; j >= interval && Nuevo[j - interval].lastName > temp; j -= interval)
                    {
                        Nuevo[j].lastName = Nuevo[j - interval].lastName;
                    }
                    Nuevo[j].lastName = temp;
                }
            }
        }
    }
}
