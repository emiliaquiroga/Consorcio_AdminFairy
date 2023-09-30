using Entidades;


namespace Administracion_Consorcio_AdminFairy
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());

            Usuario usuario = new Usuario("Emilia", 41958704, "hola", "charcas 2594");
        }
    }
}

