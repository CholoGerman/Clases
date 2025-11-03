using Clases.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Personas
{
    public class Tecnico : Persona
    {
        public string Especialidad { get; set; } // conservación pintura, etc.
        public List<Restauracion> Restauraciones { get; set; } = new();
    }
}
