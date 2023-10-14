using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Administrador : Usuario
    {
        public Administrador()
        {
            
        }

        public Administrador(string nombre, string apellido, string dni, string clave):base(nombre, apellido, dni, clave)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this.Dni = dni;
            this.Clave = clave;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Clave { get => _clave; set => _clave = value; }

        public override string MostrarDatos()
        {
            return $"Nombre: {this._nombre},\nApellido {this._apellido},\nDNI: {this.Dni},\nClave: {this.Clave}";
        }

        private void EliminarUsuario()
        {
            //elimina usuario
        }
        private void DarAltaUsuario()
        {
            //aceptar usuarios que se registren! tendria que el admin dar el ok en un datagrid una vez que el usuario se registre? 
        }

        private void SancionarUsuario(Vecino vecino)
        {
            //get
            //{
            //    vecino.EstadoVecino ;
            //}
            //set
            //    {
            //    vecino.EstadoVecino = Sancionado;
            //}
        }


        /*
        crear un comunicado
        eliminar/editar vecino
        suspender vecino
        app en mantenimiento (opcional)
        modificar expensas/precios // EN UN ARCHIVO
        modificar roles
        establecer reglas y normativas
        -muestra email support y contactos de emergencia (plomero, cerrajero y electricista)-
         */
    }
}
