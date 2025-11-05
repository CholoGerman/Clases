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
            cboMoneda.SelectedIndex = 0;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(nudImporte.Value <= 0)
            {
                MessageBox.Show("El importe debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(dtpFechaCompra.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de compra no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            CompraObra = new Compra
            {
                Monto = nudImporte.Value,
                Moneda = cboMoneda.SelectedItem.ToString(),
                dtpFechaCompra = dtpFechaCompra.Value,
                OtrosDatos = txtObservaciones.Text
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
