using Clases.Actividades;
using Clases.Personas;
using Clases.Procedencias;
using Clases.Utilidades;

namespace Clases.Obras
{
    public class Obra
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public IEnumerable<Personas.Donacion> Autores { get; set; } 
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public bool EsCopia { get; set; } 
        public Procedencia Procedencia { get; set; } = new();
        public EpocaArte Epoca { get; set; }



    }
}

