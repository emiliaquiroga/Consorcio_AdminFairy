 namespace Entidades
{
    public class Usuario
    {
        // tiene que tener: dni, contraserña, Ese dni tiene que estar en el XML con un nombre, apellido y un numero de depto (1°B)
        private string nombre;
        private string apellido;
        private string email;
        private string dni;
        private string clave;
        protected string direccion;
        protected string ciudad;
        public string situacion;
        public string piso;
        public string departamento;

        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected string Email { get => email; set => email = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Clave { get => clave; set => clave = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected string Ciudad { get => ciudad; set => ciudad = value; }
        protected string Situacion { get => situacion; set => situacion = value; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string dni, string clave, string direccion)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Clave = clave;
            this.Direccion = direccion;
        }

    }
}