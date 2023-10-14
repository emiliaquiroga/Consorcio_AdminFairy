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

            // Crear un administrador y un vecino predeterminados
            //Administrador admin = new Administrador("Jazmin", "Mereles", "41958704", "claveAdmin");
            Vecino vecinoInicial = new Vecino("Emilia", "Quiroga", "41958704", "claveVecino", "emilia@vecina.com", "B", "1");
            
            //// Agregar los usuarios predeterminados al archivo XML
            //AgregarUsuarioPredeterminado(path, (Usuario)admin);
            AgregarUsuarioPredeterminado(path, (Usuario)vecinoInicial);
        }

        private static void AgregarUsuarioPredeterminado(string path, Usuario usuario)
        {
            try
            {
                
                Serializadora.EscribirXML(path, (Usuario)usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("NO SE PUDO ESCRIBIR XML PREDETERMINADO");
            }
        }
    }

}
