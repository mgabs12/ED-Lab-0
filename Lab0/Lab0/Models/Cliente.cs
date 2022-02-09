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

        public static List<DatosCliente> showList(bool byName = false)
        {
            List<DatosCliente> newList = new List<DatosCliente>();
            for (int i = 0; i < listaClientes.Count(); i++)
            {
                DatosCliente newObj = listaClientes[i];
                newList.Add(newObj);
            }

            if (byName)
            {
                shellSort(newList, true);
            }
            else
            {
                shellSort(newList);
            }

            return newList;
        }

        public static void shellSort(List<DatosCliente> list, bool byName = false)
        {
            int n = list.Count;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i += 1)
                {
                    DatosCliente temp = list[i];
                    int j;
                    if (byName)
                    {
                        for (j = i; j >= interval && compareStrings(temp.name, list[j - interval].name); j -= interval)
                        {
                            list[j] = list[j - interval];
                        }
                        list[j] = temp;
                    }
                    else
                    {
                        for (j = i; j >= interval && compareStrings(temp.lastName, list[j - interval].lastName); j -= interval)
                        {
                            list[j] = list[j - interval];
                        }
                        list[j] = temp;
                    }
                }
            }
        }

        public static bool compareStrings(string text1, string text2)
        {
            // returns true if text1 goes first than text2
            if (text1 == text2) return false;

            int n = text1.Length;
            if (text2.Length < text1.Length)
            {
                n = text2.Length;
            }

            for (int i = 0; i < n; i++)
            {
                if ((int)text1[i] < (int)text2[i])
                {
                    return true;
                }
                if ((int)text1[i] > (int)text2[i])
                {
                    return false;
                }
            }

            if (text1.Length < text2.Length) return true;
            else return false;
        }
    }
}
