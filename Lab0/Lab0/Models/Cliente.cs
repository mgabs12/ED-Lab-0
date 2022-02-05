using System.Collections.Generic;

namespace Lab0.Models
{
    public class Cliente
    {
        public class DatosCliente
        {
            public string name;
            public string lastName;
            public int phoneNumber;
            public string description;
        }

        List<DatosCliente> listaClientes = new List<DatosCliente>();


        public void addCliente(string _name, string _lastName, int _phoneNumber, string _description)
        {
            DatosCliente newCliente = new DatosCliente();
            newCliente.name = _name;
            newCliente.lastName = _lastName;
            newCliente.phoneNumber = _phoneNumber;
            newCliente.description = _description;

            listaClientes.Add(newCliente);
        }

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
