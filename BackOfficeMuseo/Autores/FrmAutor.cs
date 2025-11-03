#region MyRegion
using Clases.Personas;
using CommonEntities.Interfaces;
using FileAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms; 
#endregion


namespace BackOfficeMuseo.Autores
{
    public partial class FrmAutor : Form
    {
        public IEnumerable<Autor> AutoresSeleccionados { get; private set; }
        private IEnumerable<Autor> _autores;
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AutoresSeleccionados = dgvAutores.SelectedRows
            .Cast<DataGridViewRow>()
            .Select(row => row.DataBoundItem as Autor);

            _autores = dgvAutores.DataSource as IEnumerable<Autor>;
            IGenericFileManager<Autor> jsonManager = new GenericJasonManager<Autor>();
            var fileName = ConfigurationManager.AppSettings["ArchivosAutores"];


            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void FrmAutor_Load(object sender, EventArgs e)
        {
            IGenericFileManager<Autor> jsonManager = new GenericJasonManager<Autor>();

            var fileName = ConfigurationManager.AppSettings["ArchivosAutores"];


            List<Autor> autores = new List<Autor>();
            {
                new Autor { Id = 1, Nombre = "Pablo", Apellido = "Picasso", Biografia = "Pintor y escultor español" };
             };

            jsonManager.Guardar(fileName, autores);
            _autores = jsonManager.Leer(fileName);
            BindingList<Autor> listaAutores = new BindingList<Autor>(_autores.ToList());

            dgvAutores.DataSource = listaAutores;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}

