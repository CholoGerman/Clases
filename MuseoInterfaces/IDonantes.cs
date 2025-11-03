using Clases.Personas;
using Museo.Entities.Filtros;
using Museo.Entities.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Museo.Interfaces
{
    internal interface IDonantes
    {
        void AgergarDonante(Donante donante);
        void ModificarDonante(Donante donante);
        Donacion ElimiarDonante(int idDonante);
        Donacion CargarDonante(int idDonante);
        IEnumerable<Donacion> ListarDonantes();
        IEnumerable<Donacion> BuscarDonantes(FiltroDonante filtro);
    }
}
