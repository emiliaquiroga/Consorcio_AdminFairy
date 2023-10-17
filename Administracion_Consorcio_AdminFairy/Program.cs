using Entidades;
using Microsoft.VisualBasic.Logging;


namespace Administracion_Consorcio_AdminFairy
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());


            
            
        }
    }

}
