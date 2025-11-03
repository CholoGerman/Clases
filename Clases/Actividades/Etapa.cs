using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Personas;

namespace Clases.Actividades
{
    public class Etapa 
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } // Diagnóstico, Intervención, Acabado...
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public Persona? Responsable { get; set; }
        public string DescripcionTrabajo { get; set; }
    }
}
