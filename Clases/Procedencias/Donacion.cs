using Clases.Obras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Personas
{
    public class Donacion : Persona
    {
        public string Biografia { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
