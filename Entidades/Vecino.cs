using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vecino : Usuario
    {
        private string email;
        private string unidadVivienda;
        private int pisoVivienda;

        public Vecino(string nombre, string apellido, string dni, string clave, string email, string unidadVivienda, int pisoVivienda) : base(nombre, apellido, dni, clave)
        {
            this.email = email;
            this.unidadVivienda = unidadVivienda;
            this.pisoVivienda = pisoVivienda;
        }

        public string Email { get => email; set => email = value; }
        public string UnidadVivienda { get => unidadVivienda; set => unidadVivienda = value; }
        public int PisoVivienda { get => pisoVivienda; set => pisoVivienda = value; }

        /*
        ver expensas
        hacer un reclamo
        ver contacto support 
         */
    }
}
