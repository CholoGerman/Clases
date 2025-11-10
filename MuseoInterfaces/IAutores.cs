
using Clases.Personas;
using Museo.Entities.Filtros;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Museo.Interfaces
{
    public interface IAutores
    {

         void AgergarAutor(Donacion autor);
        void ModificarAutor(Donacion autor);
        Donacion ElimiarAutor(int idAutor);
        Donacion CargarAutor(int idAutor);
        IEnumerable<Donacion> ListarAutores();
        IEnumerable<Donacion> BuscarAutores(FiltroAutor filtro);



    }
}
