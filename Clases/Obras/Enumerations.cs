using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Obras
{
    public enum EnumTecnicaPintura
    {
        Oleo,
        Acuarela,
        Temple,
        Fresco,
        Pastel,
        Acrilico,
        Tinta,
        Gouache
       


    }
    public enum EpocaArte
    {
        Desconocido,
        Prehistorico,
        Antiguo,
        Medieval,
        Renacimiento,
        Barroco,
        Neoclasico,
        Romanticismo,
        Moderno,
        Contemporaneo
    }
    public enum TecnicaEscultura
    {
        Tallado,
        Modelado,
        Fundicion,
        Ensamblaje,
        Cincelado
    }

    public enum MaterialEscultura
    {
        Piedra,
        Madera,
        Metal,
        Yeso,
        Ceramica,
        Hueso,
        Marfil
    }
    public enum ProcedenciaObra
    {
        Desconocida,
        Compra,
        Donacion,
        Prestamo
    }

    public enum TipoAuditoria
    {
        Movimiento,
        Prestamo,
        Restauracion,
        Otro
    }
}
