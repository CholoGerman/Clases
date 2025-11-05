using BackOfficeMuseo.Autores;
using BackOfficeMuseo.Helpers;
using BackOfficeMuseo.Procedencia;
using Clases.Obras;
using Clases.Personas;
using Clases.Procedencias;
using Museo.Entities.Personas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackOfficeMuseo.Obras
{
    public partial class FrmAltaObra : Form
    {
        private int contadorErrores = 0;
        private Obra obra;
        private Donacion donacion;
        private Prestamo prestamo;
     
        public FrmAltaObra()
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
            LeerDatosDeLaObra();
            MessageBox.Show("Obra registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LeerDatosDeLaObra()
        {
            obra.Titulo = txtTitulo.Text;
            obra.Epoca = (EpocaArte)cboEpoca.SelectedIndex;
          List<Autor> autores = new List<Autor>();
            for(int i =0; i < clbAutores.Items.Count; i++)
            {
                autores.Add((Autor)clbAutores.Items[i]);
            }
            obra.Autores = autores;
            obra.FechaCreacion = dtpFechaCreacion.Value;
            obra.FechaPublicacion = dtpFechaPublicacion.Value;
            obra.Descripcion = txtDescripcion.Text;
            obra.Epoca = (EpocaArte)cboEpoca.SelectedIndex;
            obra.EsCopia = chkEsCopia.Checked;
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
       
                if(clbAutores.Items.Count == 0)
                {
                ControlValidationHelper.MarcarControlComoInvalido(clbAutores);
                contadorErrores++;
                }
                else
            {
                ControlValidationHelper.MarcarControlComoValido(clbAutores);
              
            }
                if(cboEpoca.SelectedIndex < 0)
            {
                ControlValidationHelper.MarcarControlComoInvalido(cboProcedencia);
                contadorErrores++;
            }
            else
            {
                ControlValidationHelper.MarcarControlComoValido(cboProcedencia);
             
            }
                if(!TextBoxValidationHelper.InputIsValid(txtTitulo, lblErrorTitulo))
            
                contadorErrores++;
          
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
                    FrmCompraObra frmCompra = new FrmCompraObra();
                    DialogResult resultCompra = frmCompra.ShowDialog();
                    if(resultCompra == DialogResult.OK)
                    {
                        obra.Procedencia = frmCompra.CompraObra;

                    }
                    break;
                case ProcedenciaObra.Donacion:
                    FrmDonacion frmDonacion = new FrmDonacion();
                    DialogResult resultDonacion = frmDonacion.ShowDialog();
                    if (resultDonacion == DialogResult.OK)
                    {
                        donacion.Procedencia = frmDonacion.DonacionObra;

                    }
                    break;
                case ProcedenciaObra.Prestamo:
                    FrmPrestamo frmPrestamo = new FrmPrestamo();
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
