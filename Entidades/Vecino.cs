using Newtonsoft.Json;
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
        

        private string _email;
        private string edificio;
        private string ciudad;
        private string _unidadVivienda;
        private string _pisoVivienda;
        private int expensas;
        private EstadoVecino estadoVecino;
        private string _duenioInquilino;


        public Vecino()
        {
            
        }
        public Vecino(string nombre, string apellido, string dni, string clave, string email, string unidadVivienda, string pisoVivienda, string duenioInquilino):base(nombre,apellido,dni,clave)
        {
            
            _email = email;
            _unidadVivienda = unidadVivienda;
            _pisoVivienda = pisoVivienda;
            _duenioInquilino = duenioInquilino;
        }

        #region Getters y Setters
        public string Email { get => _email; set => _email = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string UnidadVivienda { get => _unidadVivienda; set => _unidadVivienda = value; }
        public string PisoVivienda { get => _pisoVivienda; set => _pisoVivienda = value; }
        public int Expensas { get => expensas; set => expensas = value; }
        public EstadoVecino EstadoVecino { get => estadoVecino; set => estadoVecino = value; }

        public string DuenioInquilino { get => _duenioInquilino; set => _duenioInquilino = value; }
        #endregion
        
        public override string MostrarDatos()
        {
           return $"VECINO:\tNombre: {this.Nombre},\nApellido: {this.Apellido},\nDNI: {this.Dni},\nClave: {this.Clave},\nCorreo Electrónico: {this.Email}," +
                $"\nCiudad: {this.Ciudad},\nTorre: {this.Edificio},\nDepto.: {this.PisoVivienda}{this.UnidadVivienda},\nEstado de Expensas: {this.Expensas},\nEstado del vecino:{this.EstadoVecino}";
        }
      
    }
}
