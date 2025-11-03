using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Actividades;
using Clases.Obras;

namespace Clases.Utilidades
{
    public class Coleccion
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<Obra> Obras { get; set; } = new();

    }
}
