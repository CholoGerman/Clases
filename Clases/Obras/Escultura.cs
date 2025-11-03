using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Obras
{
    public class Escultura : Obra
    {
        public TecnicaEscultura TecnicaEscultura { get; set; }
        public MaterialEscultura MaterialEscultura { get; set; }
        public decimal Peso { get; set; }
        public float Altura { get; set; }
    }
}
