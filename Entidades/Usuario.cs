 namespace Entidades
{
    public class Usuario
    {
        #region Atributos
        // tiene que tener: dni, contraserña, Ese dni tiene que estar en el XML con un nombre, apellido y un numero de depto (1°B)
        private string nombre;
        private string apellido;
        private string dni;
        private string clave;
        #endregion

        #region Constructores
        public Usuario()
        {

        }

        public Usuario(string nombre, string apellido, string dni, string clave)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Clave = clave;
        }
        #endregion

        #region Propiedades
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Clave { get => clave; set => clave = value; }
        #endregion 

        // alternar modo dia/modo noche
    }
}