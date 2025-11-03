using Clases.Personas;
using Clases.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Procedencias
{
    public class Prestamo : Procedencia
    {
        public Institucion Operador { get; set; } // institución que recibe la obra
        public Persona PersonaReceptora { get; set; } // alternativa
        public DateTime FechaFinalizacion { get; set; }
        public string CondicionesTransporte { get; set; } 
        public bool TieneSeguro { get; set; }
        public string DetallesSeguro { get; set; } 
       
    }
}
