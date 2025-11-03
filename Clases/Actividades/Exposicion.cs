using Clases.Obras;
using Clases.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Actividades
{
    public class Exposicion : Actividad
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public List<Curador> CuradoresResponsables { get; set; } = new();
        public decimal Presupuesto { get; set; }

        // Relación N:N con Obra mediante entidad puente para poder añadir metadatos por participación
        public List<Exhibicion> Obras { get; set; } = new();
    }
}
