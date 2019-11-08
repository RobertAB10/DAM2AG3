using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio
{
    class Pregunta
    {
        public string pregunta { get; set; }
        public string imagen { get; set; }
        public string nivell { get; set; }
        //public string idioma { get; set; }
        public List<Respuesta> respuestas { get; set; }

        public Pregunta()
        {

        }

    }
}
