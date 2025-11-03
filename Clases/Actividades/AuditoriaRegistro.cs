using Clases.Personas;
using Clases.Procedencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clases.Obras.Obra;

namespace Clases.Actividades
{
    public class AuditoriaRegistro
    {
        public Guid Id { get; set; }
        public TipoAuditoria Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public Persona QuienAutorizo { get; set; } // quién autorizó la acción
        public string Descripcion { get; set; }    // texto libre
        public Movimiento MovimientoDetalles { get; set; } // opcional
        public Prestamo PrestamoDetalles { get; set; } // opcional (si se audita un préstamo)
        public Restauracion RestauracionDetalles { get; set; } // opcional

        public enum TipoAuditoria
        {
            Movimiento,
            Prestamo,
            Restauracion,
            Otro
        }

    }
}
