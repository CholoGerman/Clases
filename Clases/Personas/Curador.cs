using Clases.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Personas
{
    public class Curador : Persona
    {
        public string Departamento { get; set; }
        public List<Exposicion> ExposicionesCuradas { get; set; } = new();
    }
}
