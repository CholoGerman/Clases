using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Utilidades
{
    public class Material
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; } // "Barniz de Conservación", "Pegamento X"
        public string Composicion { get; set; }
        public string Uso { get; set; } // en qué trabajos se emplea
    }
}
