using System.Windows.Forms;

namespace BackOfficeMuseo.Helpers
{
    internal static class ControlValidationHelper
    {
        public static void MarcarControlComoValido(Control control)
        {
            control.BackColor = System.Drawing.Color.White;
            control.ForeColor = System.Drawing.Color.Black;

        }
        public static void MarcarControlComoInvalido(Control control)
        {
            control.BackColor = System.Drawing.Color.MistyRose;
            control.ForeColor = System.Drawing.Color.Red;
        }

    }
}
