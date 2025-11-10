using Museo.Entities.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Museo.Interfaces;
using MuseoBusinessLogic;

namespace BackOfficeMuseo.Donantes
{
    public partial class FrmDonante : Form
    {
        IDonantes ManejadorDonantes = new ManejadorDonantes();
        public Donante DonanteSeleccionado { get; set; }
        public FrmDonante()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Donante donante = new Donante
            {
                Nombre =  txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                NumeroDocumento = txtCI.Text
            };
            ManejadorDonantes.AgregarDonante(donante);
            DonanteSeleccionado = donante;
            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
