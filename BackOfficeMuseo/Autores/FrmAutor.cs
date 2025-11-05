#region MyRegion
using Clases.Personas;
using CommonEntities.Interfaces;
using FileAccess;
using Museo.Entities.Personas;
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
        IGenericFileManager<Autor> jsonManager = new GenericJasonManager<Autor>();
        string filename = ConfigurationManager.AppSettings["ArchivoAutores"];
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
            jsonManager.Guardar(filename, _autores.ToList());


            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void FrmAutor_Load(object sender, EventArgs e)
        {
        


            List<Autor> autores = new List<Autor>();
            {
                new Autor { Id = 1, Nombre = "Pablo", Apellido = "Picasso", Biografia = "Pintor y escultor español" };
             };

            jsonManager.Guardar(filename, autores);
            _autores = jsonManager.Leer(filename);
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

