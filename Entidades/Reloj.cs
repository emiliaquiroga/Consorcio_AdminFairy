using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reloj
    {
        public delegate void NotificadorCambioTiempo(object reloj, InfoTiempoEventArgs infoTiempo);

        public event NotificadorCambioTiempo SegundoCambiado;

        public int hora;
        public int minuto;
        public int segundo;

        public void Ejecutar()
        {
            for (; ; ) // bucle infinito
            {
                Thread.Sleep(1000);

                DateTime dt = DateTime.Now;

                if(dt.Second != segundo)
                {
                    InfoTiempoEventArgs infoTiempo = new InfoTiempoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    if (SegundoCambiado is not null)
                    {
                        SegundoCambiado.Invoke(this, infoTiempo);
                    }
                }

                this.segundo = dt.Second;
                this.minuto = dt.Minute;
                this.hora = dt.Hour;


            }
        }

    }
}
