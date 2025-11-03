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
        /// <summary>
        ///  El objetivo de este método es dar de alta un dnane en tu sistema.
        /// </summary>
        /// <param name="donante">Instancia de la clase donante que deseo agregar.</param>
        void AgergarDonante(Donante donante);
        void ModificarDonante(Donante donante);
        Donacion ElimiarDonante(int idDonante);
        Donacion CargarDonante(int idDonante);
        IEnumerable<Donacion> ListarDonantes();
        IEnumerable<Donacion> BuscarDonantes(FiltroDonante filtro);
    }
}
