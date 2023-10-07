 namespace Entidades
{
    public abstract class Usuario
    {
        #region Atributos
        // tiene que tener: dni, contraserña, Ese dni tiene que estar en el XML con un nombre, apellido y un numero de depto (1°B)
        public string _nombre;
        public string _apellido;
        public string _dni;
        public string _clave;
        #endregion

        #region Constructores
        public Usuario()
        {

        }

        public Usuario(string nombre, string apellido, string dni, string clave)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._clave = clave;
        }
        #endregion

        #region Getters y Setters
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Apellido { get => _apellido; set => _apellido = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Clave { get => _clave; set => _clave = value; }
        #endregion

        public abstract void MostrarDatos(); // metodo abstracto para que sus herederos lo override


    }
}