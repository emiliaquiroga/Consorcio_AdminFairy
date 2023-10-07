using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
        
        public override void MostrarDatos()
        {
            Console.WriteLine($"VECINO:\tNombre: {this._nombre}, Apellido {this._apellido}", nameof(_dni), this._dni);
        }
        /*
        ver expensas
        hacer un reclamo
        ver contacto support 
         */
    }
}
