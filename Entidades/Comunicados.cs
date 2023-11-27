using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comunicados
    {
        private string contenido;
        private DateTime fecha;

        public Comunicados() 
        {
        }
        public Comunicados(string contenido, DateTime fecha)
        {
            Contenido = contenido;
            Fecha = fecha;
        }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public override string ToString()
        {
            return $"Vecinos:\n{Fecha.ToString("yyyy-MM-dd HH:mm")}\n{Contenido}";
        }
        
    }
}
