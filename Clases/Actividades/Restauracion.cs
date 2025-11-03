using Clases.Obras;
using Clases.Personas;
using Clases.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Actividades
{
    public class Restauracion : Actividad
    {
        public Guid Id { get; set; }
        public Obra Obra { get; set; }
        public Institucion EmpresaExterna { get; set; } // si TipoProveedor == Externo
        public Tecnico TecnicoResponsable { get; set; } // responsable principal (interno o externo)
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Material> MaterialesUtilizados { get; set; } = new();
        public decimal? CostoTotal { get; set; }
        public string InformeFinal { get; set; } // ruta o texto breve

        // Etapas con distintos responsables
        public List<Etapa> Etapas { get; set; } = new();
    }
}
