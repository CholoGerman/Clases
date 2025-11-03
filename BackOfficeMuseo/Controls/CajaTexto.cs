using BackOfficeMuseo.Helpers;
using System;
using System.Windows.Forms;


namespace BackOfficeMuseo.Controls
{
    public partial class CajaTexto : UserControl
    {
        public bool HasError { get; private set; }
        public string TextValue
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }
        public CajaTexto()
        {
            InitializeComponent();
        }



        private void txtInput_Leave_1(object sender, EventArgs e)
        {
           HasError = TextBoxValidationHelper.InputIsValid(txtInput, lblErrorInput);

        }
    }
}
