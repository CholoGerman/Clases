using Clases.Personas;
using Clases.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Procedencias
{
    public class Procedencia
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public string OtrosDatos { get; set; }
        
    }
}
