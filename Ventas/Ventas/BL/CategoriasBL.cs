using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CategoriasBL
    {
        public List<Categoria> listadeCategoria { get; set; }

        public CategoriasBL()
        {
            listadeCategoria = new List<Categoria>();
            CrearDatosdePrueba();

        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accsesorios");

            listadeCategoria.Add(categoria1);
            listadeCategoria.Add(categoria2);
        }
    }
}
