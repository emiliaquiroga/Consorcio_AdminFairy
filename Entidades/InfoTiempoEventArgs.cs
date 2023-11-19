using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InfoTiempoEventArgs : EventArgs
    {
        public int hora;
        public int minuto;
        public int segundo;

        public InfoTiempoEventArgs(int h, int m, int s)
        {
            this.hora = h;
            this.minuto = m;
            this.segundo = s;
        }

    }
}
