using BackOfficeMuseo.Obras;
using BackOfficeMuseo.Procedencia;
using System;
using System.Windows.Forms;

namespace BackOfficeMuseo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaObra frmAltaObra = new AltaObra();
            frmAltaObra.MdiParent = this;
            frmAltaObra.Show();


        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamoObra frmAltaObra = new PrestamoObra();
            frmAltaObra.MdiParent = this;
            frmAltaObra.Show();

        }

        private void donacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonacionObra frmAltaObra = new DonacionObra();
            frmAltaObra.MdiParent = this;
            frmAltaObra.Show();

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraObra frmAltaObra = new CompraObra();
            frmAltaObra.MdiParent = this;
            frmAltaObra.Show();
        }
    }
}
