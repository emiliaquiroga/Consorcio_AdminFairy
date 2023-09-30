 namespace Entidades
{
    public class Usuario
    {
        // tiene que tener: dni, contraserña, Ese dni tiene que estar en el XML con un nombre, apellido y un numero de depto (1°B)
        protected string nombre;
        private string dni;
        private string clave;
        private string direccion;

        public Usuario()
        {

        }

        public Usuario(string nombre, string dni, string clave, string direccion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.clave = clave;
            this.direccion = direccion;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}