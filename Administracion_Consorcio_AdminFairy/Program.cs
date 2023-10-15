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

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            string nombre = @"\UsuariosRegistrados.xml"; // nombre del archivo
            string path = ruta + nombre;

            // Crear un administrador 
            //Administrador admin = new Administrador("Jazmin", "Mereles", "41958704", "claveAdmin");
            
            
        }
    }

}
