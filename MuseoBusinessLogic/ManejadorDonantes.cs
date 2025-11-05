using CommonEntities.Interfaces;
using FileAccess;
using Museo.Entities.Filtros;
using Museo.Entities.Personas;
using Museo.Entities.Utilidades;
using System.Configuration;

namespace MuseoBusinessLogic
{
    public class ManejadorDonantes : Donante
    {
        IGenericFileManager<Donante> jsonManager = new GenericJasonManager<Donante>();
        string filename = ConfigurationManager.AppSettings["ArchivoDonantes"];
        public void AgregarDonante(Donante donante)
        {
            var donantes = jsonManager.Leer(filename);
            donantes.Add(donante);
            jsonManager.Guardar(filename, donantes);
           

        }
        public IEnumerable<Donante> BuscarDonantes(FiltroDonante filtro)
        {
            throw new NotImplementedException();
        }

        public Donante CargarDonante(int idDonante)
        {
            throw new NotImplementedException();
        }
        public Donante EliminarDonante(int idDonante)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Donante> ListarDonantes()
        {
            var donantes = jsonManager.Leer(filename);
            return donantes;
        }
        public void ModificarDonante(Donante donante)
        {
            throw new NotImplementedException();
        }


    }
}
