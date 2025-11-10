using Clases.Obras;
using Clases.Procedencias;
using Museo.Entities.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Personas
{
    public class Donacion : Procedencia
    {
        //atributos
        //Donador 
        //  SePuedePrestar
        //  SePuedeExponer 
        //  TiempoExposicion 
        //  CondicionesEspeciales 
        public Donante Donante { get; set; }
        public bool SePuedePrestar { get; set; }
        public bool SePuedeExponer { get; set; }
        public TimeSpan TiempoExposicion { get; set; }
        public string CondicionesEspeciales { get; set; }




    }
}
