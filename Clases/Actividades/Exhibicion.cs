using Clases.Obras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Actividades
{
    public class Exhibicion : Exposicion
    {
        public int Id { get; set; }
        public Exposicion Exposicion { get; set; }
        public Obra Obra { get; set; }

        // Metadatos de la participación
        public DateTime FechaIngresoExhibicion { get; set; }
        public DateTime FechaSalidaExhibicion { get; set; }
        public string UbicacionEnSala { get; set; } // p.ej. Sala A - Vitrina 2
        public string Notas { get; set; }
    }
}
