using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Serializadores
{
    public class SerializadorJSON<T> : Serializador<T> where T : class
    {
        string ruta;
        string nombre;
        string path;



        public SerializadorJSON(string path) : base(path)
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            nombre = @"\ArchivoJSON.json";
            path = ruta + nombre;
            
        }


        public bool Serializar(T datos)
        {
            try
            {
                using (var stream = new StreamWriter(this.path))
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    var json = JsonConvert.SerializeObject(datos, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(this.path,json);

                }
                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al leer/escribir el archivo JSON: {ex.ToString()}");
                return false;
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                Console.WriteLine($"Error al deserializar/serializar JSON: {ex.ToString()}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al serializar");
                return false;
            }

        }
        public List<T> Deserializar()
        {
            List<T> lista = new List<T>();
            
            try
            {
                var json = File.ReadAllText(this.path);
                lista = JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());  // Nos mostrará su mensaje
            }

            return lista;
        }

    }
}
