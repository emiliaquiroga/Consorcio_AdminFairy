using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Serializadores
{
    public class SerializadorTXT<T> : Serializador<T> where T : Errores
    {
        public string ruta;
        public string nombre;
        public SerializadorTXT()
        {
                
        }
        public SerializadorTXT(string path) : base(path)
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            nombre = @"\ArchivoErrores.txt";
            Path = System.IO.Path.Combine(ruta, nombre);
        }

        public void RegistrarError(string descripcion, string clase, string metodo)
        {
            var error = new Errores
            {
                FechaHora = DateTime.Now,
                Descripcion = descripcion,
                Clase = clase,
                Metodo = metodo
            };

            // Registra el error en el archivo de Serializador
            Serializar(error);
        }

        public List<Errores> ObtenerErrores()
        {
            // Obtiene la lista de errores desde el archivo de log
            return Deserializar();
        }

        // Implementación de Serializar específica para errores
        private bool Serializar(Errores datos)
        {
            try
            {
                // Abre o crea el archivo de log
                using (StreamWriter sw = File.AppendText(this.Path))
                {
                    // Escribe los datos en el archivo
                    sw.WriteLine($"{datos.FechaHora} - {datos.Descripcion} - {datos.Clase} - {datos.Metodo}");
                }

                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores al intentar escribir en el archivo de log
                Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
                return false;
            }
        }

        // Implementación de Deserializar específica para errores
        private List<Errores> Deserializar()
        {
            List<Errores> errores = new List<Errores>();

            try
            {
                // Lee el archivo de log y deserializa los errores
                using (StreamReader sr = new StreamReader(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine()?.Split(" - ");

                        if (parts?.Length == 4)
                        {
                            Errores error = new Errores
                            {
                                FechaHora = DateTime.Parse(parts[0]),
                                Descripcion = parts[1],
                                Clase = parts[2],
                                Metodo = parts[3]
                            };

                            errores.Add(error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores al intentar leer el archivo de log
                Console.WriteLine($"Error al leer el archivo de log: {ex.Message}");
            }

            return errores;
        }
    }
}

