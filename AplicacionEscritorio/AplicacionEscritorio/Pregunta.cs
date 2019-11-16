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
        public string nivel { get; set; }
        public string tema { get; set; }
        public List<Respuesta> respuestas { get; set; }

        public Pregunta()
        {

        }

    }
}
