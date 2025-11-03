using BackOfficeMuseo.Autores;
using BackOfficeMuseo.Helpers;
using BackOfficeMuseo.Procedencia;
using Clases.Obras;
using Clases.Procedencias;
using System;
using System.Windows.Forms;

namespace BackOfficeMuseo.Obras
{
    public partial class AltaObra : Form
    {
        private int contadorErrores = 0;
        private Obra obra;
        private Donacion donacion;
        private Prestamo prestamo;
     
        public AltaObra()
        {
            prestamo = new Prestamo();
            donacion = new Donacion();
            obra = new Obra();
            InitializeComponent();
        }

        private void cbEpoca_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
            {
                MessageBox.Show("Por favor, corrija los errores en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSeleccionarAutor_Click(object sender, EventArgs e)
        {
         FrmAutor frmAutor = new FrmAutor();
            if(frmAutor.ShowDialog() == DialogResult.OK)
            {
                var autoresSeleccionados = frmAutor.AutoresSeleccionados;
                foreach(var autor in autoresSeleccionados)
                {
                    clbAutores.Items.Add(autor);
                }
            }


        }
        private bool IsValidForm()
        {
       
                return contadorErrores == 0;

        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            contadorErrores += Convert.ToInt32(TextBoxValidationHelper.InputIsValid(txtTitulo, lblErrorTitulo));
        }

        private void cboProcedencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcedenciaObra procedenciaObra = (ProcedenciaObra)cboProcedencia.SelectedIndex;
            switch (procedenciaObra)
            {

                case ProcedenciaObra.Compra:
                    CompraObra frmCompra = new CompraObra();
                    DialogResult resultCompra = frmCompra.ShowDialog();
                    if(resultCompra == DialogResult.OK)
                    {
                        obra.Procedencia = frmCompra.CompraObra;

                    }
                    break;
                case ProcedenciaObra.Donacion:
                    DonacionObra frmDonacion = new DonacionObra();
                    DialogResult resultDonacion = frmDonacion.ShowDialog();
                    if (resultDonacion == DialogResult.OK)
                    {
                        donacion.Procedencia = frmDonacion.DonacionObra;

                    }
                    break;
                case ProcedenciaObra.Prestamo:
                    PrestamoObra frmPrestamo = new PrestamoObra();
                    DialogResult resultPrestamo = frmPrestamo.ShowDialog();
                    if (resultPrestamo == DialogResult.OK)
                    {
                        prestamo.Procedencia = frmPrestamo.PrestamoObra;

                    }
                    break;

            }
        }
    }
}
