using System.Windows.Forms;

namespace BackOfficeMuseo.Helpers
{
    internal static class TextBoxValidationHelper
    {
        public static bool InputIsValid(TextBox textBox,Label errorLabel)
        {
            if(textBox == null || errorLabel == null)
            {

              MessageBox.Show("Los parametros recibidos no son válidos", "Error de inicializacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;           
            }

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorLabel.Visible = true;
                return false;
            }
           
            
                errorLabel.Visible = false;
            
            return true;
        }
    }
}
