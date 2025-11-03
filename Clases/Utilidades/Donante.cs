using Clases.Personas;
using Clases.Procedencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo.Entities.Utilidades
{
    public class Donante : Persona
    {
        public string Domicilio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NumeroDocumento { get; set; }
        public IEnumerable<Donacion> Donaciones { get; set; }
    }
}
