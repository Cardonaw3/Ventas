using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();


        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Ocotepeque");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");


            var cliente1 = new Cliente(1, "Fernanda Juares", 88243576, "Col Las Americas", ciudad1);
            var cliente2 = new Cliente(2, "Carlos Cardona", 97234576, "colonia Stiven", ciudad1);
            var cliente3 = new Cliente(3, "Cecilia Arebalo", 97459267, "colonia", ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
