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

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());


            Administrador adminEmi = new Administrador("emilia","quiroga", "41958704", "hola" );

            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add( adminEmi );


            // ARREGLAR
            

        }
    }
}

