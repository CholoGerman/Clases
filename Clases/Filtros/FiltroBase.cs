using System;
using System.Collections.Generic;
using System.Text;

namespace Museo.Entities.Filtros
{
    public class FiltroBase
    {
        public bool Paginar { get; set; }
        public int CantidadRegistros { get; set; }
        public int NumeroPagina { get; set; }
    }
}
