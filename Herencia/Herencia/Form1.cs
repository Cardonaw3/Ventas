using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Nombre  = "Medusalith Amaquelin-Boltagon";
            heroe1.NombreH = "Medusa";
            heroe1.Raza    = "inhumanos";
            heroe1.poderes = "control psicocinético sobre su cabello";

            var heroe2 = new Heroe();
            heroe2.Nombre  = "Blackagar Boltagon";
            heroe2.NombreH = "Rayo Negro";
            heroe2.Raza    = "inhumanos";
            heroe2.poderes = "Voz hipersónica destructiva ";

            var heroe3 = new Heroe();
            heroe3.Nombre  = "James Logan";
            heroe3.NombreH = "Wolverine";
            heroe3.Raza    = "Mutante ";
            heroe3.poderes = "Su cuerpo es capaz de recuperarse de cualquier daño físico, Garras de adamantiun";


            var villano1 = new Villano();
            villano1.Nombre  = "Erik Lehnsherr";
            villano1.NombreV = "Magneto ";
            villano1.Raza    = "Mutante ";
            villano1.poderes = "Control del magnetismo ";

            var villano2 = new Villano();
            villano2.Nombre  = "Thanos The Titan, Dione";
            villano2.NombreV = "Thanos ";
            villano2.Raza    = "Eternos ";
            villano2.poderes = "Fuerza, velocidad, agilidad, durabilidad sobrehumana, Inmortalidad";


            var villano3 = new Villano();
            villano3.Nombre  = "Víctor Creed ";
            villano3.NombreV = "Dientes de Sable  ";
            villano3.Raza    = "Mutante ";
            villano3.poderes = "Sentidos con agudeza superhumana, Garras retráctiles ";

        }
    }
}
