using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio
{
    class Personaje
    {
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
        public int rangoInicial { get; set; }
        public int rangoFinal { get; set; }

        public Personaje()
        {

        }
    }
}
