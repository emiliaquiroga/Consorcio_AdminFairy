using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class SinContenidoException : Exception 
    {
        public SinContenidoException() { }

        public SinContenidoException(string message)
            : base(message) { }

        public SinContenidoException(string message, Exception inner)
            : base(message, inner) { }

    }
}
