using BackOfficeMuseo.Donantes;
using BackOfficeMuseo.Helpers;
using Clases.Personas;
using Museo.Entities.Utilidades;
using Museo.Interfaces;
using MuseoBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeMuseo.Procedencia
{
    public partial class FrmDonacion : Form
    {
        public Donacion Donacion { get; private set; }
        public FrmDonacion()
        {
            InitializeComponent();
        }
        private void chkExponer_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CompletarDatosDonacion();
                DialogResult = DialogResult.OK;
                this.Close();


            }
            else {
                
                MessageBox.Show("Por favor, corrija los errores en el formulario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private bool ValidarDatos()
        {
            int fallos = 0;
            if (cboDonante.SelectedIndex <= 0)
            {
                ControlValidationHelper.MarcarControlComoInvalido(cboDonante);
                fallos++;
            }
            else
            {
                ControlValidationHelper.MarcarControlComoValido(cboDonante);
            }

            return fallos == 0; 

        }
        private void FrmDonacion_Load(object sender, EventArgs e)
        {
          cboDonante.Items.Add(new Donante { Id = 0, Nombre = "--Seleccione un Donante--" });
            cboDonante.Items.AddRange(CargarDonantes());
        }



        private object[] CargarDonantes()
        {
            IDonantes manejadorDonantes = new ManejadorDonantes();
            var donantes = manejadorDonantes.ListarDonantes();
            return donantes.ToArray();
        }

        private void cboDonante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDonante.SelectedIndex == 0)
            {
                FrmDonante frmDonante = new FrmDonante();
                var result = frmDonante.ShowDialog();
                if (result == DialogResult.OK)
                {
                  
                    cboDonante.Items.Clear();
                    cboDonante.Items.Add(new Donante { Id = 0, Nombre = "--Seleccione un Donante--" });
                    cboDonante.Items.AddRange(CargarDonantes());
                    cboDonante.SelectedItem = frmDonante.DonanteSeleccionado;
                }
            }
            Donacion.Donante = (Donante)cboDonante.SelectedItem;
        }
        private void CompletarDatosDonacion()
        {
            FrmDonacion = new Donacion
            {
                Donante = (Donante)cboDonante.SelectedItem,
                SePuedePrestar = chkPrestar.Checked,
                SePuedeExponer = chkExponer.Checked,
                TiempoExposicion = chkExponer.Checked ? (short)nudMeses.Value : (short)0,
                CondicionesEspeciales = txtCondiciones.Text,
                OtrosDatos = txtObservaciones.Text
            };

        }
    }
    
}
