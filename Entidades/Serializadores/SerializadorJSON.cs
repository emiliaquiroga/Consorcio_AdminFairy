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
    public class SerializadorJSON<T> : Serializador<T> 
    {
        string ruta;
        string nombre;
       

        public SerializadorJSON()
        {
                
        }

        public SerializadorJSON(string path) : base(path)
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            nombre = @"\ArchivoJSON.json";
            Path = System.IO.Path.Combine(ruta, nombre);

        }


        public bool Serializar(T datos)
        {
            try
            {
                using (var stream = new StreamWriter(this.Path))
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    var json = JsonConvert.SerializeObject(datos, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(this.Path,json);

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
                var json = File.ReadAllText(this.Path);
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
