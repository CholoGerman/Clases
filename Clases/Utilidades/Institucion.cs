using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Utilidades
{
    public class Institucion
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string Tipo { get; set; } // Museo, Galería, Colección Privada...
        public string? Contacto { get; set; }
        public string Direccion { get; set; }
    }
}
