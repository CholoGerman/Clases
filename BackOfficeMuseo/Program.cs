using System;
using System.Windows.Forms;

namespace BackOfficeMuseo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Main()); // Solo se crea una instancia
        }
    }
}
