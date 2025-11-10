using Clases.Obras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Actividades
{
    public class Movimiento
    {
        public int Id { get; set; }
        public Obra Obra { get; set; }
        public string Desde { get; set; }   // p.ej. Sala 1
        public string Hasta { get; set; }   // p.ej. Sala 2
        public DateTime FechaMovimiento { get; set; }
        public string Motivo { get; set; }  // traslado para exposición, inventario...
        public string MedioTransporte { get; set; }
    }
}
