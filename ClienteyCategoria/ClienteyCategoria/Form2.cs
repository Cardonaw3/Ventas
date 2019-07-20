using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteyCategoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "Ocotepeque";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "San Pedro Sula";

            var ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Tegucigalpa";


            Cliente cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Carlos";
            cliente1.Telefono = "34668889";
            cliente1.Direccion = "Colonia";
            cliente1.Ciudad = ciudad1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Maria";
            cliente2.Telefono = "99883488";
            cliente2.Direccion = "AVENIDA";
            cliente2.Ciudad = ciudad2;

            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Juna";
            cliente3.Telefono = "98325689";
            cliente3.Direccion = "Avenida";
            cliente3.Ciudad = ciudad3;

            var ListaCliente = new List<Cliente>();
            ListaCliente.Add(cliente1);
            ListaCliente.Add(cliente2);
            ListaCliente.Add(cliente3);

            foreach (var Cliente in ListaCliente)
            {
                MessageBox.Show(Cliente.Nombre + " " + Cliente.Ciudad.Descripcion);


            }
        }
    }
}
