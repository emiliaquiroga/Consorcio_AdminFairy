using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Vecino : Usuario
    {
        
        public string _email;
        public string edificio;
        public string ciudad;
        public string _unidadVivienda;
        public string _pisoVivienda;
        public EstadoExpensas expensas;
        public EstadoVecino estadoVecino;


        public Vecino()
        {
            
        }
        public Vecino(string nombre, string apellido, string dni, string clave, string email, string unidadVivienda, string pisoVivienda):base(nombre,apellido,dni,clave)
        {
            
            _email = email;
            _unidadVivienda = unidadVivienda;
            _pisoVivienda = pisoVivienda;
        }

        #region Getters y Setters
        public string Email { get => _email; set => _email = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string UnidadVivienda { get => _unidadVivienda; set => _unidadVivienda = value; }
        public string PisoVivienda { get => _pisoVivienda; set => _pisoVivienda = value; }
        public EstadoExpensas Expensas { get => expensas; set => expensas = value; }
        public EstadoVecino EstadoVecino { get => estadoVecino; set => estadoVecino = value; }
        #endregion
        
        public override string MostrarDatos()
        {
           return $"VECINO:\tNombre: {this.Nombre},\nApellido: {this.Apellido},\nDNI: {this.Dni},\nClave: {this.Clave},\nCorreo Electrónico: {this.Email}," +
                $"\nCiudad: {this.Ciudad},\nTorre: {this.Edificio},\nDepto.: {this.PisoVivienda}{this.UnidadVivienda},\nEstado de Expensas: {this.Expensas},\nEstado del vecino:{this.EstadoVecino}";
        }
        /*
        ver expensas
        hacer un reclamo
        ver contacto support 
         */
    }
}
