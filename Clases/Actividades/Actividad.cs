using Clases.Personas;
using Clases.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Actividades
{
    public class Actividad
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Persona? Responsable { get; set; }     // persona a cargo
        public Institucion? Lugar { get; set; }       // ubicación o sala
        public List<string> Notas { get; set; } = new();




    }
}
