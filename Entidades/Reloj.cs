using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reloj
    {
        public delegate void NotificadorCambioTiempo(Reloj reloj);
        // El delegado es el que encapsula ese metodo manejador que se va a ejecutar cuando se dispare el evento

        public event NotificadorCambioTiempo SegundoCambiado;

        public int hora;
        public int minuto;
        public int segundo;

        public void Ejecutar()
        { 
            Task.Run(() =>  // Hilo secundario
            { 
                while (true) // Bucle infinito
                {
              
                    DateTime dt = DateTime.Now;
                    Thread.Sleep(10); // 100 veces por segundo 

                    if(dt.Second != segundo) // Compruebo que mi atributo segundo, sea distinto al del sistema
                    { 
                        if (SegundoCambiado != null) // Comprobamos que este evento tenga un manejador asociado
                        {
                            SegundoCambiado.Invoke(this); // Si lo tiene, disparamos el evento
                        }               
                    
                    }

                    // Actualizo los atributos
                    this.segundo = dt.Second;
                    this.minuto = dt.Minute;
                    this.hora = dt.Hour;
                }
                
            });
        
        }

        public override string ToString()
        {
            return $"{hora:D2} : {minuto:D2} : {segundo:D2}";
        }


    }
}
