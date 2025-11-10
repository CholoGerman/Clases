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
            this.IsMdiContainer = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Crear el formulario hijo dentro del mismo Main (esto sí funciona)
            var formObras = new FrmCompraObra();
            formObras.MdiParent = this;
            formObras.Show();
        }
    }
}
