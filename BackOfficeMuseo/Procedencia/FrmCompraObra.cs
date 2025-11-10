using Clases.Procedencias;
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
    public partial class FrmCompraObra : Form
    {

        public FrmCompraObra()
        {
            InitializeComponent();
            cboMoneda.SelectedIndex = 0;
         
        }

        public Compra CompraCreada { get; private set; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (nudImporte.Value <= 0)
            {
                MessageBox.Show("El importe debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpFechaCompra.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de compra no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CompraCreada = new Compra
            {
                Monto = nudImporte.Value,
                Moneda = cboMoneda.SelectedItem.ToString(),
                Fecha = dtpFechaCompra.Value,
                OtrosDatos = txtObservaciones.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
